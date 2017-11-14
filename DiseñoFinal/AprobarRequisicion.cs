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
            txt_Fecha.Text = requisicion.Fecha.ToShortDateString();
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
            lbl_Presupuesto.Text = (total <= manejadorBanco.GetSaldoEnBanco()) ? "COMPRA DENTRO DEL PRESUEPUESTO" : "COMPRA FUERA DEL PRESUPUESTO";

            if (requisicion.Surtido == "SI" && requisicion.Estado == "AUTORIZADO")
            {
                button1.Enabled = false;
                button2.Enabled = true;
            }
            else if (requisicion.Surtido == "NO" && requisicion.Estado == "EN ESPERA")
            {
                button1.Enabled = true;
                button2.Enabled = false;
            }
            else {
                button1.Enabled = false;
                button2.Enabled = false;
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
                button1.Enabled = false;
            }
        }
    }
}
