using eTickets.Data;
using eTickets.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Film
    {
        [Key]
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Description { get; set; }
        public double Prix { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; }
        public CategorieFilm CategorieFilm { get; set; }
    }
}
