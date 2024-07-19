using System;
using System.Collections.Generic;

namespace Zavrsni_Rad.Konzolna_aplikacija
{
    public class Izbornik
    {
        private static List<string> radnici = new List<string>();
        private static List<string> sadnice = new List<string>();
        private static List<string> rasadnici = new List<string>();
        private static List<string> strojevi = new List<string>();
        private static List<string> zadaci = new List<string>();

        public static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("********************************");
                Console.WriteLine("Aplikacija Paulovnija 1.0");
                Console.WriteLine("********************************");
                Console.WriteLine("Slijedi glavni Izbornik :");
                Console.WriteLine("1. Radnici");
                Console.WriteLine("2. Rasadnik");
                Console.WriteLine("3. Sadnice");
                Console.WriteLine("4. Strojevi");
                Console.WriteLine("5. Zadaci");
                Console.WriteLine("6. Izlaz");
                Console.Write("Odabirite jednu od sljedećih opcija:  ");
                switch (Console.ReadLine())
                {
                    case "1":
                        Radnici();
                        break;
                    case "2":
                        Rasadnik();
                        break;
                    case "3":
                        Sadnice();
                        break;
                    case "4":
                        Strojevi();
                        break;
                    case "5":
                        Zadaci();
                        break;
                    case "6":
                        Console.WriteLine("Izlaz iz aplikacije paulovnija...");
                        return;
                    default:
                        Console.WriteLine("Nevažeći izbor. Pokušajte ponovno.");
                        break;
                }

