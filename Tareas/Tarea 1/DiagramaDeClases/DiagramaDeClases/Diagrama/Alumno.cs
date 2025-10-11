using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagramaDeClases.Diagrama
{
    public class Alumno : Miembro
    {
        public string Escuela { get; set; }
        public string Curso { get; set; }
        public int Semestre { get; set; }
        public Alumno(string nombre, string apellido, int edad, string curso, int semestre, string escuela)
            : base(nombre, apellido, edad)
        {
            Curso = curso;
            Semestre = semestre;
            Escuela = escuela;
        }

        public void Detalles()
        {
            Console.WriteLine($"Alumno: {Nombre} {Apellido}\n Edad: {Edad}\n Escuela: {Escuela}\n Curso: {Curso}\n Semestre: {Semestre}\n\n");
        }
    }
}
