namespace WebApplication1
{
    public class User
    {
        private int Id { get; set; }

        private string Nombre { get; set; }

        private string Apellido { get; set; }

        public string NombreUsuario { get; set; }

        public string Contraseņa { get; set; }

        public string Mail { get; set; }
    }
    public class Producto
    {
        private int Id { get; set; }

        private string Descripcion { get; set; }

        private int Costo { get; set; }

        public int PrecioVenta { get; set; }

        public int Stock { get; set; }

        public int IdUsuario { get; set; }
    }
    public class ProductoVendido
    {
        private int Id { get; set; }

        private int IdProducto { get; set; }

        private int Stock { get; set; }

        public int IdVenta { get; set; }
    }
    public class Venta
    {
        public int Id { get; set; }

        public string Comentarios { get; set; }

        public int IdUsuario { get; set; }
    }
}