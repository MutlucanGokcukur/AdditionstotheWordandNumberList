using System;
using System.Collections;

namespace AdditionstotheWordandNumberList
{
    class Program
    {
        static void Main(string[] args)
        {
        basadön:
            ArrayList Kelime_Listesi = new ArrayList();
            ArrayList Sayı_Listesi = new ArrayList();
            Console.Write("Dizinin Boyutunu Giriniz: ");
            int diziboyut = Convert.ToInt32(Console.ReadLine());


        bb:
            Console.Write("Sayı Dizisi mi?\nKelime Dizisi mi?\nSayı Dizisi için '1' \tKelime Dizisi için '2' Giriniz: ");
            int secim = Convert.ToInt32(Console.ReadLine());

            if (secim != 1 && secim != 2)
            {
                Console.WriteLine("Lütfen Geçerli Bir Dizi Türü Numarası Giriniz");
                goto bb;
            }

        aa:
            Console.Write("Kendiniz Doldurmak İstiyorsanız '1'Rastgele Doldurulması İçin '2' Basınız: ");
            int dolum = Convert.ToInt32(Console.ReadLine());

            if (dolum == 1)
            {
                if (secim == 1)
                {
                    for (int i = 0; i < diziboyut; i++)
                    {
                        Console.Write("Değeri Giriniz: ");
                        int deger = Convert.ToInt32(Console.ReadLine());
                        Sayı_Listesi.Add(deger);
                    }

                }
                if (secim == 2)
                {
                    for (int i = 0; i < diziboyut; i++)
                    {
                        Console.Write("Eklenecek Kelimeyi Giriniz: ");
                        string kelime = Console.ReadLine();
                        Kelime_Listesi.Add(kelime);
                    }
                }
            }
            else if (secim == 1 && dolum == 2)
            {
                Console.Write("Sayıları Hangi Değer Aralığından Seçelim?");
                int aralık_boyut = Convert.ToInt32(Console.ReadLine());
                int random = 0;
                Random rnd = new Random();
                for (int i = 0; i < diziboyut; i++)
                {
                    random = rnd.Next(aralık_boyut);
                    Sayı_Listesi.Add(random);
                }
                System.Threading.Thread.Sleep(2000);
                Console.Write("0'dan Girilen Aralığa Kadar " + diziboyut + " Tane Sayı Eklendi");
            }
            else if (secim == 2 && dolum == 2)
            {
                Console.WriteLine("Maalesef Kelime Dizisini Rastgele Olarak Atama Özelliği Henüz Eklenmedi");
                goto dd;
            }
            else
            {
                Console.WriteLine("Geçersiz İşlem Numarası Girildi\nTekrar Giriniz");
                goto aa;
            }
            Console.Write("\nGirilen Değerleri Görmek İster Misiniz?(E/H):");
            string gorme_secim = Console.ReadLine();
            gorme_secim.ToUpper();
            if (secim == 1)
            {
                foreach (var item in Sayı_Listesi)
                {
                    Console.WriteLine(item);
                }
            }
            else if (secim == 2)
            {
                foreach (var item in Kelime_Listesi)
                {
                    Console.WriteLine(item);
                }
            }
        dd:
            Console.WriteLine("Programı Bir Kez Daha Kullanmak İster Misiniz?(E/H)");
            string tekrar_kullanma = Console.ReadLine();
            tekrar_kullanma.ToUpper();
            if (tekrar_kullanma == "e")
            {
                Console.Clear();
                goto basadön;
            }
            else if (tekrar_kullanma == "h")
            {
                Console.Write("Program Sonlandırılıyor....");
                System.Threading.Thread.Sleep(2000);
            }
            else
            {
                Console.WriteLine("Geçersiz İşlem Girildi");
                goto dd;
            }
        }
    }
}
