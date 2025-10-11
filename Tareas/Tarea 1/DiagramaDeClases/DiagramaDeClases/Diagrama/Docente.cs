using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagramaDeClases.Diagrama
{
    public class Docente : Empleado
    {
        public List<string> Cursos { get; set; }
        public List<string> Asignaturas { get; set; }

        public Docente(string nombre, string apellido, int edad, string escuela, string codigo, string departamento, List<string> cursos, List<string> asignaturas)
            : base(nombre, apellido, edad, escuela, codigo, departamento)
        {
            Cursos = cursos;
            Asignaturas = asignaturas;
        }

        public void Detalles()
        {
            Console.WriteLine($"Docente: {Nombre} {Apellido}\n Edad: {Edad}\n Escuela: {Escuela}\n Código: {Codigo}\n Departamento: {Departamento}\n Cursos: {string.Join(", ", Cursos)}\n Asignaturas: {string.Join(", ", Asignaturas)}\n\n");
        }
    }
}
