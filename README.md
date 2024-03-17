# Kalorimetre Uygulaması (.NET 8.0)

Bu uygulama, enerji tüketimine dayalı olarak bir binanın doğal gaz faturasını daireler arasında paylaştırmak için kullanılır. Kullanıcılar doğal gaz fatura tutarı ve dairelerdeki enerji tüketimlerini girerek her dairenin ödemesi gereken miktarı hesaplar.

## Kullanım

1. **Başlangıç Ekranı**: Uygulama başladığında, doğal gaz fatura tutarı, toplam okunan enerji ve bir dosya adı girilmesi gereken bir giriş ekranı görüntülenir.
2. **Giriş Bilgileri**: Kullanıcı doğal gaz fatura tutarını, toplam okunan enerjiyi ve bir dosya adını girdikten sonra "Gir" butonuna tıklar.
3. **Daire Enerji Girişi**: Ardından her bir dairenin enerji tüketimleri sırasıyla girilmelidir. Her bir dairenin enerji tüketimi girildikten sonra "Hesapla" butonuna tıklanarak hesaplama yapılır. Toplam 24 daire için hesaplama yapılır.
4. **Sonuçlar**: Hesaplama tamamlandığında, sonuçlar bir metin dosyasına ve bir Excel dosyasına kaydedilir.

## Dosya Formatı

Hesaplama sonuçları aşağıdaki formatlarla txt ve excel dosyasına kaydedilir:

## Txt Dosyası

Daire Numarası | Okunan Enerji | Sabit Gider | Tüketim Gideri | Toplam Gider
---------------|----------------|-------------|----------------|-------------
1              | 120            | 50.00       | 70.00          | 120.00
2              | 130            | 52.00       | 78.00          | 130.00
...            | ...            | ...         | ...            | ...
Toplam         | 3250           | 1425.00     | 1825.00        | 3250.00
Kayıp (kaçak)  | 0.00


## Excel Dosyası

Excel dosyası aşağıdaki formatta oluşturulur:

| Daire | Tutar |
|-------|-------|
|   1   | 120.00|
|   2   | 130.00|
|  ...  |  ...  |

Uygulama, .NET 8.0 sürümü kullanılarak geliştirilmiştir. Doğal gaz faturasını daireler arasında adil bir şekilde dağıtmak için kullanılabilir. Her bir dairenin ödemesi gereken miktarın hesaplanmasında alan ve enerji tüketimi gibi faktörler dikkate alınır.
