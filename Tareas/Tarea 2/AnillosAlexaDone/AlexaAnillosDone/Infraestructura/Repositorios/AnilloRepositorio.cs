using AlexaAnillosDone.Dominio.Entities;
using AlexaAnillosDone.Infraestructura.Context;

namespace AlexaAnillosDone.Infraestructura.Repositorios
{
    public class AnilloRepositorio
    {
        private readonly AnilloContext _context;
        public AnilloRepositorio(AnilloContext context)
        {
            _context = context;
        }

        public List<Anillo> GetAll()
        {
            return _context.Anillos.ToList();
        }

        public Anillo GetById(int id)
        {
            return _context.Anillos.Find(id);
        }

        public Anillo Create(Anillo anillo)
        {
            _context.Anillos.Add(anillo);
            _context.SaveChanges();
            return anillo;
        }

        public Anillo Update(Anillo anillo)
        {
            if(!_context.Anillos.Any(a => a.Id == anillo.Id))
            {
                return null;
            }

            _context.Anillos.Update(anillo);
            _context.SaveChanges();
            return anillo;
        }

        public void Delete(int id)
        {
            var anillo = _context.Anillos.Find(id);
            if (anillo != null)
            {
                _context.Anillos.Remove(anillo);
                _context.SaveChanges();
            }
        }
    }
}
