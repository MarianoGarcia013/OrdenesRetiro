using Ordenes2023.Datos.Interfaz;
using Ordenes2023.Dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordenes2023.Datos.Implementaciones
{
    internal class OrdenesDAO : IOrdenes
    {
        public DataTable ConsultarDB()
        {
           return Helper.ObtenerInstancia().ConsultarDB("[dbo].[SP_CONSULTAR_MATERIALES]");
        }      

        public bool EjecutarUpdate(Ordenes O)
        {
            throw new NotImplementedException();
        }
        public bool EjecutarInsert(Ordenes nueva)
        {
            return Helper.ObtenerInstancia().EjecutarInsert(nueva);
        }

        internal bool EjecutarInsert(OrdenRetiro nueva)
        {
            return Helper.ObtenerInstancia().EjecutarInsert(nueva);
        }
    }
}
