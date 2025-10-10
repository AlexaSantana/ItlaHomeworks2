using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace AlexaAnillosDone.Dominio.Entities
{
    public class Anillo
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(100)]
        public string Modelo { get; set; }

        [Required, MaxLength(50)]
        public string Material { get; set; }

        public string? Piedra { get; set; }

        [Required]
        [Column(TypeName = "decimal(5,2)")]
        public decimal Tamaño { get; set; }

        [Required]
        [Column(TypeName = "decimal(6,2)")]
        public decimal Peso_Gramos { get; set; }

        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Precio { get; set; }

        public Anillo() { }

        public Anillo(int id, string modelo, string material, string? piedra, decimal tamaño, decimal peso, decimal precio)
        {
            Id = id;
            Modelo = modelo;
            Material = material;
            Piedra = piedra;
            Tamaño = tamaño;
            Peso_Gramos = peso;
            Precio = precio;
        }

    }
}
