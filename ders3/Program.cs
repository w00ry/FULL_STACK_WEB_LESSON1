namespace ders3;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("değer giriniz");
        string odeme=Console.ReadLine();

        switch (odeme)
        {
            case "kredi":
            Console.WriteLine("Kredi seçildi");
            break;
            case "nakit":
            Console.WriteLine("Nakit seçildi");
            break;
            case "borç":
            Console.WriteLine("Borç seçildi");
            break;
            default: 
            Console.WriteLine("geçerli bir değer girilmelidir örneğin:kredi,nakit,borç");
            break;
        }
        
    }
}