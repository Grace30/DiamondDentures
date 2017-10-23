using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Salario
    {
        public string usuario;
        public string salarioDiario;
        public string dias;
        public string pago;
        public Salario(string Usuario, string SalarioDiario, string Dias, string Pago)
        {
            usuario = Usuario;
            salarioDiario = SalarioDiario;
            dias = Dias;
            pago = Pago;
    }
        public Salario()
        {

        }
    }
}
