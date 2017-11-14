using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Salario
    {
        public string mes;
        public string usuario;
        public string salarioDiario;
        public string dias;
        public string sueldo;
        public string tasaISR;
        public string cuotaISR;
        public string aPagar;
        public string idPago;
        public Salario(string Mes, string Usuario, string SalarioDiario, string Dias, string Sueldo, string TasaISR, string CuotaISR, string APagar, string IdPago)
        {
            mes = Mes;
            usuario = Usuario;
            salarioDiario = SalarioDiario;
            dias = Dias;
            aPagar = APagar;
            idPago = IdPago;
            sueldo = Sueldo;
            tasaISR = TasaISR;
            cuotaISR = CuotaISR;

    }
        public Salario()
        {

        }
    }
}
