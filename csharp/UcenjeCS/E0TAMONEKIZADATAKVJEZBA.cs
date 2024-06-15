using System;

namespace UcenjeCS
{
    internal class E0TAMONEKIZADATAKVJEZBA
    {
        public static void Izvedi()
        {
            Console.WriteLine("Unesi Zeljeni Broj :  ");
            string unos = Console.ReadLine();
            int broj;
            bool isvalid = int.TryParse(Console.ReadLine(), out broj);

            if (!isvalid)
            {
                Console.WriteLine("Uneseni broj nije validan.");

            }
            else
            {
                if (broj > 0)
                {
                    Console.WriteLine("Uneseni broj je pozitivan.");
                }
                else if (broj < 0)
                {
                    Console.WriteLine("Uneseni broj je negativan");
                }
                else
                {
                    Console.WriteLine("Broj je nula.");
                }
            }

        }

    }

}
