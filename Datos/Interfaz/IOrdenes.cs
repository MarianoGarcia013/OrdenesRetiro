using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordenes2023.Datos.Interfaz
{
    internal interface IOrdenes
    {
        DataTable ConsultarDB();
        bool EjecutarInsert(Ordenes nueva);
        bool EjecutarUpdate(Ordenes O);
    }
}
