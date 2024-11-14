using Gestiondecitasmedicas;
using System;
using System.Collections.Generic;

class Program
{
    static List<Cita> citas = new List<Cita>();

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("1. Crear Cita");
            Console.WriteLine("2. Listar Citas");
            Console.WriteLine("3. Modificar Masivo");
            Console.WriteLine("4. Fin");
            Console.Write("Elige una opción: ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    
                    break;
                case "2":
                    
                    break;
                case "3":
                    
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }
        }
    }
}