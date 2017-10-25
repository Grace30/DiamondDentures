using System;
using System.Data;
using System.Windows.Forms;
using Entidad;
using DiseñoFinal.ReportesM;

namespace DiseñoFinal
{
    public partial class ReportesAlmacen : Form
    {
        InterfaceUsuario intusuario;
        ManejadorReportes mare = new ManejadorReportes();
        Validación v;
        Form pantalla;
        string UsuarioEnCurso = "";
        public ReportesAlmacen()
        {
            InitializeComponent();
            intusuario = new InterfaceUsuario(this);
            v = new Validación();
        }
        public ReportesAlmacen(Form pantalla)
        {
            InitializeComponent();
            intusuario = new InterfaceUsuario(this);
            v = new Validación();
            this.pantalla = pantalla;
            UsuarioEnCurso = MenuPrincipal.UsuarioEnCurso;
        }


        private void tpCatalago_Click(object sender, EventArgs e)
        {

        }

        private void ReportesAlmacen_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = UsuarioEnCurso;
            RellenarCatalogo();
            RellenarInventarioMat();
            RellenarListaProv();
            RellenarComprasProv();
            RellenarRequisicion();
            RellenarSalidas();
        }
        public void RellenarCatalogo()
        {
            var Catalogo = new DataTable();
            Catalogo = mare.ObtenerDatosCatalago();
            dgvCatalogo.RowCount = Catalogo.Rows.Count;
            dgvCatalogo.ColumnCount = Catalogo.Columns.Count;

            int renglon = 0;
            foreach (DataRow fila in Catalogo.Rows)
            {
                dgvCatalogo["Producto", renglon].Value = ReducirEspaciado(fila["Producto"].ToString());
                dgvCatalogo["Descripcion", renglon].Value = ReducirEspaciado(fila["Descripcion"].ToString());
                dgvCatalogo["TiempoBase", renglon].Value = ReducirEspaciado(fila["FabricaciónProducto(Días)"].ToString());
                dgvCatalogo["PrecioBase", renglon].Value = ReducirEspaciado(fila["PrecioProducto"].ToString());
                dgvCatalogo["Material", renglon].Value = ReducirEspaciado(fila["Material"].ToString());
                dgvCatalogo["FabricacionMaterial", renglon].Value = ReducirEspaciado(fila["FabricaciónMaterial"].ToString());
                dgvCatalogo["PrecioMaterial", renglon].Value = ReducirEspaciado(fila["PrecioMaterial"].ToString());
                dgvCatalogo["FabricacionTotal", renglon].Value = ReducirEspaciado(fila["FabricaciónTotal"].ToString());
                dgvCatalogo["PrecioTotal", renglon].Value = ReducirEspaciado(fila["PrecioTotal"].ToString());
                renglon++;
            }
        }
        public void RellenarInventarioMat()
        {
            var Inven = new DataTable();
            Inven = mare.ObtenerDatosInventarioMat();
            dgvInvenMat.RowCount = Inven.Rows.Count;
            dgvInvenMat.ColumnCount = Inven.Columns.Count;

            int renglon = 0;
            foreach (DataRow fila in Inven.Rows)
            {
                dgvInvenMat["Nombre", renglon].Value = ReducirEspaciado(fila["Nombre"].ToString());
                dgvInvenMat["DescripcionMaterial", renglon].Value = ReducirEspaciado(fila["DescripcionMaterial"].ToString());
                dgvInvenMat["CostoBase", renglon].Value = ReducirEspaciado(fila["CostoBase"].ToString());
                dgvInvenMat["PrecioBaseMaterial", renglon].Value = ReducirEspaciado(fila["PrecioBaseMaterial"].ToString());
                dgvInvenMat["Unidad", renglon].Value = ReducirEspaciado(fila["Unidad"].ToString());
                dgvInvenMat["Existencia", renglon].Value = ReducirEspaciado(fila["Existencia"].ToString());
                renglon++;
            }
        }
        public void RellenarListaProv()
        {
            var prov = new DataTable();
            prov = mare.ObtenerDatosListaProveedores();
            dgvProv.RowCount = prov.Rows.Count;
            dgvProv.ColumnCount = prov.Columns.Count;

            int renglon = 0;
            foreach (DataRow fila in prov.Rows)
            {
                dgvProv["ClaveProveedor", renglon].Value = ReducirEspaciado(fila["ClaveProveedor"].ToString());
                dgvProv["NombreProveedor", renglon].Value = ReducirEspaciado(fila["NombreProveedor"].ToString());
                dgvProv["Telefono", renglon].Value = ReducirEspaciado(fila["Telefono"].ToString());
                dgvProv["Correo", renglon].Value = ReducirEspaciado(fila["Correo"].ToString());
                dgvProv["DescripcionProveedor", renglon].Value = ReducirEspaciado(fila["DescripcionProveedor"].ToString());
                dgvProv["RFC", renglon].Value = ReducirEspaciado(fila["RFC"].ToString());
                dgvProv["Contacto", renglon].Value = ReducirEspaciado(fila["Contacto"].ToString());

                renglon++;
            }
        }
        public void RellenarComprasProv()
        {
            var com = new DataTable();
            com = mare.ObtenerDatosComprasProveedores();
            dgvCompras.RowCount = com.Rows.Count;
            dgvCompras.ColumnCount = com.Columns.Count;

            int renglon = 0;
            foreach (DataRow fila in com.Rows)
            {
                dgvCompras["IDCompra", renglon].Value = ReducirEspaciado(fila["IDCompra"].ToString());
                dgvCompras["NombredelProveedor", renglon].Value = ReducirEspaciado(fila["Nombre del Proveedor"].ToString());
                dgvCompras["NombredelMaterial", renglon].Value = ReducirEspaciado(fila["Nombre del Material"].ToString());
                dgvCompras["Cantidad", renglon].Value = ReducirEspaciado(fila["Cantidad"].ToString());
                dgvCompras["Total", renglon].Value = ReducirEspaciado(fila["Total"].ToString());
                dgvCompras["FechadelPedido", renglon].Value = ReducirEspaciado(fila["Fecha del Pedido"].ToString());
                dgvCompras["FechadelSurtido", renglon].Value = ReducirEspaciado(fila["Fecha de Surtido"].ToString());

                renglon++;
            }
        }
        public void RellenarRequisicion()
        {
            var req = new DataTable();
            req = mare.ObtenerDatosRequisicion();
            dgvReq.RowCount = req.Rows.Count;
            dgvReq.ColumnCount = req.Columns.Count;

            int renglon = 0;
            foreach (DataRow fila in req.Rows)
            {
                dgvReq["IDRequisicion", renglon].Value = ReducirEspaciado(fila["IDRequisicion"].ToString());
                dgvReq["Empleado", renglon].Value = ReducirEspaciado(fila["Empleado"].ToString());
                dgvReq["CantidadTotal", renglon].Value = ReducirEspaciado(fila["CantidadTotal"].ToString());
                dgvReq["FechadePedido", renglon].Value = ReducirEspaciado(fila["Fecha de Pedido"].ToString());
                dgvReq["Surtido", renglon].Value = ReducirEspaciado(fila["Surtido"].ToString());
                renglon++;
            }
        }
        public void RellenarSalidas()
        {
            var sal = new DataTable();
            sal = mare.ObtenerDatosSalidas();
            dgvSalidas.RowCount = sal.Rows.Count;
            dgvSalidas.ColumnCount = sal.Columns.Count;

            int renglon = 0;
            foreach (DataRow fila in sal.Rows)
            {
                dgvSalidas["IDPedido", renglon].Value = ReducirEspaciado(fila["IDPedido"].ToString());
                dgvSalidas["NombreMaterial", renglon].Value = ReducirEspaciado(fila["Nombre"].ToString());
                dgvSalidas["CodigoMaterial", renglon].Value = ReducirEspaciado(fila["CodigoMaterial"].ToString());
                dgvSalidas["DescripcionMateriall", renglon].Value = ReducirEspaciado(fila["Descripcion"].ToString());
                dgvSalidas["Cant", renglon].Value = ReducirEspaciado(fila["Cantidad"].ToString());
                dgvSalidas["FechaEntrega", renglon].Value = ReducirEspaciado(fila["FechaEntrega"].ToString());





                renglon++;
            }
        }



