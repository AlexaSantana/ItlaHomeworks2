using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagramaDeClases.Diagrama
{
    public class Maestro : Docente
    {
        public string AulaGuia { get; set; }

        public Maestro(string nombre, string apellido, int edad, string escuela, string codigo, string departamento, List<string> cursos , List<string> asignaturas, string aulaGuia)
            : base(nombre, apellido, edad, escuela, codigo, departamento,cursos,asignaturas)
        {
            AulaGuia = aulaGuia;
        }

        public void Detalles()
        {
            Console.WriteLine($"Maestro: {Nombre} {Apellido}\n Edad: {Edad}\n Escuela: {Escuela}\n Código: {Codigo}\n Departamento: {Departamento}\n Cursos: {string.Join(", ", Cursos)}\n Asignaturas: {string.Join(", ", Asignaturas)}\n Aula Guía: {AulaGuia}\n\n");
        }
    }
}
