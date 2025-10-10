namespace AlexaAnillosDone.Aplicacion.DTOs
{
    public class CrearAnillo
    {
        public string Modelo { get; set; }
        public string Material { get; set; }
        public string Piedra { get; set; }
        public decimal Tamaño { get; set; }
        public decimal Peso { get; set; }
        public decimal Precio { get; set; }

        public CrearAnillo() { }

        public CrearAnillo(string modelo, string material, string piedra, decimal tamaño, decimal peso, decimal precio)
        {
            Modelo = modelo;
            Material = material;
            Piedra = piedra;
            Tamaño = tamaño;
            Peso = peso;
            Precio = precio;
        }
    }
}
