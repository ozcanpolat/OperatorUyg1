using System;

namespace OpeatorUygulama1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan aldığınız 2 sayının çarpımı ile x, y, z toplamının farkı nedir ?

            int x = 2, y = 5, z = 1;

            Console.Write("İlk sayıyı girin: ");
            int sayi1 = int.Parse(Console.ReadLine());

            Console.Write("İkinci sayıyı girin: ");
            int sayi2 = int.Parse(Console.ReadLine());

            int sonuc = (sayi1 * sayi2) - (x + y + z);

            Console.WriteLine("Sonuç :" + sonuc);



        }
    }
}
