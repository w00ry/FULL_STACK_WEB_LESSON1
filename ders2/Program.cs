namespace ders2;

class Program
{

    static void Main(string[] args)
    {
   /*     byte skor1,skor2;
       skor1=4;
       skor2=10;
       if(skor1>skor2){

       Console.WriteLine("skor 1 skor 2 den büyüktür");
       }
       
       else if(skor1<skor2){
        Console.WriteLine("skor 2 1 den büyüktür");
       }
        */
        
         Console.Write("Öğrencinin ortalamasını giriniz:");
        int ortalama=Convert.ToInt16(Console.ReadLine());

        if(ortalama<50){
            Console.WriteLine("Sınıfta kaldı");
        }

        else if(ortalama<70){
            Console.WriteLine("Geçti ama belge alamadı");
        }

        else if(ortalama<85){
            Console.WriteLine("Teşekkür belgesi aldı");
        }
        else if(ortalama<=100){
            Console.WriteLine("Takdir belgesi aldı");
        }

        else{
            Console.WriteLine("0--100 aralığında bir sayı giriniz");
        }

}
}

