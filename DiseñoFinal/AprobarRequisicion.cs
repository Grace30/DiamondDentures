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
            txt_Solicitante.Text = requisicion.Solicitante;

            dataGridView1.RowCount = requisicion.Items.Length;

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
            }

        }
    }
}