                Console.WriteLine("\nPritisnite bilo koju tipku za nastavak...");
                Console.ReadKey();
            }
        }

        // Radnici
        private static void Radnici()
        {
            Console.Clear();
            Console.WriteLine("Opcija Radnici:");
            Console.WriteLine("1. Prikaz svih radnika");
            Console.WriteLine("2. Dodavanje novog radnika");
            Console.WriteLine("3. Ažuriranje postojećeg radnika");
            Console.WriteLine("4. Brisanje radnika");
            Console.WriteLine("5. Povratak na glavni izbornik");

            switch (Console.ReadLine())
            {
                case "1":
                    PrikaziSveRadnike();
                    break;
                case "2":
                    DodajNovogRadnika();
                    break;
                case "3":
                    AzurirajRadnika();
                    break;
                case "4":
                    ObrisiRadnika();
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Nevažeći izbor. Pokušajte ponovno.");
                    break;
            }

            Console.WriteLine("\nPritisnite bilo koju tipku za nastavak...");
            Console.ReadKey();
        }

        private static void PrikaziSveRadnike()
        {
            Console.Clear();
            Console.WriteLine("Prikaz svih radnika...");
            if (radnici.Count == 0)
            {
                Console.WriteLine("Trenutno nema zaposlenika.");
                return;
            }
            foreach (string radnik in radnici)
            {
                Console.WriteLine(radnik);
            }
        }

        private static void DodajNovogRadnika()
        {
            Console.Clear();
            Console.WriteLine("Dodavanje novog radnika...");
            try
            {
                Console.Write("Unesite ime radnika: ");
                string ime = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(ime))
                {
                    radnici.Add(ime);
                    Console.WriteLine($"Radnik {ime} je dodan.");
                }
                else
                {
                    Console.WriteLine("Ime radnika ne može biti prazno.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Dogodila se greška prilikom dodavanja radnika: {ex.Message}");
            }
        }

        private static void AzurirajRadnika()
        {
            Console.Clear();
            Console.WriteLine("Ažuriranje postojećeg radnika...");
            Console.Write("Unesite ime radnika kojeg želite ažurirati: ");
            string staroIme = Console.ReadLine();
            if (radnici.Contains(staroIme))
            {
                Console.Write("Unesite novo ime radnika: ");
                string novoIme = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(novoIme))
                {
                    int index = radnici.IndexOf(staroIme);
                    radnici[index] = novoIme;
                    Console.WriteLine($"Radnik {staroIme} je promijenjen u {novoIme}.");
                }
                else
                {
                    Console.WriteLine("Novo ime radnika ne može biti prazno.");
                }
            }
            else
            {
                Console.WriteLine($"Radnik {staroIme} nije pronađen.");
            }
        }

        private static void ObrisiRadnika()
        {
            Console.Clear();
            Console.WriteLine("Brisanje radnika...");
            Console.Write("Unesite ime radnika za brisanje: ");
            string ime = Console.ReadLine();
            if (radnici.Contains(ime))
            {
                radnici.Remove(ime);
                Console.WriteLine($"Radnik {ime} je obrisan.");
            }
            else
            {
                Console.WriteLine($"Radnik {ime} nije pronađen u sustavu.");
            }
        }

        // Rasadnik
        private static void Rasadnik()
        {
            Console.Clear();
            Console.WriteLine("Opcija Rasadnik:");
            Console.WriteLine("1. Prikaz svih rasadnika");
            Console.WriteLine("2. Dodavanje novog rasadnika");
            Console.WriteLine("3. Ažuriranje postojećeg rasadnika");
            Console.WriteLine("4. Brisanje rasadnika");
            Console.WriteLine("5. Povratak na glavni izbornik");

            switch (Console.ReadLine())
            {
                case "1":
                    PrikaziSveRasadnike();
                    break;
                case "2":
                    DodajNoviRasadnik();
                    break;
                case "3":
                    AzurirajRasadnik();
                    break;
                case "4":
                    ObrisiRasadnik();
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Nevažeći izbor. Pokušajte ponovno.");
                    break;
            }

            Console.WriteLine("\nPritisnite bilo koju tipku za nastavak...");
            Console.ReadKey();
        }

        private static void PrikaziSveRasadnike()
        {
            Console.Clear();
            Console.WriteLine("Prikaz svih rasadnika...");
            if (rasadnici.Count == 0)
            {
                Console.WriteLine("Trenutno nije dodan niti jedan rasadnik.");
                return;
            }
            foreach (string rasadnik in rasadnici)
            {
                Console.WriteLine(rasadnik);
            }
        }

        private static void DodajNoviRasadnik()
        {
            Console.Clear();
            Console.WriteLine("Dodavanje novog rasadnika...");
            try
            {
                Console.Write("Unesite ime rasadnika: ");
                string ime = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(ime))
                {
                    rasadnici.Add(ime);
                    Console.WriteLine($"Rasadnik {ime} je dodan.");
                }
                else
                {
                    Console.WriteLine("Ime rasadnika ne može biti prazno.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Dogodila se greška prilikom dodavanja rasadnika: {ex.Message}");
            }
        }

        private static void AzurirajRasadnik()
        {
            Console.Clear();
            Console.WriteLine("Ažuriranje postojećeg rasadnika...");
            Console.Write("Unesite ime rasadnika kojeg želite ažurirati: ");
            string staroIme = Console.ReadLine();
            if (rasadnici.Contains(staroIme))
            {
                Console.Write("Unesite novo ime rasadnika: ");
                string novoIme = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(novoIme))
                {
                    int index = rasadnici.IndexOf(staroIme);
                    rasadnici[index] = novoIme;
                    Console.WriteLine($"Rasadnik {staroIme} je promijenjen u {novoIme}.");
                }
                else
                {
                    Console.WriteLine("Novo ime rasadnika ne može biti prazno.");
                }
            }
            else
            {
                Console.WriteLine($"Rasadnik {staroIme} nije pronađen.");
            }
        }

        private static void ObrisiRasadnik()
        {
            Console.Clear();
            Console.WriteLine("Brisanje rasadnika...");
            Console.Write("Unesite ime rasadnika za brisanje: ");
            string ime = Console.ReadLine();
            if (rasadnici.Contains(ime))
            {
                rasadnici.Remove(ime);
                Console.WriteLine($"Rasadnik {ime} je obrisan.");
            }
            else
            {
                Console.WriteLine($"Rasadnik {ime} nije pronađen.");
            }
        }

        // Sadnice
        private static void Sadnice()
        {
            Console.Clear();
            Console.WriteLine("Opcija Sadnice:");
            Console.WriteLine("1. Prikaz svih sadnica");
            Console.WriteLine("2. Dodavanje nove sadnice");
            Console.WriteLine("3. Ažuriranje postojećih sadnica");
            Console.WriteLine("4. Brisanje sadnica");
            Console.WriteLine("5. Povratak na glavni izbornik");

            switch (Console.ReadLine())
            {
                case "1":
                    PrikaziSveSadnice();
                    break;
                case "2":
                    DodajNovuSadnicu();
                    break;
                case "3":
                    AzurirajSadnicu();
                    break;
                case "4":
                    ObrisiSadnicu();
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Nevažeći izbor. Pokušajte ponovno.");
                    break;
            }

            Console.WriteLine("\nPritisnite bilo koju tipku za nastavak...");
            Console.ReadKey();
        }

        private static void PrikaziSveSadnice()
        {
            Console.Clear();
            Console.WriteLine("Prikaz svih sadnica...");
            if (sadnice.Count == 0)
            {
                Console.WriteLine("Trenutno nema sadnica.");
                return;
            }
            foreach (string sadnica in sadnice)
            {
                Console.WriteLine(sadnica);
            }
        }

        private static void DodajNovuSadnicu()
        {
            Console.Clear();
            Console.WriteLine("Dodavanje nove sadnice...");
            try
            {
                Console.Write("Unesite ime sadnice: ");
                string ime = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(ime))
                {
                    sadnice.Add(ime);
                    Console.WriteLine($"Sadnica {ime} je dodana.");
                }
                else
                {
                    Console.WriteLine("Ime sadnice ne može biti prazno.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Dogodila se greška prilikom dodavanja sadnice: {ex.Message}");
            }
        }

        private static void AzurirajSadnicu()
        {
            Console.Clear();
            Console.WriteLine("Ažuriranje postojeće sadnice...");
            Console.Write("Unesite ime sadnice koju želite ažurirati: ");
            string staroIme = Console.ReadLine();
            if (sadnice.Contains(staroIme))
            {
                Console.Write("Unesite novo ime sadnice: ");
                string novoIme = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(novoIme))
                {
                    int index = sadnice.IndexOf(staroIme);
                    sadnice[index] = novoIme;
                    Console.WriteLine($"Sadnica {staroIme} je promijenjena u {novoIme}.");
                }
                else
                {
                    Console.WriteLine("Novo ime sadnice ne može biti prazno.");
                }
            }
            else
            {
                Console.WriteLine($"Sadnica {staroIme} nije pronađena.");
            }
        }

        private static void ObrisiSadnicu()
        {
            Console.Clear();
            Console.WriteLine("Brisanje sadnice...");
            Console.Write("Unesite ime sadnice za brisanje: ");
            string ime = Console.ReadLine();
            if (sadnice.Contains(ime))
            {
                sadnice.Remove(ime);
                Console.WriteLine($"Sadnica {ime} je obrisana.");
            }
            else
            {
                Console.WriteLine($"Sadnica {ime} nije pronađena.");
            }
        }

        // Strojevi
        private static void Strojevi()
        {
            Console.Clear();
            Console.WriteLine("Opcija Strojevi:");
            Console.WriteLine("1. Prikaz svih strojeva");
            Console.WriteLine("2. Dodavanje novog stroja");
            Console.WriteLine("3. Ažuriranje postojećeg stroja");
            Console.WriteLine("4. Brisanje strojeva");
            Console.WriteLine("5. Povratak na glavni izbornik");

            switch (Console.ReadLine())
            {
                case "1":
                    PrikaziSveStrojeve();
                    break;
                case "2":
                    DodajNoviStroj();
                    break;
                case "3":
                    AzurirajStroj();
                    break;
                case "4":
                    ObrisiStroj();
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Nevažeći izbor. Pokušajte ponovno.");
                    break;
            }

            Console.WriteLine("\nPritisnite bilo koju tipku za nastavak...");
            Console.ReadKey();
        }

        private static void PrikaziSveStrojeve()
        {
            Console.Clear();
            Console.WriteLine("Prikaz svih strojeva...");
            if (strojevi.Count == 0)
            {
                Console.WriteLine("Trenutno nema strojeva.");
                return;
            }
            foreach (string stroj in strojevi)
            {
                Console.WriteLine(stroj);
            }
        }

        private static void DodajNoviStroj()
        {
            Console.Clear();
            Console.WriteLine("Dodavanje novog stroja...");
            try
            {
                Console.Write("Unesite ime stroja: ");
                string ime = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(ime))
                {
                    strojevi.Add(ime);
                    Console.WriteLine($"Stroj {ime} je dodan.");
                }
                else
                {
                    Console.WriteLine("Ime stroja ne može biti prazno.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Dogodila se greška prilikom dodavanja stroja: {ex.Message}");
            }
        }

        private static void AzurirajStroj()
        {
            Console.Clear();
            Console.WriteLine("Ažuriranje postojećeg stroja...");
            Console.Write("Unesite ime stroja kojeg želite ažurirati: ");
            string staroIme = Console.ReadLine();
            if (strojevi.Contains(staroIme))
            {
                Console.Write("Unesite novo ime stroja: ");
                string novoIme = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(novoIme))
                {
                    int index = strojevi.IndexOf(staroIme);
                    strojevi[index] = novoIme;
                    Console.WriteLine($"Stroj {staroIme} je promijenjen u {novoIme}.");
                }
                else
                {
                    Console.WriteLine("Novo ime stroja ne može biti prazno.");
                }
            }
            else
            {
                Console.WriteLine($"Stroj {staroIme} nije pronađen.");
            }
        }

        private static void ObrisiStroj()
        {
            Console.Clear();
            Console.WriteLine("Brisanje stroja...");
            Console.Write("Unesite ime stroja za brisanje: ");
            string ime = Console.ReadLine();
            if (strojevi.Contains(ime))
            {
                strojevi.Remove(ime);
                Console.WriteLine($"Stroj {ime} je obrisan.");
            }
            else
            {
                Console.WriteLine($"Stroj {ime} nije pronađen.");
            }
        }

        // Zadaci
        private static void Zadaci()
        {
            Console.Clear();
            Console.WriteLine("Opcija Zadaci:");
            Console.WriteLine("1. Prikaz svih zadataka");
            Console.WriteLine("2. Dodavanje novog zadatka");
            Console.WriteLine("3. Ažuriranje postojećeg zadatka");
            Console.WriteLine("4. Brisanje zadatka");
            Console.WriteLine("5. Povratak na glavni izbornik");

            switch (Console.ReadLine())
            {
                case "1":
                    PrikaziSveZadatke();
                    break;
                case "2":
                    DodajNoviZadatak();
                    break;
                case "3":
                    AzurirajZadatak();
                    break;
                case "4":
                    ObrisiZadatak();
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Nevažeći izbor. Pokušajte ponovno.");
                    break;
            }

            Console.WriteLine("\nPritisnite bilo koju tipku za nastavak...");
            Console.ReadKey();
        }

        private static void PrikaziSveZadatke()
        {
            Console.Clear();
            Console.WriteLine("Prikaz svih zadataka...");
            if (zadaci.Count == 0)
            {
                Console.WriteLine("Trenutno nema zadataka.");
                return;
            }
            foreach (string zadatak in zadaci)
            {
                Console.WriteLine(zadatak);
            }
        }

        private static void DodajNoviZadatak()
        {
            Console.Clear();
            Console.WriteLine("Dodavanje novog zadatka...");
            try
            {
                Console.Write("Unesite naziv zadatka: ");
                string naziv = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(naziv))
                {
                    zadaci.Add(naziv);
                    Console.WriteLine($"Zadatak {naziv} je dodan.");
                }
                else
                {
                    Console.WriteLine("Naziv zadatka ne može biti prazan.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Dogodila se greška prilikom dodavanja zadatka: {ex.Message}");
            }
        }

        private static void AzurirajZadatak()
        {
            Console.Clear();
            Console.WriteLine("Ažuriranje postojećeg zadatka...");
            Console.Write("Unesite naziv zadatka kojeg želite ažurirati: ");
            string stariNaziv = Console.ReadLine();
            if (zadaci.Contains(stariNaziv))
            {
                Console.Write("Unesite novi naziv zadatka: ");
                string noviNaziv = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(noviNaziv))
                {
                    int index = zadaci.IndexOf(stariNaziv);
                    zadaci[index] = noviNaziv;
                    Console.WriteLine($"Zadatak {stariNaziv} je promijenjen u {noviNaziv}.");
                }
                else
                {
                    Console.WriteLine("Novi naziv zadatka ne može biti prazan.");
                }
            }
            else
            {
                Console.WriteLine($"Zadatak {stariNaziv} nije pronađen.");
            }
        }

        private static void ObrisiZadatak()
        {
            Console.Clear();
            Console.WriteLine("Brisanje zadatka...");
            Console.Write("Unesite naziv zadatka za brisanje: ");
            string naziv = Console.ReadLine();
            if (zadaci.Contains(naziv))
            {
                zadaci.Remove(naziv);
                Console.WriteLine($"Zadatak {naziv} je obrisan.");
            }
            else
            {
                Console.WriteLine($"Zadatak {naziv} nije pronađen.");
            }
        }
    }
}
