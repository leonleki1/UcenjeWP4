using System;

namespace CiklicnaMatricaApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kreiranje instance klase Ciklicna
            Ciklicna ciklicna = new Ciklicna();

            // Pozivanje metode za ispis ciklične matrice
            ciklicna.IspisiCiklicnuMatricu();

            // Dodavanje Console.ReadKey() da bi konzola ostala otvorena
            Console.ReadKey();
        }
    }

    public class Ciklicna
    {
        public void IspisiCiklicnuMatricu()
        {
            int n = 49; // Broj elemenata od 2 do 50
            int[] numbers = new int[n];

            // Popunjavanje niza brojevima od 2 do 50
            for (int index = 0; index < n; index++)
            {
                numbers[index] = index + 2;
            }

            // Kreiranje i popunjavanje ciklične matrice
            int[,] cyclicMatrix = new int[n, n];

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    cyclicMatrix[row, col] = numbers[(row + col) % n];
                }
            }

            // Ispisivanje matrice
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write(cyclicMatrix[row, col] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
