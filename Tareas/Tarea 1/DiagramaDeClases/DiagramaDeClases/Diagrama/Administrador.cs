using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagramaDeClases.Diagrama
{
    public class Administrador : Docente
    {
        public string DepartamentoQueAdministra { get; set; }

        public Administrador(string nombre, string apellido, int edad, string escuela, string codigo, string departamento, List<string> cursos, List<string> asignaturas, string departamentoQueAdministra)
            : base(nombre, apellido, edad, escuela, codigo, departamento, cursos, asignaturas)
        {
            DepartamentoQueAdministra = departamentoQueAdministra;
        }

        public void Detalles()
        {
            Console.WriteLine($"Administrador: {Nombre} {Apellido}\n Edad: {Edad}\n Escuela: {Escuela}\n Código: {Codigo}\n Departamento: {Departamento}\n Departamento que Administra: {DepartamentoQueAdministra}\n\n");
        }
    }
}
