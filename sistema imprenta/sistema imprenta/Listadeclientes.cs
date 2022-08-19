using entidadesimprenta;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace sistema_imprenta
{
    public partial class Listadeclientes : Form
    {
        public Listadeclientes()
        {
            InitializeComponent();

        }

        string operation = string.Empty;

        BindingList<Clientes> ListaClientes = new BindingList<Clientes>();
        Clientes Client;

        private void LimpiarBotones()
        {
            NombretextBox.Clear();
            CorreotextBox.Clear();
            TeletextBox.Clear();
        }
        private void DeshabilitarBotones()
        {
            NombretextBox.Enabled = false;
            CorreotextBox.Enabled = false;
            TeletextBox.Enabled = false;
        }
        private void HabilitarBotones()
        {
            NombretextBox.Enabled = true;
            CorreotextBox.Enabled = true;
            TeletextBox.Enabled = true;


        }
        private void ListarClientes()
        {
            ClientesdataGridView.DataSource = ListaClientes;
        }
        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            HabilitarBotones();
            operation = "Nuevo";
        }

        private void Listadeclientes_Load(object sender, EventArgs e)
        {
            ListarClientes();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(NombretextBox.Text))
            {
                errorProvider1.SetError(NombretextBox, "Ingrese el nombre");
                NombretextBox.Focus();
                return;
            }
            if (string.IsNullOrEmpty(CorreotextBox.Text))
            {
                errorProvider1.SetError(CorreotextBox, "Ingrese el nombre");
                CorreotextBox.Focus();
                return;
            }
            if (string.IsNullOrEmpty(TeletextBox.Text))
            {
                errorProvider1.SetError(TeletextBox, "Ingrese el nombre");
                TeletextBox.Focus();
                return;
            }

            // Crear Objeto clase  cliente
            Client = new Clientes();
            Client.Nombre = NombretextBox.Text;
            Client.Correo = CorreotextBox.Text;
            Client.Telefono = TeletextBox.Text;

            if (operation == "Nuevo")
            {
                ListaClientes.Add(Client);
                ListarClientes();

                LimpiarBotones();
                DeshabilitarBotones();

            }
            else if (operation == "Modificar")
            {
                foreach (var item in ListaClientes)
                {
                    if (item.Nombre == NombretextBox.Text)
                    {
                        item.Correo = CorreotextBox.Text;
                        item.Telefono = TeletextBox.Text;
                    }
                }
                ListarClientes();
                LimpiarBotones();
                DeshabilitarBotones();
            }

        }

        private void TeletextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CorreotextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NombretextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Modificarbutton_Click(object sender, EventArgs e)
        {

            if (ClientesdataGridView.SelectedRows.Count > 0)
            {
                operation = "Modificar";
                TeletextBox.Text = ClientesdataGridView.CurrentRow.Cells["Telefono"].Value.ToString();
                CorreotextBox.Text = ClientesdataGridView.CurrentRow.Cells["Correo"].Value.ToString();
                NombretextBox.Text = ClientesdataGridView.CurrentRow.Cells["Nombre"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Debe selecionar un registro", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (ClientesdataGridView.SelectedRows.Count > 0)
            {
                foreach (var item in ListaClientes)
                {
                    if (item.Nombre == ClientesdataGridView.CurrentRow.Cells["Nombre"].Value.ToString())
                    {
                        ListaClientes.Remove(item);
                        break;
                    }
                }
            }
            ListarClientes();
        }
    }
}
