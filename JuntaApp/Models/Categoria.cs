using System.ComponentModel.DataAnnotations;

namespace JuntaApp.Models
{
    public class Categoria
    {
        public byte Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Nombre { get; set; }

    }
}