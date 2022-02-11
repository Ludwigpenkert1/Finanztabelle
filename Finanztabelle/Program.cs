using System;

namespace Finanztabelle
{
    class Program
    {
        static void Main(string[] args)
        {


            double Kapital = 0;
            int Anlagedauer = 0;
            double Zinssatz = 0;

            Console.WriteLine("Geben sie ihr Kapital an");
            Kapital = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Geben sie ihre Anlagedauer an");
            Anlagedauer = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Geben sie ihren Jährlichen Zinssatz an");
            Zinssatz = Convert.ToDouble(Console.ReadLine());
            
            String J = "Jahr", G = "Guthaben", Z = "Zinsen", KZ = "K.Zinsen", B = "Billanz";
            Console.WriteLine("{0,4}| {1,12}| {2,20}| {3,30}| {4,37}|", J, G, Z, KZ, B);

            for (int i = 1; i<=43; i++  ) ;
            
            {
                Console.Write("----------------------------------------------------------------------------------------------------------------");
            }

            Console.WriteLine();

            double KZinsen = 0;
            double Bilanz = 0;
            double kn = 0;
            double Zinsen = 0;

            for (int i = 1; i <= Anlagedauer; i++)
            {
                Zinsen = kn * (Zinssatz/ 100);
                KZinsen = KZinsen + Zinsen;
                Bilanz = Kapital + KZinsen;

                Console.WriteLine($"{i,4}| {kn,12:F2}| {Zinsen,20:F2}| {KZinsen,30:F2}| {Bilanz,37:F2}|");

                kn = Bilanz;

            }
            
            for (int i = 1; i <= 43; i++) ;

            {
                Console.Write("----------------------------------------------------------------------------------------------------------------");
            }

        }   


    }
}
