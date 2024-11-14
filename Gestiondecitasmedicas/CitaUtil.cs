using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestiondecitasmedicas
{
    public static class CitaUtil
    {
        public static void CrearCita(List<Cita> citas)
        {
            Console.Write("Número de cita: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Código del estudiante: ");
            int codigoEstudiante = int.Parse(Console.ReadLine());

            Console.Write("Nombre del estudiante: ");
            string nombreEstudiante = Console.ReadLine();

            Console.Write("Universidad del estudiante: ");
            string universidadEstudiante = Console.ReadLine();

            Estudiante estudiante = new Estudiante(codigoEstudiante, nombreEstudiante, universidadEstudiante);

            Console.Write("Enfermedad: ");
            string enfermedad = Console.ReadLine();

            Console.Write("Precio: ");
            double precio = double.Parse(Console.ReadLine());

            citas.Add(new Cita(numero, estudiante, enfermedad, precio));
            Console.WriteLine("Cita creada con éxito");
        }
    }
}