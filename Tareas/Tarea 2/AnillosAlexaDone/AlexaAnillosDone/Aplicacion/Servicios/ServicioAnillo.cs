using AlexaAnillosDone.Aplicacion.DTOs;
using AlexaAnillosDone.Dominio.Entities;
using AlexaAnillosDone.Infraestructura.Repositorios;

namespace AlexaAnillosDone.Aplicacion.Servicios
{
    public class ServicioAnillo
    {
        private readonly AnilloRepositorio _repositorio;
        public ServicioAnillo(AnilloRepositorio repositorio)
        {
            _repositorio = repositorio;
        }
        public List<DTOAnillo> ObtenerTodos()
        {
            List<Anillo> list = _repositorio.GetAll();
            return list.Select(a => FabricaAnillo.ConvertirA_DTO(a)).ToList();
        }
        public DTOAnillo ObtenerPorId(int id)
        {
            Anillo anillo = _repositorio.GetById(id);
            if (anillo == null)
            {
                return null;
            }

            return FabricaAnillo.ConvertirA_DTO(anillo);
        }
        public DTOAnillo Crear(CrearAnillo anillo)
        {
            Anillo nuevoAnillo = FabricaAnillo.CrearDesdeDTO(anillo);
            Anillo a = _repositorio.Create(nuevoAnillo);
            return FabricaAnillo.ConvertirA_DTO(a);
        }

        public DTOAnillo Actualizar(int id, CrearAnillo anillo)
        {
            var existente = _repositorio.GetById(id);
            if (existente == null)
            {
                return null;
            }

            FabricaAnillo.ActualizarDesdeDTO(existente, anillo);
            Anillo a = _repositorio.Update(existente);
            return FabricaAnillo.ConvertirA_DTO(a);
        }
        public void Eliminar(int id)
        {
            _repositorio.Delete(id);
        }
    }
}
