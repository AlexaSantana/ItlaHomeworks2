using AlexaAnillosDone.Dominio.Entities;

namespace AlexaAnillosDone.Aplicacion.DTOs
{
    public class FabricaAnillo
    {
        public static Anillo CrearDesdeDTO(CrearAnillo dto)
        {
            return new Anillo
            {
                Modelo = dto.Modelo,
                Material = dto.Material,
                Piedra = dto.Piedra,
                Tamaño = dto.Tamaño,
                Peso_Gramos = dto.Peso,
                Precio = dto.Precio
            };
        }

        public static DTOAnillo ConvertirA_DTO(Anillo anillo)
        {
            return new DTOAnillo
            {
                Id = anillo.Id,
                Modelo = anillo.Modelo,
                Material = anillo.Material,
                Piedra = anillo.Piedra,
                Tamaño = anillo.Tamaño,
                Peso = anillo.Peso_Gramos,
                Precio = anillo.Precio
            };
        }

        public static void ActualizarDesdeDTO(Anillo anillo, CrearAnillo dto)
        {
            anillo.Modelo = dto.Modelo;
            anillo.Material = dto.Material;
            anillo.Piedra = dto.Piedra;
            anillo.Tamaño = dto.Tamaño;
            anillo.Peso_Gramos = dto.Peso;
            anillo.Precio = dto.Precio;
        }

    }
}
