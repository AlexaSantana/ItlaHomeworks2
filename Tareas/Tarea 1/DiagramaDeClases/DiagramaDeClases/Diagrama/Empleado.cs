using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagramaDeClases.Diagrama
{
    public class Empleado : Miembro
    {
        public string Escuela { get; set; }
        public string Codigo { get; set; }
        public string Departamento { get; set; }

        public Empleado(string nombre, string apellido, int edad, string escuela, string codigo, string departamento)
            : base(nombre, apellido, edad)
        {
            Escuela = escuela;
            Codigo = codigo;
            Departamento = departamento;
        }

        public void Detalles()
        {
            Console.WriteLine($"Empleado: {Nombre} {Apellido}\n Edad: {Edad}\n Escuela: {Escuela}\n Código: {Codigo}\n Departamento: {Departamento}\n\n");
        }
    }
}
