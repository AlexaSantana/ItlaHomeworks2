using DiagramaDeClases.Diagrama;

namespace DiagramaDeClases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var miembro = new Miembro("Juan", "Pérez", 30);
            var Alumno = new Alumno("Ana", "Gómez", 20, "4toB", 2, "Nuestra Señora de las Mercedes");
            var Alumno2 = new Alumno("Carlos", "López", 22, "5toA", 4, "Nuestra Señora de las Mercedes");
            var exAlumno = new ExAlumno("Luis", "Martínez", 25, "Nuestra Señora de las Mercedes", 2020);
            var empleado = new Empleado("María", "Rodríguez", 35, "Nuestra Señora de las Mercedes", "E123", "Recursos Humanos");
            var empleado2 = new Empleado("Pedro", "García", 40, "Nuestra Señora de las Mercedes", "E456", "Finanzas");
            var docente = new Docente("Sofía", "Hernández", 45, "Nuestra Señora de las Mercedes", "D789", "Educacion", new List<string> { "4toB","5toA" }, new List<string> { "Matematicas" });
            var docente2 = new Docente("Javier", "Fernández", 50, "Nuestra Señora de las Mercedes", "D012", "Educacion", new List<string> { "5toA" }, new List<string> { "Fisica", "Quimica" });
            var maestro = new Maestro("Elena", "Sánchez", 55, "Nuestra Señora de las Mercedes", "M345", "Educacion", new List<string> { "5toA" }, new List<string> { "Pintura", "Escultura" }, "5toA");
            var maestro2 = new Maestro("Ricardo", "Ramírez", 60, "Nuestra Señora de las Mercedes", "M678", "Educacion", new List<string> { "4toB" }, new List<string> { "Musica" }, "4toB");
            var administrativo = new Administrativo("Laura", "Torres", 38, "Nuestra Señora de las Mercedes", "A901", "Administracion", "Contabilidad");
            var administrador = new Administrador("Andrés", "Flores", 42, "Nuestra Señora de las Mercedes", "AD234", "Sistemas", new List<string> { "4toB" }, new List<string> { "Redes", "Seguridad" }, "Sistemas" );

            miembro.Detalles();
            Alumno.Detalles();
            Alumno2.Detalles();
            exAlumno.Detalles();
            empleado.Detalles();
            empleado2.Detalles();
            docente.Detalles();
            docente2.Detalles();
            maestro.Detalles();
            maestro2.Detalles();
            administrativo.Detalles();
            administrador.Detalles();
        }
    }
}
