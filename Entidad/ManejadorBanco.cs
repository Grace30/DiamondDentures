using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;

namespace Entidad
{
   public class ManejadorBanco
    {
        ManejadorPrincipal Mprincipal = new ManejadorPrincipal();
        InterfaceBaseDeDatos IbaseDatos = new InterfaceBaseDeDatos();
        public ManejadorBanco()
        {
        }


        public object[] getAñoBalance()
        {
            return IbaseDatos.getAñoBalance();
        }

        public object[] getPeriodosBalance(int año)
        {
            return IbaseDatos.getPeriodosBalance(año);
        }

        public DataTable getBalance(DateTime Desde, DateTime Hasta)
        {
            return IbaseDatos.getBalance(Desde, Hasta);
        }

        public double GetSaldoEnBanco()
        {
            return IbaseDatos.GetSaldoEnBanco();
        }


        public double[] getTotalesBalance(DateTime Desde, DateTime Hasta)
        {
            return IbaseDatos.GetTotalesBalance(Desde, Hasta);
        }

        public void InsertRetiro(double Cantidad)
        {
            //IbaseDatos.InsertRetiro(Cantidad);
        }

        public void InsertIngreso(double Cantidad)
        {
            //IbaseDatos.InsertIngreso(Cantidad);

        }
    }
}
