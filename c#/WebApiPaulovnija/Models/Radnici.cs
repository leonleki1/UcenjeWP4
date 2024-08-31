using Microsoft.VisualBasic;

namespace WebApiPaulovnija.Models
{
    public class Radnici : Entitet
    {
        public string? Ime { get; set; }

        public string? Prezime { get; set; }

        public DateAndTime? Godine { get; set; }

        public string? Pozicija { get; set; }

        public int? Plata { get; set; }
    }
}
