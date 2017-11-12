using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;

namespace Entidad
{
    public class ManejadorRequisicion
    {
        ManejadorPrincipal Mprincipal = new ManejadorPrincipal();
        InterfaceBaseDeDatos IbaseDatos = new InterfaceBaseDeDatos();
        public ManejadorRequisicion()
        {

        }

        public Requisicion getRequisicion(int idRequisicion)
        {
           return IbaseDatos.getRequisicion(idRequisicion);

        }

        public int CountRequisicionesPendientes()
        {
            return IbaseDatos.CountRequisicionesPendientes();
        }

        public DataTable getRequisicionesPorAprobar()
        {
            return IbaseDatos.getRequisicionesPorAprobar();
        }

        public int AutorizarRequisicion(int IDRequisicion, string Loginn)
        {
            return IbaseDatos.AutorizarRequisicion(IDRequisicion, Loginn);
        }

    }
}
