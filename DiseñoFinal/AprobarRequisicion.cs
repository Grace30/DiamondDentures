using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidad;

namespace DiseñoFinal
{
    public partial class AprobarRequisicion : Form
    {
        ManejadorRequisicion manejadorRequisicion = new ManejadorRequisicion();
        Requisicion requisicion = new Requisicion();
        ManejadorBanco manejadorBanco = new ManejadorBanco(); 

        int idRequisicion;

        public AprobarRequisicion(int IdRequisicion)
        {
            InitializeComponent();
            idRequisicion = IdRequisicion;
        }

        private void AprobarRequisicion_Load(object sender, EventArgs e)
        {
            requisicion = manejadorRequisicion.getRequisicion(idRequisicion);
            txt_IDRequisicion.Text = requisicion.IdRequisicion.ToString();
            txt_Fecha.Text = ((DateTime)(requisicion.Fecha)).ToShortDateString();
            txt_Estado.Text = requisicion.Estado;
            txt_Departamento.Text = requisicion.Departamento;
            txt_Solicitante.Text = requisicion.Solicitante.TrimEnd();

            dataGridView1.RowCount = requisicion.Items.Length;
            double total = 0;
            for (int i = 0; i < requisicion.Items.Length; i++)
            {
                dataGridView1[0, i].Value = requisicion.Items[i].IDMaterial;
                dataGridView1[1, i].Value = requisicion.Items[i].Nombre;
                dataGridView1[2, i].Value = requisicion.Items[i].Descripcion;
                dataGridView1[3, i].Value = requisicion.Items[i].Proveedor;
                dataGridView1[4, i].Value = requisicion.Items[i].Unidad;
                dataGridView1[5, i].Value = requisicion.Items[i].Cantidad;
                dataGridView1[6, i].Value = requisicion.Items[i].CostoBase;
                dataGridView1[7, i].Value = requisicion.Items[i].Cantidad * requisicion.Items[i].CostoBase;
                total += Convert.ToDouble(dataGridView1[7, i].Value);
            }
            txt_Total.Text = total.ToString("c2", System.Globalization.CultureInfo.CurrentCulture);

           


            if (requisicion.Surtido == "SI" && requisicion.Estado == "AUTORIZADO")
            {
                btn_Autorizar.Enabled = false;
                btn_Pagar.Enabled = true;
            }
            else if (requisicion.Surtido == "NO" && requisicion.Estado == "EN ESPERA")
            {
                btn_Autorizar.Enabled = true;
                btn_Pagar.Enabled = false;
            }
            else {
                btn_Autorizar.Enabled = false;
                btn_Pagar.Enabled = false;
            }
            if (total <= manejadorBanco.GetSaldoEnBanco())
            {
                lbl_Presupuesto.Text = "COMPRA DENTRO DEL PRESUEPUESTO";
                lbl_Presupuesto.ForeColor = Color.DarkGreen;
            }
            else
            {
                lbl_Presupuesto.Text = "COMPRA FUERA DEL PRESUPUESTO";
                lbl_Presupuesto.ForeColor = Color.DarkRed;
                btn_Autorizar.Enabled = false;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(manejadorRequisicion.AutorizarRequisicion(Convert.ToInt32(txt_IDRequisicion.Text),Program.Loginn) > 0)
            {
                MessageBox.Show("Requisicion Autorizada");
                btn_Autorizar.Enabled = false;
            }
        }

        private void btn_Pagar_Click(object sender, EventArgs e)
        {
            Requisicion r = manejadorRequisicion.getRequisicion(Convert.ToInt32(txt_IDRequisicion.Text));
            string tipo = "";
            if (r.Items[0].IDMaterial[0] == 'I')
                tipo = "Insumo";
            else if (r.Items[0].IDMaterial[0] == 'M')
                tipo = "Material";


            if(manejadorRequisicion.Pagar(Program.Loginn, tipo, r) > 0)
            {
                MessageBox.Show("Pago a realizado");
            }
            else
            {
                MessageBox.Show("No se puede realizar el pago");
            }

        }

        private void lbl_Presupuesto_Click(object sender, EventArgs e)
        {

        }
    }
}
