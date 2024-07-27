using System.ComponentModel.DataAnnotations;

namespace ders3;

class Program
{
    static void Main(string[] args)
    {
      
       Console.WriteLine("Merhaba");
       string odemeYontemi=Console.ReadLine();
       
       switch(odemeYontemi)
       {
        case "kredi"
        Console.WriteLine("kredi kartı hesabı seçildi");
        break;
        case "nakit"
         Console.WriteLine("nakit kartı hesabı seçildi");
        break;
        case "veresiye"
         Console.WriteLine("veresiye hesabı seçildi");
        break;
        default:
         Console.WriteLine("geçersiz");
        break;
       }
      /* Console.ReadKey(); */
    }
}
