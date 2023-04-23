﻿using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Acteur
    {
        [Key]
        public int Id { get; set; }
        public string PhotoProfilURL { get; set; }
        public string NomComplet { get; set; }
        public string Bio { get; set; }

    }
}
