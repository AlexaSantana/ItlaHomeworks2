using AlexaAnillosDone.Aplicacion.DTOs;
using AlexaAnillosDone.Aplicacion.Servicios;
using Microsoft.AspNetCore.Mvc;

namespace AlexaAnillosDone.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ControllerAnillo : ControllerBase
    {
        private readonly ServicioAnillo _servicio;
        public ControllerAnillo(ServicioAnillo servicio)
        {
            _servicio = servicio;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var anillos = _servicio.ObtenerTodos();
            return Ok(anillos);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var anillo = _servicio.ObtenerPorId(id);
            if (anillo == null)
                return NotFound();
            return Ok(anillo);
        }

        [HttpPost]
        public IActionResult Post(CrearAnillo anillo)
        {
            var nuevoAnillo = _servicio.Crear(anillo);
            return CreatedAtAction(nameof(Get), new { id = nuevoAnillo.Id }, nuevoAnillo);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, CrearAnillo anillo)
        {
            var actualizadoAnillo = _servicio.Actualizar(id,anillo);
            return Ok(actualizadoAnillo);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _servicio.Eliminar(id);
            return NoContent();
        }




    }
}
