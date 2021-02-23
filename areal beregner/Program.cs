
using System;

namespace areal_beregner
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {

                Console.WriteLine("AREALBEREGNINGER");
                Console.WriteLine("----------------");
                Console.WriteLine();

                Console.WriteLine("Vælg en figur (firkant, trekant, cirkel)");
                Console.WriteLine();
                string op = Console.ReadLine();
                string i;

                if (op == "firkant" || op == "trekant" || op == "cirkel")
                {

                    if (op == "cirkel")
                    {
                        Console.Write("Skriv radius ");
                        i = Console.ReadLine();
                        double r = Convert.ToDouble(i);
                        double res = r * 2 * Math.PI;
                        Console.WriteLine($"Resultatet er {res:N2}");

                    }
                    else
                    {

                        Console.WriteLine("Skriv den ene sidelængde: ");
                        i = Console.ReadLine();
                        double num1 = Convert.ToDouble(i);

                        Console.WriteLine("Skriv den anden sidelængde: ");
                        i = Console.ReadLine();
                        double num2 = Convert.ToDouble(i);

                        if (op == "trekant")
                        {
                            double res = num1 * num2 / 2;
                            Console.WriteLine($"Arealet er {res:N2}");
                        
                        }

                        else if (op == "firkant")
                        {
                            double res = num1 * num2;
                            Console.WriteLine($"Arealet er {res:N2}");
                         
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Ugyldig figur!");
                }


            }
            catch (Exception )
            {
                Console.WriteLine("Der er desværre sket en fejl!");

            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Tryk en tást for at afslutte");
            Console.ReadKey();
        }
    }
}
