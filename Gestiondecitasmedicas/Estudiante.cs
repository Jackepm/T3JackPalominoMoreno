using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestiondecitasmedicas
{
    public class Estudiante
    {
        public int codigo { get; set; }
        public string nombre { get; set; }
        public string universidad { get; set; }

        public Estudiante(int codigo, string nombre, string universidad)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.universidad = universidad;
        }

        public override string ToString()
        {
            return $"Código: {codigo}, Nombre: {nombre}, Universidad: {universidad}";
        }
    }
}
