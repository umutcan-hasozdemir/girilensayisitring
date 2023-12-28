using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> birlerBasamagi = new List<string> { " ", "bir", "iki", "üç", "dört", "beş", "altı", "yedi", "sekiz", "dokuz" };
        List<string> onlarBasamagi = new List<string> { " ", "on", "yirmi", "otuz", "kırk", "elli", "altmış", "yetmiş", "seksen", "doksan" };
        List<string> yuzlerBasamagi = new List<string> { " ", "yüz", "ikiyüz", "üçyüz", "dörtyüz", "beşyüz", "altıyüz", "yediyüz", "sekizyüz", "dokuzyüz" };

        for (int i = 0; i <= 2; i++)
        {
            Console.WriteLine("Bir sayı giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());

            bool Negatif = false;
            if (sayi < 0)
            {
                Negatif = true;
                sayi = Math.Abs(sayi);
            }

            int yuzler = sayi / 100;
            int onlar = (sayi / 10) % 10;
            int birler = sayi % 10;

            if (Negatif)
            {
                Console.WriteLine("eksi " + yuzlerBasamagi[yuzler] + " " + onlarBasamagi[onlar] + " " + birlerBasamagi[birler]);
            }
            else
            {
                Console.WriteLine(yuzlerBasamagi[yuzler] + " " + onlarBasamagi[onlar] + " " + birlerBasamagi[birler]);
            }
        }
    }
}
