using entidadesimprenta;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace sistema_imprenta
{
    public partial class Factura : Form
    {
        public Factura()
        {
            InitializeComponent();
        }

        Producto ProductoN;
        BindingList<DetalleFactura> Detalles = new BindingList<DetalleFactura>();
        Facturacion FacturaProgram = new Facturacion();

        decimal isv = 0;
        decimal descuento = 0;
        decimal subtotal = 0;
        decimal total = 0;


        private void CantidadtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                ProductoN = new Producto(ProductotextBox.Text, DetalleProductotextBox.Text, 15, 250);

                DetalleFactura Detail = new DetalleFactura();

                Detail.CodigoProducto = ProductoN.Productos;
                Detail.Id = ProductoN.DiasdeEntrega;
                Detail.Cantidad = Convert.ToInt32(CantidadtextBox.Text);
                Detail.Precio = ProductoN.Precio;
                Detail.Total = (ProductoN.Precio * Convert.ToInt32(CantidadtextBox.Text));

                
                isv = subtotal * 0.15M;
                subtotal += Detail.Total;
                total = subtotal + isv - descuento;

                Detalles.Add(Detail);

                FacturadataGridView.DataSource = null;
                FacturadataGridView.DataSource = Detalles;

                SubtotaltextBox.Text = subtotal.ToString("N2");
                ISVtextBox.Text = isv.ToString("N2");
                TotaltextBox.Text = total.ToString("N2");



                ProductotextBox.Clear();
                ClienteTextBox.Clear();
                DetalleProductotextBox.Clear();
                CantidadtextBox.Clear();
                ProductotextBox.Focus();


            }
        }

        private void Factura_Load(object sender, EventArgs e)
        {
            FacturadataGridView.DataSource = Detalles;
        }

        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
            
            TotaltextBox.Clear();
            SubtotaltextBox.Clear();
            ISVtextBox.Clear();
            DescuentotextBox.Clear();
            
            
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            ProductotextBox.Clear();
            ClienteTextBox.Clear();
            TotaltextBox.Clear();
            SubtotaltextBox.Clear();
            ISVtextBox.Clear();
            DescuentotextBox.Clear();
            DetalleProductotextBox.Clear();
            CantidadtextBox.Clear();
            
        }
    }
}
