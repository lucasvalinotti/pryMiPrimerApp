using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase1404
{
    public class Producto
    {
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public decimal Cantidad { get; set; }
        public string Caduca { get; set; }
        public string fechaVencimiento { get; set; }

        public Producto() { }

        public Producto(string nombre, string tipo, decimal cantidad, string caduca, string fecha)
        {
            Nombre = nombre;
            Cantidad = cantidad;
            Tipo = tipo;
            Caduca = caduca;
            fechaVencimiento = fecha;
        }

    }
}
