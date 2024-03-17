namespace Kalorimetre
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            label4 = new Label();
            richTextBox1 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            richTextBox3 = new RichTextBox();
            richTextBox4 = new RichTextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(32, 32);
            label1.Name = "label1";
            label1.Size = new Size(296, 37);
            label1.TabIndex = 1;
            label1.Text = "Doğal Gaz Fatura Tutarı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(32, 89);
            label2.Name = "label2";
            label2.Size = new Size(276, 37);
            label2.TabIndex = 3;
            label2.Text = "Toplam Okunan Enerji";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F);
            label3.Location = new Point(31, 44);
            label3.Name = "label3";
            label3.Size = new Size(252, 37);
            label3.TabIndex = 5;
            label3.Text = "Daire Okunan Enerji";
            // 
            // button1
            // 
            button1.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(483, 200);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(174, 53);
            button1.TabIndex = 8;
            button1.Text = "Gir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Gir_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(342, 100);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(174, 53);
            button2.TabIndex = 9;
            button2.Text = "Hesapla";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Hesapla_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F);
            label4.Location = new Point(32, 145);
            label4.Name = "label4";
            label4.Size = new Size(416, 37);
            label4.TabIndex = 11;
            label4.Text = "Dosya Başlığı (Ocak Ayı Faturaları)";
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point, 162);
            richTextBox1.Location = new Point(483, 32);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(173, 37);
            richTextBox1.TabIndex = 12;
            richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            richTextBox2.Font = new Font("Arial", 15F);
            richTextBox2.Location = new Point(483, 89);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(173, 37);
            richTextBox2.TabIndex = 13;
            richTextBox2.Text = "";
            // 
            // richTextBox3
            // 
            richTextBox3.Font = new Font("Arial", 15F);
            richTextBox3.Location = new Point(483, 145);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new Size(173, 37);
            richTextBox3.TabIndex = 14;
            richTextBox3.Text = "";
            // 
            // richTextBox4
            // 
            richTextBox4.Font = new Font("Arial", 15F);
            richTextBox4.Location = new Point(342, 44);
            richTextBox4.Name = "richTextBox4";
            richTextBox4.Size = new Size(173, 37);
            richTextBox4.TabIndex = 15;
            richTextBox4.Text = "";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(richTextBox1);
            panel1.Controls.Add(richTextBox2);
            panel1.Controls.Add(richTextBox3);
            panel1.Location = new Point(46, 36);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(670, 255);
            panel1.TabIndex = 21;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackgroundImageLayout = ImageLayout.None;
            panel2.Controls.Add(button2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(richTextBox4);
            panel2.Location = new Point(46, 299);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(670, 187);
            panel2.TabIndex = 22;
            panel2.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(782, 503);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(800, 550);
            Name = "Form1";
            Text = "Pay Ölçer";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
        private Label label4;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private RichTextBox richTextBox3;
        private RichTextBox richTextBox4;
        private Panel panel1;
        private Panel panel2;
    }
}
