using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
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
    public partial class ListadosPersonalizados : Form
    {
        protected CheckBox[] Checks { get; set; }
        protected Button Holiwis { get; set; }
        protected string connString = "Server=tcp:rebeater.database.windows.net,1433;Initial Catalog=DiamondDentures;User ID=Rebeater@rebeater.database.windows.net;Password=Eber123123;Provider=SQLNCLI10";
        public ListadosPersonalizados()
        {
            InitializeComponent();
        }

        protected void CargarChecks(string[,] Params)
        {
            Checks = new CheckBox[Params.GetLength(0)];
            int px = 18, py = 32;
            for (int i = 0; i < Checks.Length; i++)
            {
                CheckBox x = Checks[i] = new CheckBox();
                x.Name = Params[i, 0];
                x.Text = Params[i, 1] == "" ? x.Name : Params[i, 1];
                x.Location = new Point(px, py);
                x.TextAlign = ContentAlignment.MiddleLeft;
                x.CheckState = CheckState.Checked;
                x.AutoSize = true;
                py += 23;
                groupBox1.Controls.Add(x);
            }
            Holiwis = new Button();
            Holiwis.Text = "Cargar Reporte";
            Holiwis.TextAlign = ContentAlignment.MiddleCenter;
            Holiwis.Size = new Size(100, 30);
            Holiwis.Location = new Point(px, py);
            groupBox1.Controls.Add(Holiwis);
        }

        protected string CreateSelectQueryAndParameters(string NombreTabla)
        {
            ReportDocument reportDocument;
            ParameterFields paramFields;

            ParameterField paramField;
            ParameterDiscreteValue paramDiscreteValue;

            reportDocument = new ReportDocument();
            paramFields = new ParameterFields();

            string query = "SELECT ";
            int columnNo = 0;

            for (int i = 0; i < Checks.Length; i++)
            {
                if (Checks[i].Checked)
                {
                    columnNo++;
                    if (query.Contains("Column"))
                        query = query.Insert(query.Length, ", ");
                    query = query.Insert(query.Length, Checks[i].Name + " as Column" + columnNo.ToString());
                    paramField = new ParameterField();
                    paramField.Name = "col" + columnNo.ToString();
                    paramDiscreteValue = new ParameterDiscreteValue();
                    paramDiscreteValue.Value = Checks[i].Name;
                    paramField.CurrentValues.Add(paramDiscreteValue);
                    //Add the paramField to paramFields
                    paramFields.Add(paramField);
                }
            }

            //if there is any remaining parameter, assign empty value for that 
            //parameter.
            for (int i = columnNo; i < 23; i++)
            {
                columnNo++;
                paramField = new ParameterField();
                paramField.Name = "col" + columnNo.ToString();
                paramDiscreteValue = new ParameterDiscreteValue();
                paramDiscreteValue.Value = "";
                paramField.CurrentValues.Add(paramDiscreteValue);
                //Add the paramField to paramFields
                paramFields.Add(paramField);
            }

            crystalReportViewer1.ParameterFieldInfo = paramFields;
            query += " FROM " + NombreTabla;
            return query;
        }
    }
}