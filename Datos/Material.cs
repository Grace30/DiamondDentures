namespace Entidad
{
    public class Material
    {

        public Material(string IDMaterial, string Nombre, string Descripcion, string Proveedor, string Unidad, int Cantidad, double CostoBase, double Importe)
        {
            this.IDMaterial = IDMaterial;
            this.Nombre = Nombre;
            this.Descripcion = Descripcion;
            this.Proveedor = Proveedor;
            this.Unidad = Unidad;
            this.Cantidad = Cantidad;
            this.CostoBase = CostoBase;
            this.Importe = Importe;
        }

        public string IDMaterial { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Proveedor { get; set; }
        public string Unidad { get; set; }
        public int  Cantidad { get; set; }
        public double CostoBase { get; set; }
        public double Importe { get; set; }


    }
}