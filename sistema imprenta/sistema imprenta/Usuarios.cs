using entidadesimprenta;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace sistema_imprenta
{
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }

        string operacion = string.Empty;
        BindingList<Usuario> Listausuarios = new BindingList<Usuario>();
        Usuario user;
        private void ListarUsuarios()
        {
            UsuariosdataGridView.DataSource = null;
            UsuariosdataGridView.DataSource = Listausuarios;
        }
        private void HabilitarControles()
        {
            CodigotextBox.Enabled = true;
            NombretextBox.Enabled = true;
            ClavetextBox.Enabled = true;
            CorretextBox.Enabled = true;
            TelefonotextBox.Enabled = true;
        }
        private void LimpiarControles()
        {
            CodigotextBox.Clear();
            NombretextBox.Clear();
            ClavetextBox.Clear();
            CorretextBox.Clear();
            TelefonotextBox.Clear();
        }
        private void DesahabilitarControles()
        {
            CodigotextBox.Enabled = false;
            NombretextBox.Enabled = false;
            ClavetextBox.Enabled = false;
            CorretextBox.Enabled = false;
            TelefonotextBox.Enabled = false;
        }
        private void Usuario_Load(object sender, EventArgs e)
        {
            ListarUsuarios();
        }

        private void Aceptarbutton_Click(object sender, EventArgs e)
        {
            HabilitarControles();
            operacion = "Nuevo";
            LimpiarControles();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (CodigotextBox.Text == String.Empty)
            {
                errorProvider1.SetError(CodigotextBox, "Ingrese el Codigo");
                CodigotextBox.Focus();
                return;
            }
            if (NombretextBox.Text == String.Empty)
            {
                errorProvider1.SetError(NombretextBox, "Ingrese un Nombre");
                CodigotextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            user = new Usuario();
            user.codigo = CodigotextBox.Text;
            user.Nombre = NombretextBox.Text;
            user.Clave = ClavetextBox.Text;
            user.Correo = CorretextBox.Text;
            user.Telefono = TelefonotextBox.Text;
            if (operacion == "Nuevo")
            {
                Listausuarios.Add(user);
                ListarUsuarios();
                LimpiarControles();
                DesahabilitarControles();
            }
            else if (operacion == "Modificar")
            {
                foreach (var item in Listausuarios)
                {
                    if (item.codigo == CodigotextBox.Text)
                    {
                        item.Nombre = NombretextBox.Text;
                        item.Clave = ClavetextBox.Text;
                        item.Correo = CorretextBox.Text;
                        item.Telefono = TelefonotextBox.Text;
                    }
                }
                ListarUsuarios();
                LimpiarControles();
                DesahabilitarControles();
            }
        }

        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
            DesahabilitarControles();
            LimpiarControles();
        }

        private void Modificarbutton_Click(object sender, EventArgs e)
        {

            if (UsuariosdataGridView.SelectedRows.Count > 0)
            {
                operacion = "modificar";
                HabilitarControles();
                CodigotextBox.Enabled = false;
                CodigotextBox.Text = UsuariosdataGridView.CurrentRow.Cells["Codigo"].Value.ToString();
                NombretextBox.Text = UsuariosdataGridView.CurrentRow.Cells["Nombre"].Value.ToString();
                ClavetextBox.Text = UsuariosdataGridView.CurrentRow.Cells["Clave"].Value.ToString();
                CorretextBox.Text = UsuariosdataGridView.CurrentRow.Cells["Correo"].Value.ToString();
                TelefonotextBox.Text = UsuariosdataGridView.CurrentRow.Cells["Correo"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Debe Seleccionar un registro", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (UsuariosdataGridView.SelectedRows.Count > 0)
            {
                foreach (var user in Listausuarios)
                    if (user.codigo == UsuariosdataGridView.CurrentRow.Cells["Codigo"].Value.ToString())
                    {
                        Listausuarios.Remove(user);
                        break;
                    }

            }
            ListarUsuarios();
        }
    }
}