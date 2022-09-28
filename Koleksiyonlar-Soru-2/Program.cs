using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        int adet = 0;
        int kucukToplam = 0;
        int buyukToplam = 0;
        ArrayList sayilar = new ArrayList();
        Console.WriteLine("Lütfen 20 adet sayi giriniz");

        while (adet<20)
        {
            try
            {
                sayilar.Add(int.Parse(Console.ReadLine()));
                adet+=1;
            }
            catch (Exception e)
            {
                Console.WriteLine("Lütfen sayi giriniz!");
            }
        }

        sayilar.Sort();
        for (int i = 0; i < 3; i++)
        {
            kucukToplam+= Convert.ToInt32(sayilar[i]);
            buyukToplam+= Convert.ToInt32(sayilar[19-i]);
        }

        Console.WriteLine("Küçük sayıların ortalaması: " + kucukToplam/3);
        Console.WriteLine("Büyük sayıların ortalaması: " + buyukToplam/3);
        Console.WriteLine("Ortalamalar toplamı: " + (kucukToplam/3 + buyukToplam/3));
    }
}