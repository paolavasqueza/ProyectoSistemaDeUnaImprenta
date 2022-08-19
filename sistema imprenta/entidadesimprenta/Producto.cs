namespace entidadesimprenta
{
    public class Producto
    {

        public string Cliente { get; set; }
        public string Productos { get; set; }
        public int tamaños { get; set; }

        public int Cantidad { get; set; }
        public int DiasdeEntrega { get; set; }
        public decimal Precio { get; set; }

        public Producto(string codigo, string nombre, int existencia, decimal precio)
        {
            Cliente = Cliente;
            Productos = Productos;
            tamaños = tamaños;
            Cantidad = Cantidad;
            DiasdeEntrega = DiasdeEntrega;
            Precio = precio;
        }

        public Producto()
        {
        }
    }
}
