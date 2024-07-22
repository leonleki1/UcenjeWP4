using System;
using System.Collections.Generic;

namespace Zavrsni_rad_Izbornik_2
{
    class Izbornik
    {
        private static Dictionary<int, string> radnici = new Dictionary<int, string>();
        private static Dictionary<int, string> zadaci = new Dictionary<int, string>();
        private static Dictionary<int, string> strojevi = new Dictionary<int, string>();
        private static Dictionary<int, string> rasadnici = new Dictionary<int, string>();
        private static Dictionary<int, string> sadnice = new Dictionary<int, string>();

        private static int idCounterRadnici = 1;
        private static int idCounterZadaci = 1;
        private static int idCounterStrojevi = 1;
        private static int idCounterRasadnici = 1;
        private static int idCounterSadnice = 1;

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("****************************");
                Console.WriteLine("Paulovnija 2.0");
                Console.WriteLine("****************************");
                Console.WriteLine("Sljedi glavni izbornik : ");
                Console.WriteLine("1. Radnici");
                Console.WriteLine("2. Zadaci");
                Console.WriteLine("3. Strojevi");
                Console.WriteLine("4. Rasadnici");
                Console.WriteLine("5. Sadnice");
                Console.WriteLine("6. Izlaz");
                Console.Write("Izaberite jednu od opcija: ");
                string rubrika = Console.ReadLine();

                switch (rubrika)
                {
                    case "1":
                        IzbornikRadnici();
                        break;
                    case "2":
                        IzbornikZadaci();
                        break;
                    case "3":
                        IzbornikStrojevi();
                        break;
                    case "4":
                        IzbornikRasadnici();
                        break;
                    case "5":
                        IzbornikSadnice();
                        break;
                    case "6":
                        return;
                    default:
                        Console.WriteLine("Nevažeći izbor. Pokušajte ponovno.");
                        break;
                }

