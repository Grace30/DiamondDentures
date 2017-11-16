using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    
namespace Entidad
{
    public class Requisicion
    {
        public Requisicion(int idRequisicion, string proveedor, DateTime fechaSurtido, string departamento, string solicitante, DateTime fecha, string surtido, string estado, Material[] items, double total)
        {
            IdRequisicion = idRequisicion;
            Proveedor = proveedor;
            FechaSurtido = fechaSurtido;
            Total = total;
            Departamento = departamento;
            Solicitante = solicitante;
            Fecha = fecha;
            Surtido = surtido;
            Estado = estado;
            Items = items;
        }

        public Requisicion()
        {
            IdRequisicion = 0;
            Proveedor = null;
            FechaSurtido = new DateTime();
            Total = 0;
            Departamento = null;
            Solicitante = null;
            Fecha = new DateTime();
            Surtido = null;
            Estado = null;
            Items = null;
        }

        public int  IdRequisicion { get; set; }
        public string Departamento { get; set; }
        public string Solicitante { get; set; }
        public DateTime? Fecha { get; set; }
        public string Surtido { get; set; }
        public string Estado { get; set; }
        public double Total { get; set; }
        public string Proveedor { get; set; }
        public DateTime? FechaSurtido { get; set; }
        public Material[] Items { get; set; }
        

    }
}
