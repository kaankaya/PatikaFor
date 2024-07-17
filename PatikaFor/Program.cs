using System;

namespace patika
{
    class Program 
    {
        static void Main(string[] args) 
        {
            //Konsol Ekranına 10 kere metni yazdırmak
            for (int i = 1; i <= 10; i++)
            {
               Console.WriteLine("Kendime inanıyorum,ben bu yazılım işini hallederim");
              
            }//End For

            //1 ile 20 arasındaki yazılar
            for (int i = 1; i < 20; i++)
            {
               Console.WriteLine(i);
            }//End For

            //1 ile 20 arasındaki çift sayılar
            for(int i = 0; i <= 20; i += 2) 
            {
                Console.WriteLine(i);
            }

            //50 ile 150 arasındaki sayıların toplamı
            int toplam = 0;

            for(int i = 50; i < 150; i++) 
            {
                toplam += i;
            }
            Console.WriteLine($"50 ile 150 arasındaki toplam sayı: {toplam}");

            // 1 - 120 arasındaki sayıların tek lerin ve çiftlerin ayrı toplamı
            //tek ve çift toplamını tutmak için değişken tanımladık içeride if ile sayının çift mi değil mi kontrol yapıldı ve veri saklandı
            int tek = 0;
            int cift = 0;

            for(int i = 1;i <= 120; i++)
            {
                if(i % 2 == 0) {
                    cift += i;
                }
                else
                {
                    tek += i;
                }//End İf
            }//End For
            //tek ve çift sayılar toplamı ekrana gönderme
            Console.WriteLine($"Çift sayıların toplamı: {cift}");
            Console.WriteLine($"Tek sayıların toplamı: {tek}");
        }
    }
}