using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordenes2023.Dominio
{
    internal class OrdenRetiro
    {
        public int nro_orden { get; set; }
        public DateTime fecha { get; set; }
        public string responsable { get; set; }

        public List<DetalleOrden> detalles { get; set; }

        public OrdenRetiro()
        {
            detalles= new List<DetalleOrden>();
        }

        public void AgregarDetalle(DetalleOrden detalle)
        {
            detalles.Add(detalle);
        }

        public void QuitarDetalle(int posicion)
        {
            detalles.RemoveAt(posicion);
        }

        
    }
}
