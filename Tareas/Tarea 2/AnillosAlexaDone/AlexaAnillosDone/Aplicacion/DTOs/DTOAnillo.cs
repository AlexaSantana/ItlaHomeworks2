using AlexaAnillosDone.Dominio.Entities;

namespace AlexaAnillosDone.Aplicacion.DTOs
{
    public class DTOAnillo
    {
        public int Id { get; set; }
        public string Modelo { get; set; }
        public string Material { get; set; }
        public string Piedra { get; set; }
        public decimal Tamaño { get; set; }
        public decimal Peso { get; set; }
        public decimal Precio { get; set; }

        public DTOAnillo() { }

        public DTOAnillo(int id, string modelo, string material, string piedra, decimal tamaño, decimal peso, decimal precio)
        {
            Id = id;
            Modelo = modelo;
            Material = material;
            Piedra = piedra;
            Tamaño = tamaño;
            Peso = peso;
            Precio = precio;
        }
    }
}
