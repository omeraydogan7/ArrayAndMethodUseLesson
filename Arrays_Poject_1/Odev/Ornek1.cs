using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays_Poject_1.Odev
{
    class Ornek1
    {
        #region Plaka ile ili eşleyen kodlar
        public static void PlakaEsle()
        {
            int[] plakaKodlari = { 1, 2, 3, /* ... */ 80, 81 };
            string[] iller = { "Adana", "Adıyaman", "Afyonkarahisar", /* ... */ "Van", "Yozgat", "Zonguldak" };

            Console.WriteLine("Bir plaka kodu giriniz:");
            int plakaKodu = int.Parse(Console.ReadLine());

            string ilBilgisi = IlBilgisiniGetir(plakaKodlari, iller, plakaKodu);

            if (ilBilgisi != null)
            {
                Console.WriteLine("Plaka: " + plakaKodu + " => İl: " + ilBilgisi);
            }
            else
            {
                Console.WriteLine("Geçerli bir plaka kodu giriniz.");
            }
        }
        public static string IlBilgisiniGetir(int[] plakaKodlari, string[] iller, int plakaKodu)
        {
            for (int i = 0; i < plakaKodlari.Length; i++)
            {
                if (plakaKodlari[i] == plakaKodu)
                {
                    return iller[i];
                }
            }
            return null;
        }
        #endregion

        #region Plaka Bilgi 2
        static void PlakaBilgi()
        {
            Console.WriteLine("Plaka kodunu giriniz:");
            int plakaKodu = int.Parse(Console.ReadLine());

            string sehir = PlakaKodunaGoreSehirBul(plakaKodu);

            if (sehir != null)
            {
                Console.WriteLine("Plaka: " + plakaKodu + " => Şehir: " + sehir);
            }
            else
            {
                Console.WriteLine("Geçerli bir plaka kodu giriniz.");
            }
        }
        static string PlakaKodunaGoreSehirBul(int plakaKodu)
        {
            string sehir;

            switch (plakaKodu)
            {
                case 34:
                    sehir = "İSTANBUL";
                    break;
                case 65:
                    sehir = "VAN";
                    break;
                case 44:
                    sehir = "MALATYA";
                    break;
                case 49:
                    sehir = "MUŞ";
                    break;
                case 35:
                    sehir = "İZMİR";
                    break;
                case 01:
                    sehir = "ADANA";
                    break;
                case 02:
                    sehir = "ANKARA";
                    break;
                case 30:
                    sehir = "HAKKARİ";
                    break;
                default:
                    sehir = null;
                    break;
            }

            return sehir;
        }
        #endregion

        #region Plaka Eşleme
        public static void PlakaEsleMethod()
        {
            byte[] plakaKodlari = {
            1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
            11, 12, 13, 14, 15, 16, 17, 18, 19, 20,
            21, 22, 23, 24, 25, 26, 27, 28, 29, 30,
            31, 32, 33, 34, 35, 36, 37, 38, 39, 40,
            41, 42, 43, 44, 45, 46, 47, 48, 49, 50,
            51, 52, 53, 54, 55, 56, 57, 58, 59, 60,
            61, 62, 63, 64, 65, 66, 67, 68, 69, 70,
            71, 72, 73, 74, 75, 76, 77, 78, 79, 80,
            81
            };
            string[] iller = {
            "ADANA", "ADIYAMAN", "AFYONKARAHİSAR", "AĞRI", "AMASYA", "ANKARA", "ANTALYA", "ARTVİN", "AYDIN", "BALIKESİR",
            "BİLECİK", "BİNGÖL", "BİTLİS", "BOLU", "BURDUR", "BURSA", "ÇANAKKALE", "ÇANKIRI", "ÇORUM", "DENİZLİ",
            "DİYARBAKIR", "EDİRNE", "ELAZIĞ", "ERZİNCAN", "ERZURUM", "ESKİŞEHİR", "GAZİANTEP", "GİRESUN", "GÜMÜŞHANE", "HAKKARİ",
            "HATAY", "ISPARTA", "MERSİN", "İSTANBUL", "İZMİR", "KARS", "KASTAMONU", "KAYSERİ", "KIRKLARELİ", "KIRŞEHİR",
            "KOCAELİ", "KONYA", "KÜTAHYA", "MALATYA", "MANİSA", "KAHRAMANMARAŞ", "MARDİN", "MUĞLA", "MUŞ", "NEVŞEHİR",
            "NİĞDE", "ORDU", "RİZE", "SAKARYA", "SAMSUN", "SİİRT", "SİNOP", "SİVAS", "TEKİRDAĞ", "TOKAT",
            "TRABZON", "TUNCELİ", "ŞANLIURFA", "UŞAK", "VAN", "YOZGAT", "ZONGULDAK", "AKSARAY", "BAYBURT", "KARAMAN",
            "KIRIKKALE", "BATMAN", "ŞIRNAK", "BARTIN", "ARDAHAN", "IĞDIR", "YALOVA", "KARABÜK", "KİLİS", "OSMANİYE",
            "DÜZCE"
            };

            Console.WriteLine("Plaka kodunu giriniz:");
            byte plakaKodu = byte.Parse(Console.ReadLine());

            int index = Array.IndexOf(plakaKodlari, plakaKodu);//plaka bilgisinin değerini plakarda arama yapar bulursa true yerine +1 döner ama yanlış yani bulamazsa false yerine -1 döner
            Console.WriteLine(index);
            if (index != -1)// dönen sonuç -1 değili ise 
            {
                string sehir = iller[index];//
                Console.WriteLine("Plaka: " + plakaKodu + " => Şehir: " + sehir);
            }
            else
            {
                Console.WriteLine("Geçerli bir plaka kodu giriniz.");
            }
        }
        #endregion

        #region Switch Case Kullanarak Mevsim Bul
        public static void AyGir()
        {
            Console.WriteLine("Ay bilgisini giriniz:");
            string ay = Console.ReadLine().ToUpper();//küçük olmasını istersek ToLower() metodu kullanılır.
            MevsimMethod(ay);
        }
        static void MevsimMethod(string ay)
        {
            string bilgi = ay;
            string mevsim;
            switch (ay)
            {
                case "ARALIK":
                case "OCAK":
                case "ŞUBAT":
                    mevsim = "KIŞ";
                    break;
                case "MART":
                case "NİSAN":
                case "MAYIS":
                    mevsim = "İLKBAHAR";
                    break;
                case "HAZİRAN":
                case "TEMMUZ":
                case "AĞUSTOS":
                    mevsim = "YAZ";
                    break;
                case "EYLÜL":
                case "EKİM":
                case "KASIM":
                    mevsim = "SONBAHAR";
                    break;
                default:
                    mevsim = "Geçersiz";
                    break;
            }

            Console.WriteLine("Mevsim: " + mevsim);
        }
        #endregion

    }
    class Mevsim
    {
        public void KisMethod()
        {

        }
    }
}
