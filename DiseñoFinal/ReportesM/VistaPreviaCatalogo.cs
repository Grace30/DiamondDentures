﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiseñoFinal.ReportesM.Reportes;

namespace DiseñoFinal.ReportesM
{
    public partial class VistaPreviaCatalogo : SuperVistaPrevia
    {
        public VistaPreviaCatalogo()
        {
            InitializeComponent();
        }

        private void VGeneral_Load(object sender, EventArgs e)
        {
            ReporteCatalogoProductos rcp = new ReporteCatalogoProductos();
            rcp.SetDatabaseLogon("AdminDD", "Admin123123", "Rebeater.Database.Windows.Net", "DiamondDentures");
            VGeneral.ReportSource = rcp;
        }
    }
}
