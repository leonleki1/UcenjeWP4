using System.ComponentModel.DataAnnotations;

namespace WebApiPaulovnija.Models
{
    public abstract class Entitet
    {
        [Key]
        public int id_radnika { get; set; }


    }
}
