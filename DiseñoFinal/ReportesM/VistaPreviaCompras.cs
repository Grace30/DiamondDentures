﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiseñoFinal.ReportesM
{
    public partial class VistaPreviaCompras : SuperVistaPrevia
    {
        ReporteCompras objReport = new ReporteCompras();
        public VistaPreviaCompras()
        {
            InitializeComponent();
            VGeneral.ReportSource = objReport;
        }
    }
}
