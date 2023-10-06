using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordenes2023.Dominio
{
    internal class DetalleOrden
    {
        public Material material { get; set; }
        public int cantidad { get; set; }

        public DetalleOrden(Material material, int cantidad)
        {
            this.material = material;
            this.cantidad = cantidad;
        }
    }
}
