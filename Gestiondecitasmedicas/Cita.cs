using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestiondecitasmedicas
{
    public class Cita
    {
        public int numero { get; set; }
        public Estudiante estudiante { get; set; }
        public string enfermedad { get; set; }
        public double precio { get; set; }

        public Cita(int numero, Estudiante estudiante, string enfermedad, double precio)
        {
            this.numero = numero;
            this.estudiante = estudiante;
            this.enfermedad = enfermedad;
            this.precio = precio;
        }

        public override string ToString()
        {
            return $"Número: {numero}, Estudiante: {estudiante}, Enfermedad: {enfermedad}, Precio: {precio}";
        }
    }
}
