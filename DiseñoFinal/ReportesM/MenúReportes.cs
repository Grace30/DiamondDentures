using CrystalDecisions.CrystalReports.Engine;
using DiseñoFinal.ReportesM;
using DiseñoFinal.ReportesM.PantallaListados;
using DiseñoFinal.ReportesM.Reportes;
using DiseñoFinal.ReportesM.Reportes.Consultas;
using DiseñoFinal.ReportesM.Reportes.Listados;
using System;
using static DiseñoFinal.ReportesM.CamposListados;
using System.Windows.Forms;


namespace DiseñoFinal
{
    public partial class MenúReportes : Form
    {
        Form pantalla;
        string Folio;
        Validación v;
        InterfaceUsuario intusuario;
        string UsuarioEnCurso = "";
        public MenúReportes()
        {
           
            InitializeComponent();
            intusuario = new InterfaceUsuario(this);
            UsuarioEnCurso = MenuPrincipal.UsuarioEnCurso;
            v = new Validación();
            ReportesM.Reportes.VistaPreviarpt temp = new VistaPreviarpt();
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
            PantallaListadosGeneral x;
            switch (nombre)
            {
                case "NLEmpleados":
                    ListadoEmpleados temp = new ListadoEmpleados();
                    temp.SetDatabaseLogon("AdminDD", "Admin123123", "Rebeater.Database.Windows.Net", "DiamondDentures");
                    crystalReportViewer1.ReportSource = temp;
                    break;
                case "NLEmpleadosDepartamento":
                    ListadoEmpleadosDepartamentos temp0 = new ListadoEmpleadosDepartamentos();
                    temp0.SetDatabaseLogon("AdminDD", "Admin123123", "Rebeater.Database.Windows.Net", "DiamondDentures");
                    crystalReportViewer1.ReportSource = temp0;
                    break;
                case "NLClientes":
                    ListadoClientes objReporte = new ListadoClientes();
                    objReporte.SetDatabaseLogon("AdminDD", "Admin123123", "Rebeater.Database.Windows.Net", "DiamondDentures");
                    crystalReportViewer1.ReportSource = objReporte;
                    break;
                case "NLPedidos":
                    ListadoPedidos objre = new ListadoPedidos();
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
                case "NLNomina":
                    VerNominaMes frm1 = new VerNominaMes();
                    frm1.ShowDialog();
                    break;
                case "NRRequi":
                    VerRequisicion frm = new VerRequisicion();
                    frm.ShowDialog();
                    break;
                case "NRTicket":
                    VerTickets tic = new VerTickets();
                    tic.ShowDialog();
                    break;
                case "NRForma":
                    VerFormasPedido form = new VerFormasPedido();
                    form.ShowDialog();
                    break;
                case "NROficio":
                    VerOficios form3 = new VerOficios();
                    form3.ShowDialog();
                    break;
                case "NRNota":
                    VerNotas form4 = new VerNotas();
                    form4.ShowDialog();
                    break;
                case "NRFacturas":
                    Facturas form5 = new Facturas();
                    form5.ShowDialog();
                    break;
                case "NCVentas":
                    ReportesVentas form6 = new ReportesVentas();
                    form6.ShowDialog();
                    break;
                case "NRCortes":
                    CortesdeCaja form7 = new CortesdeCaja();
                    form7.ShowDialog();
                    break;
                case "NRBalance":
                    BalanceGeneral form8 = new BalanceGeneral();
                    form8.ShowDialog();
                    break;
                case "Empleados":
                    x = new PantallaListadosGeneral(CamposEmpleados, nombre);
                    x.ShowDialog();
                    break;
                case "Dentista":
                    x = new PantallaListadosGeneral(CamposDentista, nombre);
                    x.ShowDialog();
                    break;
                case "Pedido":
                    x = new PantallaListadosGeneral(CamposPedido, nombre);
                    x.ShowDialog();
                    break;
                case "Material":
                    x = new PantallaListadosGeneral(CamposMaterial, nombre);
                    x.ShowDialog();
                    break;
                case "Producto":
                    x = new PantallaListadosGeneral(CamposProducto, nombre);
                    x.ShowDialog();
                    break;
                case "MaterialesProducto":
                    x = new PantallaListadosGeneral(CamposMaterialesProducto, nombre);
                    x.ShowDialog();
                    break;
                case "CorteCaja":
                    x = new PantallaListadosGeneral(CamposCorteCaja, nombre);
                    x.ShowDialog();
                    break;
                case "Compras":
                    x = new PantallaListadosGeneral(CamposCompras, nombre);
                    x.ShowDialog();
                    break;
                case "Proveedores":
                    x = new PantallaListadosGeneral(CamposProveedores, nombre);
                    x.ShowDialog();
                    break;
                case "Requisicion":
                    x = new PantallaListadosGeneral(CamposRequisicion, nombre);
                    x.ShowDialog();
                    break;
                case "Ventas":
                    x = new PantallaListadosGeneral(CamposVentas, nombre);
                    x.ShowDialog();
                    break;
                case "PagoEmpleados":
                    x = new PantallaListadosGeneral(CamposPagoEmpleados, nombre);
                    x.ShowDialog();
                    break;
                case "Nodo1": //FechaInicial, FechaFina
                    Consulta1 c1 = new Consulta1();
                    c1.SetParameterValue("@FechaInicial", v.FormatoFecha(dtFechaDesde.Value));
                    c1.SetParameterValue("@FechaFinal", v.FormatoFecha(dtFechaHasta.Value));
                    c1.SetDatabaseLogon("AdminDD", "Admin123123", "Rebeater.Database.Windows.Net", "DiamondDentures");

                    crystalReportViewer1.ReportSource = c1;

                    break;

                case "Nodo2": //FechaInicial, FechaFina
                    Consulta2 c2 = new Consulta2();
                    c2.SetParameterValue("@FechaInicial", v.FormatoFecha(dtFechaDesde.Value));
                    c2.SetParameterValue("@FechaFinal", v.FormatoFecha(dtFechaHasta.Value));
                    c2.SetDatabaseLogon("AdminDD", "Admin123123", "Rebeater.Database.Windows.Net", "DiamondDentures");
                    crystalReportViewer1.ReportSource = c2;
                    break;
                case "Nodo3":
                    Consulta3 c3 = new Consulta3();
                    c3.SetDatabaseLogon("AdminDD", "Admin123123", "Rebeater.Database.Windows.Net", "DiamondDentures");
                    crystalReportViewer1.ReportSource = c3;
                    break;
                case "Nodo4":
                    Consulta4 c4 = new Consulta4();
                    c4.SetDatabaseLogon("AdminDD", "Admin123123", "Rebeater.Database.Windows.Net", "DiamondDentures");
                    crystalReportViewer1.ReportSource = c4;
                    break;
                case "Nodo5": //FechaInicial, FechaFina
                    Consulta5 c5 = new Consulta5();
                    c5.SetParameterValue("@FechaInicial", v.FormatoFecha(dtFechaDesde.Value));
                    c5.SetParameterValue("@FechaFinal", v.FormatoFecha(dtFechaHasta.Value));
                    c5.SetDatabaseLogon("AdminDD", "Admin123123", "Rebeater.Database.Windows.Net", "DiamondDentures");
                    crystalReportViewer1.ReportSource = c5;
                    break;
                case "Nodo6":
                    Consulta6 c6 = new Consulta6();
                    c6.SetDatabaseLogon("AdminDD", "Admin123123", "Rebeater.Database.Windows.Net", "DiamondDentures");
                    crystalReportViewer1.ReportSource = c6;
                    break;
                case "Nodo7": //FechaInicial, FechaFina
                    Consulta7 c7 = new Consulta7();
                    c7.SetParameterValue("@FechaInicial", v.FormatoFecha(dtFechaDesde.Value));
                    c7.SetParameterValue("@FechaFinal", v.FormatoFecha(dtFechaHasta.Value));
                    c7.SetDatabaseLogon("AdminDD", "Admin123123", "Rebeater.Database.Windows.Net", "DiamondDentures");
                    crystalReportViewer1.ReportSource = c7;
                    break;
                case "Nodo8": //FechaInicial, FechaFina
                    Consulta8 c8 = new Consulta8();
                    c8.SetParameterValue("@FechaInicial", v.FormatoFecha(dtFechaDesde.Value));
                    c8.SetParameterValue("@FechaFinal", v.FormatoFecha(dtFechaHasta.Value));
                    c8.SetDatabaseLogon("AdminDD", "Admin123123", "Rebeater.Database.Windows.Net", "DiamondDentures");
                    crystalReportViewer1.ReportSource = c8;
                    break;
                case "Nodo9":
                    Consulta9 c9 = new Consulta9();
                    c9.SetDatabaseLogon("AdminDD", "Admin123123", "Rebeater.Database.Windows.Net", "DiamondDentures");
                    crystalReportViewer1.ReportSource = c9;
                    break;
                case "Nodo10":
                    Consulta10 c10 = new Consulta10();
                    c10.SetDatabaseLogon("AdminDD", "Admin123123", "Rebeater.Database.Windows.Net", "DiamondDentures");
                    crystalReportViewer1.ReportSource = c10;
                    break;
                case "Nodo11":
                    Consulta11 c11 = new Consulta11();
                    c11.SetDatabaseLogon("AdminDD", "Admin123123", "Rebeater.Database.Windows.Net", "DiamondDentures");
                    crystalReportViewer1.ReportSource = c11;
                    break;
                case "Nodo12":
                    Consulta12 c12 = new Consulta12();
                    c12.SetDatabaseLogon("AdminDD", "Admin123123", "Rebeater.Database.Windows.Net", "DiamondDentures");
                    crystalReportViewer1.ReportSource = c12;
                    break;
                case "Nodo13":
                    Consulta13 c13 = new Consulta13();
                    c13.SetDatabaseLogon("AdminDD", "Admin123123", "Rebeater.Database.Windows.Net", "DiamondDentures");
                    crystalReportViewer1.ReportSource = c13;
                    break;
                case "Nodo14":
                    Consulta14 c14 = new Consulta14();
                    c14.SetDatabaseLogon("AdminDD", "Admin123123", "Rebeater.Database.Windows.Net", "DiamondDentures");
                    crystalReportViewer1.ReportSource = c14;
                    break;
                case "Nodo15": //FechaInicial, FechaFina
                    Consulta15 c15 = new Consulta15();
                    c15.SetParameterValue("@Desde", v.FormatoFecha(dtFechaDesde.Value));
                    c15.SetParameterValue("@Hasta", v.FormatoFecha(dtFechaHasta.Value));
                    c15.SetDatabaseLogon("AdminDD", "Admin123123", "Rebeater.Database.Windows.Net", "DiamondDentures");
                    crystalReportViewer1.ReportSource = c15;
                    break;
                case "Nodo16":
                    Consulta16 c16 = new Consulta16();
                    c16.SetDatabaseLogon("AdminDD", "Admin123123", "Rebeater.Database.Windows.Net", "DiamondDentures");
                    crystalReportViewer1.ReportSource = c16;
                    break;
                case "Nodo17":
                    Consulta17 c17 = new Consulta17();
                    c17.SetDatabaseLogon("AdminDD", "Admin123123", "Rebeater.Database.Windows.Net", "DiamondDentures");
                    crystalReportViewer1.ReportSource = c17;
                    break;
                case "Nodo18":
                    Consulta18 c18 = new Consulta18();
                    c18.SetDatabaseLogon("AdminDD", "Admin123123", "Rebeater.Database.Windows.Net", "DiamondDentures");
                    crystalReportViewer1.ReportSource = c18;
                    break;
                case "Nodo19":
                    Consulta19 c19 = new Consulta19();
                    c19.SetDatabaseLogon("AdminDD", "Admin123123", "Rebeater.Database.Windows.Net", "DiamondDentures");
                    crystalReportViewer1.ReportSource = c19;
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
        }

        private void pBSalir_Click_1(object sender, EventArgs e)
        {
            ReportesAlmacen frm = new ReportesAlmacen(this);
            intusuario.desplegarPantalla(frm);
            intusuario.cerrarPantalla(this);
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            SeleccionarNodo(e.Node.Name);
        }
    }
}
