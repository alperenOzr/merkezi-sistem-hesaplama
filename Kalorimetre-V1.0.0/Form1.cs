using System;
using System.IO;
using System.Windows.Forms;
using System.Reflection.Metadata;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;

namespace Kalorimetre
{
    public partial class Form1 : Form
    {
        bool tekSeferlikHesapla = true;
        public int i = 1, duzenlenecekNO;

        // Binanýn alaný ve dairelerin alaný
        private readonly int[] alan = {3600, 125, 145, 145, 125,
                                             125, 145, 145, 125,
                                             125, 145, 145, 125,
                                             125, 145, 145, 125,
                                             125, 145, 145, 125,
                                             165, 165, 220, 165};
        public double ortakOdemePaylasilcakTutar, tuketimePaylasilcakTutar, ortak, tuketim, toplamOkunanEnerji2 = 0, toplam = 0,
                      toplamSabit = 0, toplamTuketim = 0, dogalGazFaturaTutari, toplamOkunanEnerji, daireEnerji;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ExcelOlustur();
        }

        private void Gir_Click(object sender, EventArgs e)
        {
            if (double.TryParse(richTextBox1.Text, out dogalGazFaturaTutari) &&
                double.TryParse(richTextBox2.Text, out toplamOkunanEnerji) &&
                richTextBox3.Text != "")
            {
                panel1.Enabled = false;
                panel2.Visible = true;
                label3.Text = i.ToString() + ". Daire Okunan Enerji";
            }
            else
            {
                // Dönüþümlerden en az biri baþarýsýzsa, kullanýcýya uygun bir mesaj gösterilir
                if (!double.TryParse(richTextBox1.Text, out _))
                {
                    MessageBox.Show("Geçerli Bir Doðal Gaz Fatura Tutarý Giriniz!!!", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (!double.TryParse(richTextBox2.Text, out _))
                {
                    MessageBox.Show("Geçerli Bir Toplam Okunan Enerji Giriniz!!!", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Gecerli Bir Dosya Adý Giriniz", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void Hesapla_Click(object sender, EventArgs e)
        {
            // Masaüstü konumunu bul
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string dosyaYolu = Path.Combine(desktopPath, richTextBox3.Text + ".txt");

            // Tek seferlik hesaplanacak iþlemler
            if (tekSeferlikHesapla)
            {
                ortakOdemePaylasilcakTutar = dogalGazFaturaTutari * 3 / 10;
                ortak = ortakOdemePaylasilcakTutar / alan[0];

                tuketimePaylasilcakTutar = dogalGazFaturaTutari * 7 / 10;
                tuketim = tuketimePaylasilcakTutar / toplamOkunanEnerji;

                tekSeferlikHesapla = !tekSeferlikHesapla;
            }
            // 24 kere(daire)
            if (i <= 24)
            {
                if (double.TryParse(richTextBox4.Text, out daireEnerji))
                {
                    double daireninOrtak = ortak * alan[i];
                    double daireninTuketimi = tuketim * daireEnerji;
                    toplam += daireninOrtak + daireninTuketimi;
                    toplamTuketim += daireninTuketimi;
                    toplamSabit += daireninOrtak;
                    toplamOkunanEnerji2 += daireEnerji;
                    
                    // Excele yaz
                    if (app != null && kitap != null && sayfa != null)
                    {
                        sayfa.Cells[1 + i, 1] = i.ToString();
                        sayfa.Cells[1 + i, 2] = (daireninTuketimi + daireninOrtak).ToString("F2");
                    }

                    if (File.Exists(dosyaYolu))
                    {
                        // Dosya varsa üzerine yaz
                        using (StreamWriter writer = File.AppendText(dosyaYolu))
                        {
                            writer.WriteLine(string.Format("{0,-19}{1,-18:0}{2,-16:0.00}{3,-19:0.00}{4:0.00}",
                                            i, daireEnerji, daireninOrtak, daireninTuketimi, daireninTuketimi + daireninOrtak));
                        }
                    }
                    else
                    {
                        // Dosya yoksa yeni dosya oluþtur ve veri ekle
                        using (StreamWriter writer = File.CreateText(dosyaYolu))
                        {
                            writer.WriteLine("Daire Numarasý     Okunan Enerji     Sabit Gider     Tüketim Gideri     Toplam Gider");
                            writer.WriteLine("--------------     -------------     -----------     --------------     ------------");
                            writer.WriteLine(string.Format("{0,-19}{1,-18:0}{2,-16:0.00}{3,-19:0.00}{4:0.00}",
                                            i, daireEnerji, daireninOrtak, daireninTuketimi, daireninTuketimi + daireninOrtak));
                        }
                    }

                    // Sayacý artýr
                    i++;
                    richTextBox4.Text = "";

                    if (i == 25)
                    {
                        richTextBox4.Visible = false;
                        button2.Visible = false;

                        using (StreamWriter writer = File.AppendText(dosyaYolu))
                        {
                            writer.Write("------------------------------------------------------------------------------------\nToplam             ");
                            writer.Write(string.Format("{0,-18:0}{1,-16:0.00}{2,-19:0.00}{3:0.00}",
                                            toplamOkunanEnerji2, toplamSabit, toplamTuketim, toplam));
                            
                            if (toplamOkunanEnerji != toplamOkunanEnerji2)
                            {
                                writer.Write("\nToplam(girilen)    ");
                                writer.Write(string.Format("{0,-18:0}{1,-16:0.00}{2,-19:0.00}{3:0.00}",
                                            toplamOkunanEnerji, toplamSabit, toplamTuketim, dogalGazFaturaTutari));
                            }

                            writer.Write("\nKayýp (kaçak) : " + (dogalGazFaturaTutari - toplam).ToString("F2"));
                        }
                        ExcelKapat();

                        if (toplamOkunanEnerji != toplamOkunanEnerji2)
                            label3.Text = "Girilen toplam enerji ile dairelerin toplam enerjileri\n eþleþmiyor yanlýþ olabilir programý kapatabilirsiniz";
                        else
                            label3.Text = "Faturlar hesaplanmýþtýr programý kapatabilirsiniz";
                    }
                    else
                        label3.Text = i.ToString() + ". Daire Okunan Enerji";
                }
                else
                {
                    // Dönüþümlerden en az biri baþarýsýzsa, kullanýcýya uygun bir mesaj gösterilir
                    MessageBox.Show("Geçerli Bir Daire Enerji Tutarý Giriniz!!!", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        Excel.Application? app;
        Workbook? kitap;
        Worksheet? sayfa;

        private void ExcelOlustur()
        {
            app = new Excel.Application();
            kitap = app.Workbooks.Add(System.Reflection.Missing.Value);
            sayfa = (Worksheet)kitap.Worksheets[1];

            // Sayfaya veri eklemek için örnek bir kod
            sayfa.Cells[1, 1] = "Daire";
            sayfa.Cells[1, 2] = "Tutar";
        }

        private void ExcelKapat()
        {
            if (app != null && kitap != null && sayfa != null)
            {
                // Masaüstü konumunu bul
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string dosyaYolu = Path.Combine(desktopPath, richTextBox3.Text + ".xlsx");

                // Olusturulan excel dosyasýný masaüstüne kaydet
                kitap.SaveAs(dosyaYolu);

                // Dosyayý kapat
                kitap.Close();
                app.Quit();
            }
        }
    }
}