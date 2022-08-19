using System;

namespace entidadesimprenta
{
    public class Facturacion
    {
        // Propiedades
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string Cliente { get; set; }
        public decimal ISV { get; set; }
        public decimal Descuento { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Total { get; set; }

        public Facturacion() { }

        public Facturacion(int id, DateTime fecha, string cliente, decimal iSV, decimal descuento, decimal subtotal, decimal total)
        {
            Id = id;
            Fecha = fecha;
            Cliente = cliente;
            ISV = iSV;
            Descuento = descuento;
            Subtotal = subtotal;
            Total = total;
        }

        public void Add(DetalleFactura detail)
        {
            throw new NotImplementedException();
        }
    }
}
