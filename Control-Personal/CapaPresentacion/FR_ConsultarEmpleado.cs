using Control_Personal.CapaDatos;
using Control_Personal.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Control_Personal.CapaNegocios;

namespace Control_Personal.CapaPresentacion
{
    public partial class FR_ConsultarEmpleado : Form
    {
        private N_Empleado objNegocio = new N_Empleado();

        public FR_ConsultarEmpleado()
        {
            InitializeComponent();
            ConfigurarFormulario();
        }
        private void solo_Letras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Por favor, ingrese solo letras.");
            }
        }
        private void solo_Numeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                MessageBox.Show("Por favor, ingrese solo números.");
            }

        }
        private void solo_Decimales_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
                MessageBox.Show("Por favor, ingrese solo números decimales.");
            }
            if (sender is TextBox textBox && e.KeyChar == '.' && textBox.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
                MessageBox.Show("Solo se permite un punto decimal.");
            }
        }
        private void ConfigurarFormulario()
        {
            cb_criterio.Items.Clear();

            cb_criterio.Items.Add("Código");
            cb_criterio.Items.Add("Cédula");
            cb_criterio.Items.Add("Nombre");
            cb_criterio.Items.Add("Apellido");
            cb_criterio.Items.Add("Departamento");

            cb_criterio.SelectedIndex = 0;

            dgv_empleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_empleados.ReadOnly = true;
            dgv_empleados.AllowUserToAddRows = false;
            dgv_empleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

       

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string criterio = cb_criterio.Text;
            string busqueda = tb_buscar.Text.Trim();

            if (busqueda == "")
            {
                MessageBox.Show("Ingrese un dato para buscar.");
                tb_buscar.Focus();
                return;
            }

            List<Empleado> resultado = objNegocio.Consultar(criterio, busqueda);

            if (resultado.Count == 0)
            {
                MessageBox.Show("No se encontraron empleados con ese criterio.");
            }

            dgv_empleados.Columns.Clear();
            dgv_empleados.DataSource = resultado;
        }

        private void btn_mostrar_todos_Click(object sender, EventArgs e)
        {
            tb_buscar.Clear();
            cb_criterio.SelectedIndex = 0;
            dgv_empleados.Columns.Clear();
            dgv_empleados.DataSource = objNegocio.Listar();
        }

        // Este método soluciona el error:
        // "FR_ConsultarEmpleado_Load no existe en el contexto actual"
        private void FR_ConsultarEmpleado_Load(object sender, EventArgs e)
        {

        }

        // Este método soluciona el error:
        // "comboBox1_SelectedIndexChanged no existe en el contexto actual"
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_criterio.SelectedItem == null)
            {
                return;
            }
            tb_buscar.KeyPress -= solo_Numeros_KeyPress;
            tb_buscar.KeyPress -= solo_Letras_KeyPress;
            tb_buscar.Clear();

            string opcionSeleccionada = cb_criterio.SelectedItem.ToString();
            switch (opcionSeleccionada)
            {
                case "Código":
                    tb_buscar.KeyPress += solo_Numeros_KeyPress;
                    return;
                case "Cédula":
                    tb_buscar.KeyPress += solo_Numeros_KeyPress;
                    break;
                case "Nombre":
                    tb_buscar.KeyPress += solo_Letras_KeyPress;
                    break;
                case "Apellido":
                    tb_buscar.KeyPress += solo_Letras_KeyPress;
                    break;
                case "Departamento":
                    tb_buscar.KeyPress += solo_Letras_KeyPress;
                    break;
            }

        }

        private void lbl_criterio_Click(object sender, EventArgs e)
        {

        }

        private void tb_buscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgv_empleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_buscar_Click_1(object sender, EventArgs e)
        {
            btn_buscar_Click(sender, e);
        }

        private void btn_mostrar_todos_Click_1(object sender, EventArgs e)
        {
            btn_mostrar_todos_Click(sender, e);
        }
    
        private void btn_cerrar_global_Click(object sender, EventArgs e)
        {
            this.Close();
        }}
}