        public static string ReducirEspaciado(string Cadena)
        {
            string temp = "";
            if (!string.IsNullOrWhiteSpace(Cadena))
            {
                bool Empezo = false;
                for (int i = Cadena.Length - 1; i >= 0; i--)
                {
                    if (Cadena[i] != ' ')
                    {
                        Empezo = true;
                    }
                    if (Empezo)
                        temp = Cadena[i] + temp;
                }
            }
            return temp;
        }

        private void tabInventarioMat_Click(object sender, EventArgs e)
        {

        }

        private void btnCatalogo_Click(object sender, EventArgs e)
        {
            VistaPreviaCata objForm = new VistaPreviaCata();
            objForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VistaPreviaInventario objForm = new VistaPreviaInventario();
            objForm.ShowDialog();
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            VistaPreviaProveedores objForm = new VistaPreviaProveedores();
            objForm.ShowDialog();
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            VistaPreviaCompras objForm = new VistaPreviaCompras();
            objForm.ShowDialog();
        }

        private void btnreq_Click(object sender, EventArgs e)
        {
            VistaPreviaReq objform = new VistaPreviaReq();
            objform.ShowDialog();
        }

        private void btnSal_Click(object sender, EventArgs e)
        {
            VistaPreviaSalidas objformm = new VistaPreviaSalidas();
            objformm.ShowDialog();
        }

        private void pBSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            if (pantalla.GetType() == typeof(MenúReportes))
            {
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.GetType() == typeof(MenúReportes))
                    {
                        frm.Show();
                    }
                }
            }
        }

        private void tabProveedores_Click(object sender, EventArgs e)
        {

        }

        private void txtProveedor_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtProveedor_TextChanged_1(object sender, EventArgs e)
        {
            btnBuscar.PerformClick();
        }
    }
}
