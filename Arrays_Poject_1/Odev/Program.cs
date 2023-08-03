using Arrays_Poject_1.Odev;
using System;
using System.Collections.Generic;
using System.Text;
namespace Arrays_Poject_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //  TekBoyutDiziMethod1();
            //TekBoyutluIkiBoyutluDiziyeAta();
            //SehirleriDiziyeAktarMethod();
            //IliskiDurumuMethod();
          
            Ornek1 orn = new Ornek1();
            Ornek1.AyGir();
            Ornek1.PlakaEsleMethod();

            Mevsim mev = new Mevsim();
            mev.KisMethod();

            Console.ReadKey();
        }
        #region Tek Boyutlu Arrays Kullanımı
        static void TekBoyutDiziMethod1()
        {
            string[] gunler = { "pazartesi", "salı", "çarşamba", "perşembe", "cuma", "cumartesi", "pazar" };
            for (int i = 0; i < gunler.Length; i++)
            {
                Console.WriteLine($"haftanın {i + 1}. günü: {gunler[i]}");
            }


            Console.WriteLine("\n \n \n");
            string[] kisiler = { "Ahmet", "Ali", "Veli", "Ayşe", "Fatma", "Canan", "Gül", "Burak", "Beyza", "Enes" };
            int[] kisi = new int[kisiler.Length];
            for (int i = 0; i < kisiler.Length; i++)
            {
                kisi[i] = i + 1;
                Console.WriteLine($"{kisi[i]}. kişi {kisiler[i]}");
            }
            Console.WriteLine("\n \n \n ");
            Random rnd = new Random();
            int[] sayilar = new int[30];
            for (int i = 0; i < 30; i++)
            {
                sayilar[i] = rnd.Next(0, 100);
            }
            Array.Sort(sayilar);
            foreach (var eleman in sayilar)
            {
                Console.Write(eleman + "\t");
            }
        }
        static void TekBoyutluDiziMethod2()
        {
            string[] isimler = new string[10];
            isimler[0] = "ömer";
            isimler[1] = "mert";
            isimler[2] = "emre";
            isimler[3] = "oktay";
            isimler[4] = "ihsan";
            isimler[5] = "ali";
            isimler[6] = "mahmut";
            isimler[7] = "mustafa";
            isimler[8] = "fatma";
            isimler[9] = "ayşe";

            for (int i = 0; i < isimler.Length; i++)
            {
                Console.WriteLine(i + 1 + ". kişi: " + isimler[i]);
            }
            Random rnd = new Random();
            int rastgele = rnd.Next(0, isimler.Length);
            Console.WriteLine("Seçilmiş kişi ; " + isimler[rastgele]);
        }
        static void TekBoyutluDiziTanimMethod()
        {
            // Integer tipinde dizi tanımlama ve elemanları doğrudan atama
            int[] numbers = { 10, 20, 30, 40, 50 };

            // Double tipinde dizi tanımlama ve elemanları doğrudan atama
            double[] prices = { 12.45, 23.65, 9.99, 34.78, 5.50 };

            // String tipinde dizi tanımlama ve elemanları doğrudan atama
            String[] names = { "John", "Jane", "Michael" };

            // Integer tipinde dizi referansı tanımlama
            int[] Numaralar;
            // Dizi için bellekte yer ayırma (5 elemanlı)
            Numaralar = new int[5];

            // Double tipinde dizi referansı tanımlama
            double[] Fiyat;
            // Dizi için bellekte yer ayırma (10 elemanlı)
            Fiyat = new double[10];

            // String tipinde dizi referansı tanımlama
            String[] isimler;
            // Dizi için bellekte yer ayırma (3 elemanlı)
            isimler = new String[3];
        }

        #endregion

        #region İki boyutlu Arrays Kullanımı
        static void IkiBoyutArraysMethod()
        {

        }
        static void TekBoyutluIkiBoyutluDiziyeAta() // 1.yol
        {

            string[] gunler = { "pazartesi", "salı", "çarşamba", "perşembe", "cuma", "cumartesi", "pazar" };
            char[][] karakter = new char[gunler.Length][];

            for (int i = 0; i < gunler.Length; i++)
            {
                karakter[i] = gunler[i].ToCharArray();
            }

            // Elde edilen karakter dizisini ekrana yazdırma
            for (int i = 0; i < karakter.Length; i++)
            {
                Console.WriteLine("gunler[" + i + "]:");
                for (int j = 0; j < karakter[i].Length; j++)
                {
                    Console.Write(karakter[i][j] + " ");
                }
                Console.WriteLine();
            }
        }/// <summary>
         /// tek boyutlu diziyi çok boyutlu diziye aktarıyoruz string bir diziyi 
         /// </summary>
        static void TekBoyutluIkiBoyutluDiziyeAta2()
        {//2 .yol
            string[] gunler = { "pazartesi", "salı", "çarşamba", "perşembe", "cuma", "cumartesi", "pazar" };
            char[][] karakter = new char[gunler.Length][];

            int i = 0;
            foreach (string gun in gunler)
            {
                karakter[i++] = gun.ToCharArray();
            }

            // Elde edilen karakter dizisini ekrana yazdırma
            for (int j = 0; j < karakter.Length; j++)
            {
                Console.WriteLine("gunler[" + j + "]:");
                for (int k = 0; k < karakter[j].Length; k++)
                {
                    Console.Write(karakter[j][k] + " ");
                }
                Console.WriteLine();
            }

        }
        #endregion

        #region sehirleri diziye aktar
        static void SehirleriDiziyeAktarMethod()
        {
            string sehirler = "Adana Adıyaman Afyonkarahisar Ağrı Aksaray Amasya Ankara Antalya Ardahan Artvin Aydın Balıkesir Bartın Batman Bayburt Bilecik Bingöl Bitlis Bolu Burdur Bursa Çanakkale Çankırı Çorum Denizli Diyarbakır Düzce Edirne Elazığ Erzincan Erzurum Eskişehir Gaziantep Giresun Gümüşhane Hakkari Hatay Iğdır Isparta İstanbul İzmir K.Maraş Karabük Karaman Kars Kastamonu Kayseri Kırıkkale Kırklareli Kırşehir Kilis Kocaeli Konya Kütahya Malatya Manisa Mardin Mersin Muğla Muş Nevşehir Niğde Ordu Osmaniye Rize Sakarya Samsun Şanlıurfa Siirt Sinop Sivas Şırnak Tekirdağ Tokat Trabzon Tunceli Uşak Van Yalova Yozgat Zonguldak";
            string[] sehirlerDizi = sehirler.Split();
            byte sayac = 1;
            foreach (var sehir in sehirlerDizi)
            {
                Console.WriteLine($"{sayac}. {sehir}");
                sayac++;
            }

        }
        static void MetniDiziyeAktar()
        {
            string str1 = null;
            string str2 = null;
            str1 = "alkan";
            str2 = "k";
            //Str1 içerisinde str2 dizesini arar ve bulunduğu indeksin numarısını size geri döndürür.
            Console.WriteLine(str1.IndexOf(str2));

            string karakter = " ";
            string sehirler = "Adana Adıyaman Afyonkarahisar Ağrı Aksaray Amasya Ankara Antalya Ardahan Artvin Aydın Balıkesir Bartın Batman Bayburt Bilecik Bingöl Bitlis Bolu Burdur Bursa Çanakkale Çankırı Çorum Denizli Diyarbakır Düzce Edirne Elazığ Erzincan Erzurum Eskişehir Gaziantep Giresun Gümüşhane Hakkari Hatay Iğdır Isparta İstanbul İzmir K.Maraş Karabük Karaman Kars Kastamonu Kayseri Kırıkkale Kırklareli Kırşehir Kilis Kocaeli Konya Kütahya Malatya Manisa Mardin Mersin Muğla Muş Nevşehir Niğde Ordu Osmaniye Rize Sakarya Samsun Şanlıurfa Siirt Sinop Sivas Şırnak Tekirdağ Tokat Trabzon Tunceli Uşak Van Yalova Yozgat Zonguldak";
            string[] sehir = new string[81];
            for (int i = 0; i < 81; i++)
            {
                //her bir ili bir diziye aktar
            }
        }
        static void IliskiDurumuMethod()
        {
            string[] sorular = new string[5]
            {
                "Kıskanç mısın? (1: hayır, 2: evet)",
                "Aşk mı para mı? (1: aşk, 2: para)",
                "Köpek mi kedi mi? (1: köpek, 2: kedi)",
                "Marka takıntılı mısın? (1: hayır, 2: evet)",
                "Zeka mı tip mi? (1: zeka, 2: tip)"
            };
            string[] cevaplar = new string[sorular.Length];
            int index = 0;

            foreach (var item in sorular)
            {
                //Console.WriteLine("");
                cevaplar[index] = Console.ReadLine();
                index++;
            }
            int yuzde = 0;
            foreach (var cevap in cevaplar)
            {
                if (cevap == "1")
                {
                    yuzde += 20;
                }
            }
            if (yuzde >= 70)
            {
                Console.WriteLine("ilişki harika");
            }
            else if (yuzde >= 30 && yuzde <= 70)
            {
                Console.WriteLine("Bir şans verilebilir.");
            }
            else
            {
                Console.WriteLine("Kaç kurtar kendini.");
            }
        }
        #endregion

        #region Odev1
        /*Kullanıcıdan alınan 2 adet sayının 
            
            1-toplamları
            2-farkları
            3-çarpımları
            4-1.sayının 2.sayıya bölümü
            5-1. sayının 2.sayıya bölümünden kalanı sırasıyla gösteriniz*/
        static void odev1()
        {
            Console.WriteLine("İki sayı giriniz:");
            double sayi1 = double.Parse(Console.ReadLine());
            double sayi2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Toplam: " + Toplama(sayi1, sayi2));
            Console.WriteLine("Fark: " + Fark(sayi1, sayi2));
            Console.WriteLine("Çarpım: " + Carpma(sayi1, sayi2));

            if (sayi2 != 0)
            {
                Console.WriteLine("Bölüm: " + Bolme(sayi1, sayi2));
                Console.WriteLine("Kalan: " + Kalan(sayi1, sayi2));
            }
            else
            {
                Console.WriteLine("Bölme işlemi yapılamaz. İkinci sayı 0 olamaz.");
            }
        }
        static double Toplama(double sayi1, double sayi2)
        {
            return sayi1 + sayi2;
        }

        static double Fark(double sayi1, double sayi2)
        {
            return sayi1 - sayi2;
        }

        static double Carpma(double sayi1, double sayi2)
        {
            return sayi1 * sayi2;
        }

        static double Bolme(double sayi1, double sayi2)
        {
            return sayi1 / sayi2;
        }

        static double Kalan(double sayi1, double sayi2)
        {
            return sayi1 % sayi2;
        }

        #endregion

        #region odev2
        /*Kullanıcıdan alınan aylık aldığı maaşın %10'u 1200 ve üstünde ise vergiye 1000 lira verilerek maaşından düşürülecek ve yeni maaşı kullanıcıya gösterilecek, maaşının  %10'u 1200 altında ise vergi ödemiyecek ve maaşı ekranda gösterilecek yapıyı kodlayınız?*/
        static void odev2()
        {
            Console.WriteLine("Aylık maaşınızı giriniz:");
            double maas = double.Parse(Console.ReadLine());

            double vergi = maas * 0.10; // Maaşın %10'u hesaplanıyor.

            if (vergi >= 1200)
            {
                maas -= 1000; // Vergi 1200 ve üstündeyse 1000 lira kesiliyor.
            }

            Console.WriteLine("Yeni maaşınız: " + maas);
        }
        #endregion

        #region odev3
        /*
         //Bir üniversitede öğrencileri not hesaplaması alacağı 2 vize ve bir final notuna göre hesaplama yapılmaktadır. 1. vizenin %20'si, 2. vizenin %30 ve finalin %50 si alınarak toplanan bu değerler 
         /* Not > 0 - Not < 45 arasında ise kaldı
          Not >= 45 - Not < 55 ise GEÇTİ
          Not >= 55 - Not < 70 ise ORTA

          Not >= 70 - Not <= 85 ise İYİ

          Not >= 85 - Not < 100 ise ÇOK İYİ

          Not == 100 ise TAM NOT ALDINIZ
          ve her mesajda öğrencinin ortalaması da gösterilerek kullanıcıyı bilgilendiren bir karar yapısı kodlayınız?

          NOT=> Girilen not değerleri negatif ya da 100 den büyük olamaz,istenilen değer girilmezse kullanıcı bilgilendirilmelidir
          */
        static void Odev3()
        {
            Console.WriteLine("1. vize notunu giriniz:");
            double vize1 = double.Parse(Console.ReadLine());

            Console.WriteLine("2. vize notunu giriniz:");
            double vize2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Final notunu giriniz:");
            double final = double.Parse(Console.ReadLine());

            // Girilen not değerleri kontrol ediliyor
            if (vize1 < 0 || vize1 > 100 || vize2 < 0 || vize2 > 100 || final < 0 || final > 100)
            {
                Console.WriteLine("Hatalı not girişi! Not değerleri 0-100 arasında olmalıdır.");
                return;
            }

            double vize1Oran = 0.20;
            double vize2Oran = 0.30;
            double finalOran = 0.50;

            // Notların ortalaması hesaplanıyor
            double ortalama = (vize1 * vize1Oran) + (vize2 * vize2Oran) + (final * finalOran);

            // Durumlar belirleniyor ve ekrana yazdırılıyor
            if (ortalama >= 0 && ortalama < 45)
            {
                Console.WriteLine("Ortalamanız: " + ortalama);
                Console.WriteLine("Dersten kaldınız.");
            }
            else if (ortalama >= 45 && ortalama < 55)
            {
                Console.WriteLine("Ortalamanız: " + ortalama);
                Console.WriteLine("Dersten geçtiniz (Geçer)");
            }
            else if (ortalama >= 55 && ortalama < 70)
            {
                Console.WriteLine("Ortalamanız: " + ortalama);
                Console.WriteLine("Orta");
            }
            else if (ortalama >= 70 && ortalama <= 85)
            {
                Console.WriteLine("Ortalamanız: " + ortalama);
                Console.WriteLine("İyi");
            }
            else if (ortalama > 85 && ortalama < 100)
            {
                Console.WriteLine("Ortalamanız: " + ortalama);
                Console.WriteLine("Çok İyi");
            }
            else if (ortalama == 100)
            {
                Console.WriteLine("Ortalamanız: " + ortalama);
                Console.WriteLine("Tebrikler, Tam not aldınız!");
            }
        }
        #endregion

        #region odev4
        /*Bir ülkede doğalgaz tüketimi yükseldikçe ödemeler üzerinde fiyatlandırmalar aşağıdaki gibi değişmektedir. 
         Eğer tüketici
        0-100 arasında bir harcama yapmışsa metre küpü için 0.89 kr(Kuruş) kadar faturalandırma yapılmaktadır
        100-500 ise ilk 100 için 9 tl , 100 üstündeki her metre küpü içinde 0.91 kr ile faturalandırılıt
        500-800 ise ilk 500 için 54 tl, 500 üstündeki her metre küp için 0.90 kr
        800-1200 ise ilk 800 için 110.2 tl, 800 üstündeki metre küpü için 0.85 kr fatura
        1200 üstündeki değerler için ilk 1200 için 155.75 tl ve 1200 üstündeki değerler için metre küpü 0.80 kr üzerinde faturalandırılacaktır.
        Kullanıcını girdiği değere göre ne kadar fatura vereceğini hesaplayınız*/
        static void Odev()
        {
            Console.WriteLine("Doğalgaz tüketiminizi metre küp cinsinden giriniz:");
            double tuketim = double.Parse(Console.ReadLine());

            double fatura = 0.0;

            if (tuketim >= 0 && tuketim <= 100)
            {
                fatura = tuketim * 0.89;
            }
            else if (tuketim > 100 && tuketim <= 500)
            {
                fatura = 100 * 0.89 + (tuketim - 100) * 0.91;
            }
            else if (tuketim > 500 && tuketim <= 800)
            {
                fatura = 100 * 0.89 + 400 * 0.91 + (tuketim - 500) * 0.90;
            }
            else if (tuketim > 800 && tuketim <= 1200)
            {
                fatura = 100 * 0.89 + 400 * 0.91 + 300 * 0.90 + (tuketim - 800) * 0.85;
            }
            else if (tuketim > 1200)
            {
                fatura = 100 * 0.89 + 400 * 0.91 + 300 * 0.90 + 400 * 0.85 + (tuketim - 1200) * 0.80;
            }
            else
            {
                Console.WriteLine("Hatalı tüketim değeri girdiniz!");
                return;
            }

            Console.WriteLine("Ödemeniz gereken fatura tutarı: " + fatura + " TL");
        }
        #endregion

        #region odev4.1
        /*Bir ülkede doğalgaz tüketimi yükseldikçe ödemeler üzerinde fiyatlandırmalar aşağıdaki gibi değişmektedir. 
         Eğer tüketici
        0-100 arasında bir harcama yapmışsa metre küpü için 0.89 kr(Kuruş) kadar faturalandırma yapılmaktadır
        100-500 ise ilk 100 için 9 tl , 100 üstündeki her metre küpü içinde 0.91 kr ile faturalandırılıt
        500-800 ise ilk 500 için 54 tl, 500 üstündeki her metre küp için 0.90 kr
        800-1200 ise ilk 800 için 110.2 tl, 800 üstündeki metre küpü için 0.85 kr fatura
        1200 üstündeki değerler için ilk 1200 için 155.75 tl ve 1200 üstündeki değerler için metre küpü 0.80 kr üzerinde faturalandırılacaktır.
        Kullanıcını girdiği değere göre ne kadar fatura vereceğini hesaplayınız*/
        static void Odev4_1()
        {
            Console.WriteLine("Doğalgaz tüketiminizi metre küp cinsinden giriniz:");
            double tuketim = double.Parse(Console.ReadLine());

            double fatura = 0.0;

            if (tuketim >= 0 && tuketim <= 100)
            {
                fatura = Fiyatlandirma1(tuketim);
            }
            else if (tuketim > 100 && tuketim <= 500)
            {
                fatura = Fiyatlandirma2(tuketim);
            }
            else if (tuketim > 500 && tuketim <= 800)
            {
                fatura = Fiyatlandirma3(tuketim);
            }
            else if (tuketim > 800 && tuketim <= 1200)
            {
                fatura = Fiyatlandirma4(tuketim);
            }
            else if (tuketim > 1200)
            {
                fatura = Fiyatlandirma5(tuketim);
            }
            else
            {
                Console.WriteLine("Hatalı tüketim değeri girdiniz!");
                return;
            }

            Console.WriteLine("Ödemeniz gereken fatura tutarı: " + fatura + " TL");
        }
        static double Fiyatlandirma1(double tuketim)
        {
            return tuketim * 0.89;
        }

        static double Fiyatlandirma2(double tuketim)
        {
            return 100 * 0.89 + (tuketim - 100) * 0.91;
        }

        static double Fiyatlandirma3(double tuketim)
        {
            return 100 * 0.89 + 400 * 0.91 + (tuketim - 500) * 0.90;
        }

        static double Fiyatlandirma4(double tuketim)
        {
            return 100 * 0.89 + 400 * 0.91 + 300 * 0.90 + (tuketim - 800) * 0.85;
        }

        static double Fiyatlandirma5(double tuketim)
        {
            return 100 * 0.89 + 400 * 0.91 + 300 * 0.90 + 400 * 0.85 + (tuketim - 1200) * 0.80;
        }

        #endregion

        static void metot1()
        {
            int? i = null;
            int soru = 23;
            void metot2()
            {
                Console.WriteLine("metot içinde metot tanımladık...");
                soru = 123;
            }
        }
    }
}
