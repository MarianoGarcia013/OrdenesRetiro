using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordenes2023.Dominio
{
    internal class Material
    {
        public int codigo { get; set; }
        public string nombre { get; set; }
        public double stock { get; set; }

        public Material(int codigo)
        {
            codigo= 0;
            nombre = string.Empty;
            stock = 0; 
        }

        public Material(int codigo, string nombre, double stock)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.stock = stock;
        }

        public override string ToString()
        {
            return nombre+ " " + stock;
        }
    }
}
