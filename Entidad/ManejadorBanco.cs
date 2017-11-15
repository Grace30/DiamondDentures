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

        public void InsertRetiro(string loginn, double Cantidad)
        {
            IbaseDatos.IngresarCompra(loginn, "Corrección",new Requisicion(0,"",new DateTime(),"","",new DateTime(),"","",null,Cantidad));
        }

        public int InsertIngreso(string loginn, double Cantidad)
        {
            return IbaseDatos.InsertIngreso(loginn, Cantidad);


        }

        public double getSaldoEnCajaConta()
        {
            return IbaseDatos.getSaldoCajaConta();
        }
    }
}
