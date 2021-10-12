using System;

namespace _5average
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum=0;
            decimal average=0;
            Console.WriteLine("Lütfen 5 adet sayı giriniz");
           
            for (int i = 1; i < 6; i++ ) {
                Console.WriteLine("{0}. sayıyı giriniz", i);
                int input = Int32.Parse(Console.ReadLine());
                sum += input;
                }
            average = Convert.ToDecimal(sum) / 5;
            Console.WriteLine("Girdiğiniz sayıların ortalaması {0}.",average);
            Console.WriteLine("Çıkmak için bir tuşa basın");
            Console.ReadKey();
            
        }
    }
}
