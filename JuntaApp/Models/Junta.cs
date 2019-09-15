using System;
using System.ComponentModel.DataAnnotations;

namespace JuntaApp.Models
{
    public class Junta
    {
        public int Id { get; set; }

        [Required]
        public ApplicationUser Organizador { get; set; }
        public DateTime Fecha { get; set; }


        [Required]
        [StringLength(255)]
        public string Lugar { get; set; }

        [Required]
        public Categoria Categoria { get; set; }
    }
}