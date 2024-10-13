using System;

namespace Ciklicna.Ljubavni_kalkulator
{
    internal class Kalkulator
        
    {
       
        public int IzracunajLjubavniRezultat(string ime1, string ime2)
        {

            string kombinirana_imena = ime1.ToLower() + ime2.ToLower();


            string slova_ljubavi = "love";


            int brojac = 0;
            foreach (char slovo in slova_ljubavi)
            {
                brojac += kombinirana_imena.Count(c => c == slovo);
            }


            int ljubavni_postotak = brojac * 10;


            if (ljubavni_postotak > 100)
            {
                ljubavni_postotak = 100;
            }

            return ljubavni_postotak;
        }

        public void Pokreni()
        {

            Console.Write("Unesi ime prve osobe: ");
            string ime1 = Console.ReadLine();

            Console.Write("Unesi ime druge osobe: ");
            string ime2 = Console.ReadLine();


            int rezultat = IzracunajLjubavniRezultat(ime1, ime2);


            Console.WriteLine($"Kompatibilnost između {ime1} i {ime2} je {rezultat}%.");
        }
    }
}
