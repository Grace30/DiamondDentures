using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    
namespace Entidad
{
    public class Requisicion
    {
        public Requisicion(int idRequisicion, string departamento, string solicitante, DateTime fecha, string surtido, string estado, Material[] items)
        {
            IdRequisicion = idRequisicion;
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
        public DateTime Fecha { get; set; }
        public string Surtido { get; set; }
        public string Estado { get; set; }
        public Material[] Items { get; set; }

    }
}
