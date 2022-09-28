using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Lütfen 20 adet pozitif sayı giriniz");
        ArrayList asalSayilar = new ArrayList();
        ArrayList asalOlmayanSayilar = new ArrayList();
        int adet=0;
        int girisDeger=0;

        while (adet<20)
        {
            try
            {
                int sayac=0;
                girisDeger = int.Parse(Console.ReadLine());
                if (girisDeger>0)
                {
                    sayac = 0;
                    for (int i = 2; i < girisDeger; i++)
                        if(girisDeger % i == 0)
                            sayac+=1;

                    if ((sayac == 0 || girisDeger==2) && girisDeger>1 )
                        asalSayilar.Add(girisDeger);
                    else
                        asalOlmayanSayilar.Add(girisDeger);

                    adet+=1;
                }
                else
                    Console.WriteLine("Lütfen pozitif sayı giriniz!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Lütfen pozitif sayı giriniz!");
            }
        }

        asalSayilar.Sort();
        asalOlmayanSayilar.Sort();

        int asalToplam=0,asalOlmayanToplam=0;

        Console.WriteLine("Asal sayılar:");
        foreach (var item in asalSayilar)
        {
            Console.WriteLine(item);
            asalToplam+=Convert.ToInt32(item);
        }
            
        Console.WriteLine("Asal olmayan sayılar:");    
        foreach (var item in asalOlmayanSayilar)
        {
            Console.WriteLine(item);
            asalOlmayanToplam+=Convert.ToInt32(item);
        }
            
        
        Console.WriteLine("Asal sayilar sayisi: " + asalSayilar.Count);
        Console.WriteLine("Asal olmayan sayilar sayisi: " + asalOlmayanSayilar.Count);

        Console.WriteLine("Asal sayilar ortalamasi: " + asalToplam/asalSayilar.Count);
        Console.WriteLine("Asal olmayan sayilar ortalamasi: " + asalOlmayanToplam/asalOlmayanSayilar.Count);



    }
}