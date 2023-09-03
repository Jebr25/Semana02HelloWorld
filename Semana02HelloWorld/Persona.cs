using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana02HelloWorld
{
    public class Persona
    {
        public int Dni { get; set; }
        public string NombreCompleto { get; set; }
        public string Telefono { get; set; }
        public bool Estado { get; set; }

        public Persona(int dni, string nombreCompleto, string telefono, bool estado) {
            Dni = dni;
            NombreCompleto = nombreCompleto;
            Telefono = telefono;
            Estado = estado;
        }

        public Persona()
        {

        }

    }
}
