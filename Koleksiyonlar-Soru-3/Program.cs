using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        string cumle;
        ArrayList sesliHarfler = new ArrayList();
        string sesli = "aeıioöuü";
        Console.WriteLine("Lutfen bir cümle giriniz");
        cumle = Console.ReadLine().ToLower();

        foreach (char item in cumle)
        {
            if(sesli.Contains(item))
                sesliHarfler.Add(item);
        }

        sesliHarfler.Sort();
        foreach (var item in sesliHarfler)
        {
            Console.WriteLine(item);
        }
    }
}