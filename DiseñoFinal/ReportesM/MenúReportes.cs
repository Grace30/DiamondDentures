using CrystalDecisions.CrystalReports.Engine;
using DiseñoFinal.ReportesM;
using System;
using System.Windows.Forms;


namespace DiseñoFinal
{
    public partial class MenúReportes : Form
    {
        Form pantalla;
        string Folio;
        InterfaceUsuario intusuario;
        string UsuarioEnCurso = "";
        public MenúReportes()
        {
           
            InitializeComponent();
            intusuario = new InterfaceUsuario(this);
            UsuarioEnCurso = MenuPrincipal.UsuarioEnCurso;
         
           VistaPreviarpt  temp = new VistaPreviarpt();
            crystalReportViewer1.ReportSource = temp;
        }

        private void btnReportesPedido_Click(object sender, EventArgs e)
        {
            Reportes frm = new Reportes(this);
            intusuario.desplegarPantalla(frm);
            intusuario.cerrarPantalla(this);
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            ReportesVentas frm = new ReportesVentas(this);
            intusuario.desplegarPantalla(frm);
            intusuario.cerrarPantalla(this);
        }

        private void btnAlmacen_Click(object sender, EventArgs e)
        {
            ReportesAlmacen frm = new ReportesAlmacen(this);
            intusuario.desplegarPantalla(frm);
            intusuario.cerrarPantalla(this);
        }

        private void MenúReportes_Load(object sender, EventArgs e)
        {
        
            lblUsuario.Text = UsuarioEnCurso;

        }

        private void btnFinanzas_Click(object sender, EventArgs e)
        {

        }

        private void pBSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            //if (pantalla.GetType() == typeof(MenuPrincipal))
            //{
            //    foreach (Form frm in Application.OpenForms)
            //    {
            //        if (frm.GetType() == typeof(MenuPrincipal))
            //        {
            //            frm.Show();
            //        }
            //    }
            //}
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ReportesAlmacen frm = new ReportesAlmacen(this);
            intusuario.desplegarPantalla(frm);
            intusuario.cerrarPantalla(this);
        }

        
        
        private void SeleccionarNodo(string nombre)
        {
            switch (nombre)
            {
                case "NLEmpleados":
                    ListadoEmpleados temp = new ListadoEmpleados();
                    temp.SetDatabaseLogon("AdminDD", "Admin123123", "Rebeater.Database.Windows.Net", "DiamondDentures");
                    crystalReportViewer1.ReportSource = temp;
                    break;
                case "NLClientes":
                    ListadoClientes objReporte = new ListadoClientes();
                    objReporte.SetDatabaseLogon("AdminDD", "Admin123123", "Rebeater.Database.Windows.Net", "DiamondDentures");
                    crystalReportViewer1.ReportSource = objReporte;
                    break;
                case "NLPedidos":
                    ListadoClientes objre = new ListadoClientes();
                    objre.SetDatabaseLogon("AdminDD", "Admin123123", "Rebeater.Database.Windows.Net", "DiamondDentures");
                    crystalReportViewer1.ReportSource = objre;
                    break;
                case "NLVentas":
                    ReporteGeneralVentas tem = new ReporteGeneralVentas();
                    tem.SetDatabaseLogon("AdminDD", "Admin123123", "Rebeater.Database.Windows.Net", "DiamondDentures");
                    crystalReportViewer1.ReportSource = tem;
                    break;
                case "NLCatalogo":
                    ReporteCatalogoProductos temp1 = new ReporteCatalogoProductos();
                    temp1.SetDatabaseLogon("AdminDD", "Admin123123", "Rebeater.Database.Windows.Net", "DiamondDentures");
                    crystalReportViewer1.ReportSource = temp1;
                    break;
                case "NLInventario":
                    ReporteInventario temp2 = new ReporteInventario();
                    temp2.SetDatabaseLogon("AdminDD", "Admin123123", "Rebeater.Database.Windows.Net", "DiamondDentures");
                    crystalReportViewer1.ReportSource = temp2;
                    break;
                case "NLCompras":
                    ReporteCompras temp3 = new ReporteCompras();
                    temp3.SetDatabaseLogon("AdminDD", "Admin123123", "Rebeater.Database.Windows.Net", "DiamondDentures");
                    crystalReportViewer1.ReportSource = temp3;
                    break;
                case "NLProveedores":
                    ReporteProveedores temp4 = new ReporteProveedores();
                    temp4.SetDatabaseLogon("AdminDD", "Admin123123", "Rebeater.Database.Windows.Net", "DiamondDentures");
                    crystalReportViewer1.ReportSource = temp4;
                    break;
                case "NLSalidas":
                    ReporteSalidas temp5 = new ReporteSalidas();
                    temp5.SetDatabaseLogon("AdminDD", "Admin123123", "Rebeater.Database.Windows.Net", "DiamondDentures");
                    crystalReportViewer1.ReportSource = temp5;
                    break;

            }
        }
       

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
        TreeNode x;
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            x = e.Node;
            SeleccionarNodo(x.Name);
        }
    }
}
