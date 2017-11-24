using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;

namespace Entidad
{
    public class ManejadorControlPedido
    {
        InterfaceBaseDeDatos IbaseDatos = new InterfaceBaseDeDatos();
        

        public DataTable ObtenerPedido (string [] Datos)
        {
            return IbaseDatos.ObtenerPedido(Datos);
        }
        public DataTable ObtenerDatosPedido(string[] Datos)
        {
            return IbaseDatos.ObtenerDatosPedido(Datos);
        }

        public DataTable ObtenerDatosPiezas(string[] Datos)
        {
            return IbaseDatos.ObtenerDatosPiezas(Datos);
        }

        public DataTable ObtenerDatosMateriales(string[] Datos)
        {
            return IbaseDatos.ObtenerDatosMateriales(Datos);
        }

        public DataTable EditarPieza(string[] Datos)
        {
            return IbaseDatos.EditarPieza(Datos);
        }

        public DataTable EditarMaterial(string[] Datos)
        {
            return IbaseDatos.EditarMaterial(Datos);
        }

        public int ActualizarPieza(string[] Datos)
        {
            return IbaseDatos.ActualizarPieza(Datos);
        }
        public int ActualizarMaterial(string[] Datos)
        {
            return IbaseDatos.ActualizarMaterial(Datos);
        }

        public int CambiarLab(string[] Datos)
        {
            return IbaseDatos.CambiarLab(Datos);
        }
        public int AgregarDatosPieza(string[] Datos)
        {
            return IbaseDatos.AgregarDatosPieza(Datos);
        }
        public int AgregarDatosMaterial(string[] Datos)
        {
            return IbaseDatos.AgregarDatosMaterial(Datos);
        }

        public int BorrarPieza(string[] Datos)
        {
            return IbaseDatos.BorrarPieza(Datos);
        }
        public int BorrarMaterial(string[] Datos)
        {
            return IbaseDatos.BorrarMaterial(Datos);
        }

        public int CambiarEstado(string[] Datos)
        {
            return IbaseDatos.CambiarEstado(Datos);
        }

        public int Urgente(string[] Datos)
        {
            return IbaseDatos.Urgente(Datos);
        }


        public DataTable ObtenerRequisiciones(string[] Datos)
        {
            return IbaseDatos.ObtenerRequisiciones(Datos);
        }
        public DataTable ObtenerRequiProv(string[] Datos)
        {
            return IbaseDatos.ObtenerRequiProv(Datos);
        }
        public DataTable TodasRequisicion(string[] Datos)
        {
            return IbaseDatos.TodasRequisiciones(Datos);
        }
        public DataTable RequisicionesAcep(string[] Datos)
        {
            return IbaseDatos.RequisicionesAcep(Datos);
        }
        public DataTable ObtenerDatosInsumos(string[] Datos)
        {
            return IbaseDatos.ObtenerDatosInsumos(Datos);
        }
        public DataTable ObtenerInventarioMateriales(string[] Datos)
        {
            return IbaseDatos.ObtenerInventarioMateriales(Datos);
        }
        public DataTable ComprasAProveedor(string[] Datos)
        {
            return IbaseDatos.ComprasAProveedor(Datos);
        }
        public DataTable ObtenerProveedores(string[] Datos)
        {
            return IbaseDatos.ObtenerProveedores(Datos);
        }

        public DataTable ObtenerCatalogo(string[] Datos)
        {
            return IbaseDatos.ObtenerCatalogo(Datos);
        }

        public DataTable ObtenerEntradas(string[] Datos)
        {
            return IbaseDatos.ObtenerEntradas(Datos);
        }

        public DataTable ObtenerSalidas(string[] Datos)
        {
            return IbaseDatos.ObtenerSalidas(Datos);
        }

        public DataTable ObtenerHistorial(string[] Datos)
        {
            return IbaseDatos.ObtenerHistorial(Datos);
        }

        public DataTable ObtenerFaltantes(string[] Datos)
        {
            return IbaseDatos.ObtenerFaltantes(Datos);
        }

        public int SumarMat(string[] Datos)
        {
            return IbaseDatos.SumarMat(Datos);
        }

        public int ActualizarCantidades(string[] Datos)
        {
            return IbaseDatos.ActualizarCantidades(Datos);
        }

        public int BorrardeRequi(string[] Datos)
        {
            return IbaseDatos.BorrardeRequi(Datos);
        }
        public int HistorialInv(string[] Datos)
        {
            return IbaseDatos.HistorialInv(Datos);
        }

        public int ActualizarExistencia(string[] Datos)
        {
            return IbaseDatos.ActualizarExistencia(Datos);
        }

        public int EstadoRequi(string[] Datos)
        {
            return IbaseDatos.EstadoRequi(Datos);
        }
        public int InsertarRequisicion(string[] Datos)
        {
            return IbaseDatos.InsertarRequisicion(Datos);
        }

        public int InsertarDetalleRequisicion(string[] Datos)
        {
            return IbaseDatos.InsertarDetalleRequisicion(Datos);
        }

        public DataTable getPedidosSinPagar(string[] Datos)
        {
            return IbaseDatos.getPedidosSinPagar(Datos);
        }

        public DataTable getTicket(string[] Datos)
        {
            return IbaseDatos.getTicket(Datos);
        }

        public int PagarVenta(string[] Datos)
        {
            return IbaseDatos.PagarVenta(Datos);
        }

        public int ActualizaRestante(string[] Datos)
        {
            return IbaseDatos.ActualizaRestante(Datos);
        }

        public int CorteDeCaja (string[] Datos)
        {
            return IbaseDatos.CorteDeCaja(Datos);
        }

        public DataTable VentasPorCorte(string[] Datos)
        {
            return IbaseDatos.VentasPorCorte(Datos);
        }
        public DataTable ComprasPorCorte(string[] Datos)
        {
            return IbaseDatos.ComprasPorCorte(Datos);
        }

        public DataTable PedidosSinPagarBuscar(string[] Datos)
        {
            return IbaseDatos.getPedidosSinPagarBuscar(Datos);
        }

        public DataTable CajaActual(string[] Datos)
        {
            return IbaseDatos.CajaActual(Datos);
        }

        public DataTable UltimoCorte (string[] Datos)
        {
            return IbaseDatos.UltimoCorte(Datos);
        }

        public int InsertRetiro(string[] Datos)
        {
            return IbaseDatos.InsertRetiro(Datos);
        }

        public DataTable RetirosPorCorte(string[] Datos)
        {
            return IbaseDatos.RetirosPorCorte(Datos);
        }
        public DataTable VentasDelDia(string[] Datos)
        {
            return IbaseDatos.VentasDelDia(Datos);
        }
        public DataTable RetirosDelDia(string[] Datos)
        {
            return IbaseDatos.RetirosDelDia(Datos);
        }

        public DataTable VentasConTarjeta(string[] Datos)
        {
            return IbaseDatos.VentasConTarjeta(Datos);
        }

        public DataTable PedidosPorEntregar(string[] Datos)
        {
            return IbaseDatos.PedidosPorEntregar(Datos);
        }

        public int EntregaPedido(string[] Datos)
        {
            return IbaseDatos.EntregaPedido(Datos);
        }

        public DataTable UltimaVenta(string[] Datos)
        {
            return IbaseDatos.UltimaVenta(Datos);
        }

        public int ActualizaBanco(string[] Datos)
        {
            return IbaseDatos.ActualizaBanco(Datos);
        }

        public int EnviarRequi(string[] Datos)
        {
            return IbaseDatos.EnviarRequi(Datos);
        }
    }
}
