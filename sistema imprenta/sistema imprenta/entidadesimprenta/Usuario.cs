using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidadesimprenta
{
    public class Usuario
    {
        public string codigo { get; set; }
        public string Nombre { get; set; }
        public string Clave { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }

        public Usuario() { }

        public Usuario(string codigo, string nombre, string clave, string correo, string telefono)
        {
            this.codigo = codigo;
            Nombre = nombre;
            Clave = clave;
            Correo = correo;
            Telefono = telefono;
        }

        public Usuario(string codigo, string clave)
        {
            this.codigo = codigo;
            Clave = clave;
        }
    }
}
