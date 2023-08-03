using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays_Poject_1
{
    class FirmaCalisanIndirimi
    {/*Bir firmada çalışanlar yakıt fiyatlarında petron ofislerinden yakıt alırken firma çalışanlarına bazı koşullara göre indirim uygulamaktadır
            1-cinsiyet Kadın ise 
             =>çalışma yıl sayısı 0-5 arasında ise %5 indirim
             =>çalışma yıl sayısı 6-10 arasında ise %7 indirim
             =>çalışma yıl sayısı 11-15 arasında ise %12 indirim
             =>çalışma yıl sayısı 16-20 arasında ise %17 indirim
             =>çalışma yıl sayısı 21 ve üstü ise 250 tl indirim, %9 gibi bir indirim yapılacaktır

            2-cinsiyet Kadın ise çocuk varsa
             =>çalışma yıl sayısı 0-5 arasında ise %4 indirim
             =>çalışma yıl sayısı 6-10 arasında ise %9 indirim
             =>çalışma yıl sayısı 11-15 arasında ise %14 indirim
             =>çalışma yıl sayısı 16-20 arasında ise %19 indirim
             =>çalışma yıl sayısı 21 ve üstü ise 350 tl indirim, %9 gibi bir indirim yapılacaktır            

            3-cinsiyet Erkek 
             =>çalışma yıl sayısı 0-5 arasında ise %3 indirim
             =>çalışma yıl sayısı 6-10 arasında ise %8 indirim
             =>çalışma yıl sayısı 11-15 arasında ise %12 indirim
             =>çalışma yıl sayısı 16-20 arasında ise %17 indirim
             =>çalışma yıl sayısı 21 ve üstü ise 225 tl indirim, %8.5 gibi bir indirim yapılacaktır

             4-cinsiyet Erkek ve çocuk varsa 
             =>çalışma yıl sayısı 0-5 arasında ise %3,5 indirim
             =>çalışma yıl sayısı 6-10 arasında ise %8 indirim
             =>çalışma yıl sayısı 11-15 arasında ise %13 indirim
             =>çalışma yıl sayısı 16-20 arasında ise %18 indirim
             =>çalışma yıl sayısı 21 ve üstü ise 324.75 tl indirim, %8.5 gibi bir indirim yapılacaktır  
            ***son madde hem tl hem de %indirim ana para üzerinden yapılacaktır
            ***900 tl yapıldı
            *yeni fiyat hesaplaması=900-(324.75+900*8.5/100)

            yukardaki koşullat 700 tl ve üstü yakıt alırken geçerlidir*/

        public static void AnaMetot()
        {
            Console.WriteLine("Çalışanın cinsiyetini giriniz (Kadın veya Erkek):");
            string cinsiyet = Console.ReadLine();

            Console.WriteLine("Çalışma yıl sayısını giriniz:");
            int calismaYili = int.Parse(Console.ReadLine());

            Console.WriteLine("Çocuk sayısını giriniz:");
            int cocukSayisi = int.Parse(Console.ReadLine());

            double anaPara = 900; // Ana para, 900 TL olarak varsayalım

            double yeniFiyat = HesaplaIndirimliFiyat(cinsiyet, calismaYili, cocukSayisi, anaPara);

            Console.WriteLine("Yeni fiyat hesaplaması: " + yeniFiyat + " TL");
        }
        static double HesaplaIndirimliFiyat(string cinsiyet, int calismaYili, int cocukSayisi, double anaPara)
        {
            double indirim = 0.0;

            if (cinsiyet.ToLower() == "kadın")
            {
                if (cocukSayisi > 0)
                {
                    indirim = HesaplaKadinIndirim(calismaYili, cocukSayisi);
                }
                else
                {
                    indirim = HesaplaKadinIndirim(calismaYili);
                }
            }
            else if (cinsiyet.ToLower() == "erkek")
            {
                if (cocukSayisi > 0)
                {
                    indirim = HesaplaErkekIndirim(calismaYili, cocukSayisi);
                }
                else
                {
                    indirim = HesaplaErkekIndirim(calismaYili);
                }
            }

            double yeniFiyat = anaPara - indirim - (anaPara * 8.5 / 100);
            return yeniFiyat;
        }

        static double HesaplaKadinIndirim(int calismaYili, int cocukSayisi = 0)
        {
            double indirim = 0.0;

            if (cocukSayisi > 0)
            {
                if (calismaYili >= 0 && calismaYili <= 5)
                    indirim = 900 * 4 / 100;
                else if (calismaYili >= 6 && calismaYili <= 10)
                    indirim = 900 * 9 / 100;
                else if (calismaYili >= 11 && calismaYili <= 15)
                    indirim = 900 * 14 / 100;
                else if (calismaYili >= 16 && calismaYili <= 20)
                    indirim = 900 * 19 / 100;
                else if (calismaYili >= 21)
                    indirim = 250 + (900 * 9 / 100);
            }
            else
            {
                if (calismaYili >= 0 && calismaYili <= 5)
                    indirim = 900 * 5 / 100;
                else if (calismaYili >= 6 && calismaYili <= 10)
                    indirim = 900 * 7 / 100;
                else if (calismaYili >= 11 && calismaYili <= 15)
                    indirim = 900 * 12 / 100;
                else if (calismaYili >= 16 && calismaYili <= 20)
                    indirim = 900 * 17 / 100;
                else if (calismaYili >= 21)
                    indirim = 250 + (900 * 9 / 100);
            }

            return indirim;
        }

        static double HesaplaErkekIndirim(int calismaYili, int cocukSayisi = 0)
        {
            double indirim = 0.0;

            if (cocukSayisi > 0)
            {
                if (calismaYili >= 0 && calismaYili <= 5)
                    indirim = 900 * 3.5 / 100;
                else if (calismaYili >= 6 && calismaYili <= 10)
                    indirim = 900 * 8 / 100;
                else if (calismaYili >= 11 && calismaYili <= 15)
                    indirim = 900 * 13 / 100;
                else if (calismaYili >= 16 && calismaYili <= 20)
                    indirim = 900 * 18 / 100;
                else if (calismaYili >= 21)
                    indirim = 225 + (900 * 8.5 / 100);
            }
            else
            {
                if (calismaYili >= 0 && calismaYili <= 5)
                    indirim = 900 * 3 / 100;
                else if (calismaYili >= 6 && calismaYili <= 10)
                    indirim = 900 * 8 / 100;
                else if (calismaYili >= 11 && calismaYili <= 15)
                    indirim = 900 * 12 / 100;
                else if (calismaYili >= 16 && calismaYili <= 20)
                    indirim = 900 * 17 / 100;
                else if (calismaYili >= 21)
                    indirim = 225 + (900 * 8.5 / 100);
            }

            return indirim;
        }
    }
    /// <summary>
    /// firma çalışan indirimi 2 
    /// </summary>
    class FirmaCalisanIndirimi2
    {
        static void Main2()
        {
            Console.WriteLine("Çalışanın cinsiyetini giriniz (Kadın veya Erkek):");
            string cinsiyet = Console.ReadLine();

            Console.WriteLine("Çalışma yıl sayısını giriniz:");
            int calismaYili = int.Parse(Console.ReadLine());

            Console.WriteLine("Çocuk sayısını giriniz:");
            int cocukSayisi = int.Parse(Console.ReadLine());

            double anaPara = 900; // Ana para, 900 TL olarak varsayalım

            double indirim = 0.0;

            if (cinsiyet.ToLower() == "kadın")//veya ToUpper ilede büyüte bilirdim
            {
                if (cocukSayisi > 0)
                {
                    if (calismaYili >= 0 && calismaYili <= 5)
                        indirim = 900 * 4 / 100;
                    else if (calismaYili >= 6 && calismaYili <= 10)
                        indirim = 900 * 9 / 100;
                    else if (calismaYili >= 11 && calismaYili <= 15)
                        indirim = 900 * 14 / 100;
                    else if (calismaYili >= 16 && calismaYili <= 20)
                        indirim = 900 * 19 / 100;
                    else if (calismaYili >= 21)
                        indirim = 250 + (900 * 9 / 100);
                }
                else
                {
                    if (calismaYili >= 0 && calismaYili <= 5)
                        indirim = 900 * 5 / 100;
                    else if (calismaYili >= 6 && calismaYili <= 10)
                        indirim = 900 * 7 / 100;
                    else if (calismaYili >= 11 && calismaYili <= 15)
                        indirim = 900 * 12 / 100;
                    else if (calismaYili >= 16 && calismaYili <= 20)
                        indirim = 900 * 17 / 100;
                    else if (calismaYili >= 21)
                        indirim = 250 + (900 * 9 / 100);
                }
            }
            else if (cinsiyet.ToLower() == "erkek")
            {
                if (cocukSayisi > 0)
                {
                    if (calismaYili >= 0 && calismaYili <= 5)
                        indirim = 900 * 3.5 / 100;
                    else if (calismaYili >= 6 && calismaYili <= 10)
                        indirim = 900 * 8 / 100;
                    else if (calismaYili >= 11 && calismaYili <= 15)
                        indirim = 900 * 13 / 100;
                    else if (calismaYili >= 16 && calismaYili <= 20)
                        indirim = 900 * 18 / 100;
                    else if (calismaYili >= 21)
                        indirim = 225 + (900 * 8.5 / 100);
                }
                else
                {
                    if (calismaYili >= 0 && calismaYili <= 5)
                        indirim = 900 * 3 / 100;
                    else if (calismaYili >= 6 && calismaYili <= 10)
                        indirim = 900 * 8 / 100;
                    else if (calismaYili >= 11 && calismaYili <= 15)
                        indirim = 900 * 12 / 100;
                    else if (calismaYili >= 16 && calismaYili <= 20)
                        indirim = 900 * 17 / 100;
                    else if (calismaYili >= 21)
                        indirim = 225 + (900 * 8.5 / 100);
                }
            }

            double yeniFiyat = anaPara - (indirim + anaPara * 0.085);

            Console.WriteLine("Yeni fiyat hesaplaması: " + yeniFiyat + " TL");
        }
    }


}
