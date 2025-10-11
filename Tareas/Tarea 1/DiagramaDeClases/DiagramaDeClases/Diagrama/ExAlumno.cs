using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagramaDeClases.Diagrama
{
    public class ExAlumno : Miembro
    {
        public string Escuela { get; set; }
        public int AñoDeEgreso { get; set; }
        public ExAlumno(string nombre, string apellido, int edad, string escuela, int añoDeEgreso)
            : base(nombre, apellido, edad)
        {
            Escuela = escuela;
            AñoDeEgreso = añoDeEgreso;
        }

        public void Detalles()
        {
            Console.WriteLine($"ExAlumno: {Nombre} {Apellido}\n Edad: {Edad}\n Escuela: {Escuela}\n Año de Egreso: {AñoDeEgreso}\n\n");
        }

    }
}
