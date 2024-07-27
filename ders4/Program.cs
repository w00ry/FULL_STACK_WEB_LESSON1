using System.Linq.Expressions;

namespace ders4;

class Program
{
    private static bool i;

    static void Main(string[] args)
    {
      /*   for (int i = 100; i>=0; i =i-2)
        {
        Console.WriteLine(i);
        } */
        Console.Write("Başlangıç sayısını giriniz");
        int baslagıc=Convert.ToInt16(Console.ReadLine());
         Console.Write("Bitiş sayısını giriniz");
        int bitis=Convert.ToInt16(Console.ReadLine());
        Console.Write("Artış değerini girin");
        int artıs=Convert.ToInt16(Console.ReadLine());
        for(int i = baslagıc; i <= bitis; i = i + artıs)
            {
                Console.WriteLine(i);
            }
    }
}
