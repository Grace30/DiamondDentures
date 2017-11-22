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

        public int CountRequisicionesPendientes(int countAnt)
        {
            return IbaseDatos.CountRequisicionesPendientes(countAnt);
        }

        public DataTable getRequisicionesPorAprobar()
        {
            return IbaseDatos.getRequisicionesPorAprobar();
        }

        public int AutorizarRequisicion(int IDRequisicion, string Loginn)
        {
            return IbaseDatos.AutorizarRequisicion(IDRequisicion, Loginn);
        }

        public int Pagar(string loginn,string tipo, Requisicion requisicion)
        {
            return IbaseDatos.IngresarCompra(loginn, tipo, requisicion);
        }

        public DataTable getRequisicionesConFiltro(string IdRequisicion , string Estado , string Surtido , string Solicitante , string Autorizante, string Proveedor ,
                        DateTime FechaSoliIni, DateTime FechaSoliFin, DateTime FechaAutoIni, DateTime FechaAutoFin,
                        DateTime FechaEntregaIni, DateTime FechaEntregaFin)
        {
            return IbaseDatos.getRequisicionesConFiltros(IdRequisicion, Estado, Surtido, Solicitante, Autorizante, Proveedor,
                        FechaSoliIni, FechaSoliFin, FechaAutoIni, FechaAutoFin,
                        FechaEntregaIni, FechaEntregaFin);
        }
    }
}
