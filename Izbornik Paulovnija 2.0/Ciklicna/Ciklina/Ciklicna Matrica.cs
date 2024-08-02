using System;

namespace CiklicnaMatricaApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Ciklicna ciklicna = new Ciklicna();

            ciklicna.IspisiCiklicnuMatricu();

           
            Console.ReadKey();
        }
    }

    public class Ciklicna
    {
        public void IspisiCiklicnuMatricu()
        {
            
            int n = 49;
            int[] brojevi = new int[n];

            
            for (int i = 0; i < n; i++)
            {
                brojevi[i] = i + 2;
            }

            
            int velicina = (int)Math.Ceiling(Math.Sqrt(n));
            int[,] matrica = new int[velicina, velicina];

            int indeks = 0;
            int gore = 0, dolje = velicina - 1, lijevo = 0, desno = velicina - 1;

            
            while (indeks < n)
            {
                for (int i = lijevo; i <= desno && indeks < n; i++)
                {
                    matrica[gore, i] = brojevi[indeks++];
                }
                gore++;
                for (int i = gore; i <= dolje && indeks < n; i++)
                {
                    matrica[i, desno] = brojevi[indeks++];
                }
                desno--;
                for (int i = desno; i >= lijevo && indeks < n; i--)
                {
                    matrica[dolje, i] = brojevi[indeks++];
                }
                dolje--;
                for (int i = dolje; i >= gore && indeks < n; i--)
                {
                    matrica[i, lijevo] = brojevi[indeks++];
                }
                lijevo++;
            }

            
            for (int red = 0; red < velicina; red++)
            {
                for (int kolona = 0; kolona < velicina; kolona++)
                {
                    if (matrica[red, kolona] != 0)
                    {
                        Console.Write(matrica[red, kolona] + "\t");
                    }
                    else
                    {
                        Console.Write("\t");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
