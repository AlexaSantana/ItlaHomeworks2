using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagramaDeClases.Diagrama
{
    public class Administrativo : Empleado
    {
        public string Area { get; set; }

        public Administrativo(string nombre, string apellido, int edad, string escuela, string codigo, string area, string departamento)
            : base(nombre, apellido, edad, escuela, codigo, departamento)
        {
            Area = area;
        }

        public void Detalles()
        {
            Console.WriteLine($"Administrativo: {Nombre} {Apellido}\n Edad: {Edad}\n Escuela: {Escuela}\n Código: {Codigo}\n Área: {Area}\n Departamento: {Departamento}\n\n");
        }
    }
}
