using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Datos;
namespace Datos
{
    public partial class InterfaceBaseDeDatos
    {
        public DataTable getPedidosSinPagar(string[] Datos)
        {
            string[] Parametros = new string[0];
            return getDatosTabla("getPedidosSinPagar", Parametros, Datos);
        }

        public DataTable getTicket(string[] Datos)
        {
            string[] Paramentros = { "@Pedido" };
            return getDatosTabla("Ticket", Paramentros, Datos[0]);
        }

        public int PagarVenta(string[] Datos)
        {
            string[] Parametros = { "@IDPedido", "@Importe", "@Abono", "@Feria", "@FechaPago", "@Empleado", "@FormaDePago", "@Descripcion" };
            return Ejecutar("PagarVenta", Parametros, Datos[0], Datos[1], Datos[2], Datos[3], Datos[4], Datos[5], Datos[6], Datos[7]);
        }

        public int ActualizaRestante(string[] Datos)
        {
            string[] Parametros = { "@IDPedido", "@RestantePorPagar" };
            return Ejecutar("ActualizaRestanteMejorado", Parametros, Datos[0], Datos[1]);
        }

        public int CorteDeCaja(string[] Datos)
        {
            string[] Parametros = { "@Fecha", "@Hora", "@Loginn","Supervisor", "@CajaChica","@Mil", "@Quinientos", "@Doscientos",
                "@Cien", "@Cincuenta", "@Veinte", "@Diez", "@Cinco", "@Dos", "@Uno", "@CincuentaCentavos",
                "@VeinteCentavos", "@DiezCentavos", "@CincoCentavos", "@Estimado","@Real","@CajaMaxima","@Banco","@Comentarios" };
            return Ejecutar("CorteDeCaja", Parametros, Datos[0], Datos[1], Datos[2], Datos[3], Datos[4], Datos[5], Datos[6], Datos[7],
                Datos[8], Datos[9], Datos[10], Datos[11], Datos[12], Datos[13], Datos[14], Datos[15], Datos[16], Datos[17], Datos[18], Datos[19],
                Datos[20], Datos[21], Datos[22], Datos[23]);
        }

        public DataTable VentasPorCorte(string[] Datos)
        {
            string[] Parametros = { "@Fecha" };
            return getDatosTabla("VentasPorCorte", Parametros, Datos[0]);
        }

        public DataTable ComprasPorCorte(string[] Datos)
        {
            string[] Parametros = { "@Fecha" };
            return getDatosTabla("ComprasPorCorte", Parametros, Datos[0]);
        }

        public DataTable getPedidosSinPagarBuscar(string[] Datos)
        {
            string[] Parametros = { "@IDPedido", "@NombreDentista" };
            return getDatosTabla("getPedidosSinPagarBuscar", Parametros, Datos[0], Datos[1]);
        }

        public DataTable CajaActual(string[] Datos)
        {
            string[] Parametros = { "@Fecha", "@CajaChica" };
            return getDatosTabla("CajaActual", Parametros, Datos[0], Datos[1]);
        }

        public DataTable UltimoCorte(string[] Datos)
        {
            string[] Parametros = { };
            return getDatosTabla("UltimoCorte", Parametros, Datos);
        }

        public int InsertRetiro(string[] Datos)
        {
            string[] Parametros = { "@IDCaja", "@Fecha", "@Hora", "@Monto", "@Mil", "@Quinientos", "@Doscientos",
                "@Cien", "@Cincuenta", "@Veinte", "@Diez", "@Cinco", "@Dos", "@Uno", "@CincuentaCentavos",
                "@VeinteCentavos", "@DiezCentavos", "@CincoCentavos", "@Restante", "@Empleado", "@Supervisor",
                "@Motivo", "@Comentarios" };
            return Ejecutar("Retiro", Parametros, Datos[0], Datos[1], Datos[2], Datos[3], Datos[4], Datos[5],
                Datos[6], Datos[7], Datos[8], Datos[9], Datos[10], Datos[11], Datos[12], Datos[13], Datos[14],
                Datos[15], Datos[16], Datos[17], Datos[18], Datos[19], Datos[20], Datos[21], Datos[22]);
        }

        public DataTable RetirosPorCorte(string[] Datos)
        {
            string[] Parametros = { "@Fecha" };
            return getDatosTabla("EfectivoDelCorte", Parametros, Datos[0]);
        }
        public DataTable VentasDelDia(string[] Datos)
        {
            string[] Parametros = { "@Fecha" };
            return getDatosTabla("VentasDelDia", Parametros, Datos[0]);
        }
        public DataTable RetirosDelDia(string[] Datos)
        {
            string[] Parametros = { "@Fecha" };
            return getDatosTabla("RetirosDelDia", Parametros, Datos[0]);
        }
        public DataTable VentasConTarjeta(string[] Datos)
        {
            string[] Parametros = { "@Fecha" };
            return getDatosTabla("VentasConTarjeta", Parametros, Datos[0]);
        }

        public DataTable PedidosPorEntregar(string[] Datos)
        {
            string[] Parametros = { };
            return getDatosTabla("PedidosPorEntregar", Parametros, Datos);
        }

        public int EntregaPedido(string[] Datos)
        {
            string[] Parametros = { "@Pedido", "@Estatus", "@Fecha" };
            return Ejecutar("EntregaPedido", Parametros, Datos[0], Datos[1], Datos[2]);
        }

        public DataTable getMaterialesProducto(string[] Datos)
        {
            string[] Parametros = { "@Material1", "@Material2", "@Producto" };
            return getDatosTabla("getMaterialesProducto", Parametros, Datos[0], Datos[1], Datos[2]);
        }

        public DataTable getDatosProductosPedido(string[] Datos)
        {
            string[] Parametros = { "@Pedido" };
            return getDatosTabla("getDatosProductosPedido", Parametros, Datos[0]);
        }

        public int ModificarPedido(string[] Datos)
        {
            string[] Parametros = { "@Pedido", "@Dentista", "@Estatus", "@FechaCalculada", "@Urgencia", "@Total", "@Pagado", "@Restante", "@IVA", "@Devuelto", "@Devolucion", "@Modificacion", "@FechaModi" };
            return Ejecutar("ModificarPedido", Parametros, Datos[0], Datos[1], Datos[2], Datos[3], Datos[4], Datos[5], Datos[6], Datos[7], Datos[8], Datos[9], Datos[10], Datos[11], Datos[12]);
        }
    }
}