                Console.WriteLine("\nPritisnite bilo koju tipku za nastavak...");
                Console.ReadKey();
            }
        }

        private static void IzbornikRadnici()
        {
            Izbornik("Radnici", PrikaziSveRadnike, DodajNovogRadnika, AzurirajRadnika, ObrisiRadnika);
        }

        private static void IzbornikZadaci()
        {
            Izbornik("Zadaci", PrikaziSveZadatke, DodajNoviZadatak, AzurirajZadatak, ObrisiZadatak);
        }

        private static void IzbornikStrojevi()
        {
            Izbornik("Strojevi", PrikaziSveStrojeve, DodajNoviStroj, AzurirajStroj, ObrisiStroj);
        }

        private static void IzbornikRasadnici()
        {
            Izbornik("Rasadnici", PrikaziSveRasadnike, DodajNoviRasadnik, AzurirajRasadnik, ObrisiRasadnik);
        }

        private static void IzbornikSadnice()
        {
            Izbornik("Sadnice", PrikaziSveSadnice, DodajNovuSadnicu, AzurirajSadnicu, ObrisiSadnicu);
        }

        private static void Izbornik(string naziv, Action prikaziSve, Action dodaj, Action azuriraj, Action obrisi)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"{naziv}:");
                Console.WriteLine("1. Prikaži sve");
                Console.WriteLine($"2. Dodaj novi {naziv.Substring(0, naziv.Length - 1).ToLower()}");
                Console.WriteLine($"3. Ažuriraj {naziv.Substring(0, naziv.Length - 1).ToLower()}");
                Console.WriteLine($"4. Obriši {naziv.Substring(0, naziv.Length - 1).ToLower()}");
                Console.WriteLine("5. Povratak");
                Console.Write("Izaberite opciju: ");
                string izbor = Console.ReadLine();

                switch (izbor)
                {
                    case "1":
                        prikaziSve();
                        break;
                    case "2":
                        dodaj();
                        break;
                    case "3":
                        azuriraj();
                        break;
                    case "4":
                        obrisi();
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
        }

        private static void PrikaziSveRadnike()
        {
            PrikaziSve(radnici, "radnika");
        }

        private static void DodajNovogRadnika()
        {
            DodajNovog(radnici, ref idCounterRadnici, "radnika");
        }

        private static void AzurirajRadnika()
        {
            Azuriraj(radnici, "radnika");
        }

        private static void ObrisiRadnika()
        {
            Obrisi(radnici, "radnika");
        }

        private static void PrikaziSveZadatke()
        {
            PrikaziSve(zadaci, "zadatka");
        }

        private static void DodajNoviZadatak()
        {
            DodajNovog(zadaci, ref idCounterZadaci, "zadatka");
        }

        private static void AzurirajZadatak()
        {
            Azuriraj(zadaci, "zadatka");
        }

        private static void ObrisiZadatak()
        {
            Obrisi(zadaci, "zadatka");
        }

        private static void PrikaziSveStrojeve()
        {
            PrikaziSve(strojevi, "stroja");
        }

        private static void DodajNoviStroj()
        {
            DodajNovog(strojevi, ref idCounterStrojevi, "stroja");
        }

        private static void AzurirajStroj()
        {
            Azuriraj(strojevi, "stroja");
        }

        private static void ObrisiStroj()
        {
            Obrisi(strojevi, "stroja");
        }

        private static void PrikaziSveRasadnike()
        {
            PrikaziSve(rasadnici, "rasadnika");
        }

        private static void DodajNoviRasadnik()
        {
            DodajNovog(rasadnici, ref idCounterRasadnici, "rasadnika");
        }

        private static void AzurirajRasadnik()
        {
            Azuriraj(rasadnici, "rasadnika");
        }

        private static void ObrisiRasadnik()
        {
            Obrisi(rasadnici, "rasadnika");
        }

        private static void PrikaziSveSadnice()
        {
            PrikaziSve(sadnice, "sadnice");
        }

        private static void DodajNovuSadnicu()
        {
            DodajNovog(sadnice, ref idCounterSadnice, "sadnice");
        }

        private static void AzurirajSadnicu()
        {
            Azuriraj(sadnice, "sadnice");
        }

        private static void ObrisiSadnicu()
        {
            Obrisi(sadnice, "sadnice");
        }

        private static void PrikaziSve(Dictionary<int, string> collection, string naziv)
        {
            Console.Clear();
            Console.WriteLine($"Prikaz svih {naziv}...");
            if (collection.Count == 0)
            {
                Console.WriteLine($"Trenutno nema {naziv}.");
                return;
            }
            foreach (var item in collection)
            {
                Console.WriteLine($"ID: {item.Key}, Naziv: {item.Value}");
            }
        }

        private static void DodajNovog(Dictionary<int, string> collection, ref int idCounter, string naziv)
        {
            Console.Clear();
            Console.WriteLine($"Dodavanje novog {naziv}...");
            try
            {
                Console.Write($"Unesite naziv {naziv}: ");
                string ime = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(ime))
                {
                    collection.Add(idCounter++, ime);
                    Console.WriteLine($"{naziv} {ime} je dodan.");
                }
                else
                {
                    Console.WriteLine($"Naziv {naziv} ne može biti prazan.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Dogodila se greška prilikom dodavanja {naziv}: {ex.Message}");
            }
        }

        private static void Azuriraj(Dictionary<int, string> collection, string naziv)
        {
            Console.Clear();
            Console.WriteLine($"Ažuriranje {naziv}...");
            try
            {
                Console.Write($"Unesite ID {naziv} za ažuriranje: ");
                if (int.TryParse(Console.ReadLine(), out int id) && collection.ContainsKey(id))
                {
                    Console.Write($"Unesite novi naziv {naziv}: ");
                    string ime = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(ime))
                    {
                        collection[id] = ime;
                        Console.WriteLine($"{naziv} je ažuriran.");
                    }
                    else
                    {
                        Console.WriteLine($"Naziv {naziv} ne može biti prazan.");
                    }
                }
                else
                {
                    Console.WriteLine($"Nevažeći ID {naziv}.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Dogodila se greška prilikom ažuriranja {naziv}: {ex.Message}");
            }
        }

        private static void Obrisi(Dictionary<int, string> collection, string naziv)
        {
            Console.Clear();
            Console.WriteLine($"Brisanje {naziv}...");
            try
            {
                Console.Write($"Unesite ID {naziv} za brisanje: ");
                if (int.TryParse(Console.ReadLine(), out int id) && collection.ContainsKey(id))
                {
                    collection.Remove(id);
                    Console.WriteLine($"{naziv} je obrisan.");
                }
                else
                {
                    Console.WriteLine($"Nevažeći ID {naziv}.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Dogodila se greška prilikom brisanja {naziv}: {ex.Message}");
            }
        }
    }
}
