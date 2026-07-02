using Control_Personal.CapaDatos;
using Control_Personal.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Control_Personal.CapaPresentacion
{
    public partial class FR_EliminarEmpleado : Form
    {
        public FR_EliminarEmpleado()
        {
            InitializeComponent();
            ConfigurarFormulario();
            MostrarEmpleados(Datos.ListaEmpleados);
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
            cb_criterio.DropDownStyle = ComboBoxStyle.DropDownList;

            dgv_empleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_empleados.ReadOnly = true;
            dgv_empleados.AllowUserToAddRows = false;
            dgv_empleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_empleados.MultiSelect = false;

            ConfigurarValidacionBusqueda();
        }

        private void MostrarEmpleados(List<Empleado> lista)
        {
            dgv_empleados.Columns.Clear();
            dgv_empleados.DataSource = null;

            dgv_empleados.DataSource = lista.Select(emp => new
            {
                emp.Codigo,
                emp.Cedula,
                emp.Nombres,
                emp.Apellidos,
                emp.Edad,
                emp.Sexo,
                emp.Direccion,
                emp.Telefono,
                emp.Correo,
                emp.Cargo,
                emp.Departamento,
                FechaIngreso = emp.FechaIngreso.ToShortDateString(),
                emp.Sueldo,
                emp.Estado
            }).ToList();
        }

        private void BuscarEmpleado()
        {
            string criterio = cb_criterio.Text;
            string busqueda = tb_buscar.Text.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(busqueda))
            {
                MessageBox.Show("Ingrese un dato para buscar.");
                tb_buscar.Focus();
                return;
            }

            List<Empleado> resultado = new List<Empleado>();

            if (criterio == "Código")
            {
                resultado = Datos.ListaEmpleados
                    .Where(emp => emp.Codigo != null && emp.Codigo.ToLower().Contains(busqueda))
                    .ToList();
            }
            else if (criterio == "Cédula")
            {
                resultado = Datos.ListaEmpleados
                    .Where(emp => emp.Cedula != null && emp.Cedula.ToLower().Contains(busqueda))
                    .ToList();
            }
            else if (criterio == "Nombre")
            {
                resultado = Datos.ListaEmpleados
                    .Where(emp => emp.Nombres != null && emp.Nombres.ToLower().Contains(busqueda))
                    .ToList();
            }
            else if (criterio == "Apellido")
            {
                resultado = Datos.ListaEmpleados
                    .Where(emp => emp.Apellidos != null && emp.Apellidos.ToLower().Contains(busqueda))
                    .ToList();
            }
            else if (criterio == "Departamento")
            {
                resultado = Datos.ListaEmpleados
                    .Where(emp => emp.Departamento != null && emp.Departamento.ToLower().Contains(busqueda))
                    .ToList();
            }

            if (resultado.Count == 0)
            {
                MessageBox.Show("No se encontraron empleados con ese criterio.");
            }

            MostrarEmpleados(resultado);
        }

        private void MostrarTodos()
        {
            MostrarEmpleados(Datos.ListaEmpleados);
            tb_buscar.Clear();
            cb_criterio.SelectedIndex = 0;
            tb_buscar.Focus();
        }

        private void EliminarEmpleadoSeleccionado()
        {
            if (dgv_empleados.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un empleado para eliminar.");
                return;
            }

            string codigo = dgv_empleados.CurrentRow.Cells["Codigo"].Value.ToString();

            Empleado empleadoEliminar = Datos.ListaEmpleados
                .FirstOrDefault(emp => emp.Codigo == codigo);

            if (empleadoEliminar == null)
            {
                MessageBox.Show("No se encontró el empleado seleccionado.");
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro de eliminar este empleado?\n\n" +
                "Código: " + empleadoEliminar.Codigo + "\n" +
                "Cédula: " + empleadoEliminar.Cedula + "\n" +
                "Empleado: " + empleadoEliminar.Nombres + " " + empleadoEliminar.Apellidos,
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (respuesta == DialogResult.No)
            {
                return;
            }

            Datos.ListaEmpleados.Remove(empleadoEliminar);

            MessageBox.Show(
                "Empleado eliminado correctamente.",
                "Eliminación exitosa",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            MostrarEmpleados(Datos.ListaEmpleados);
            tb_buscar.Clear();
            cb_criterio.SelectedIndex = 0;
        }

        private void ConfigurarValidacionBusqueda()
        {
            tb_buscar.KeyPress -= solo_Numeros_KeyPress;
            tb_buscar.KeyPress -= solo_Letras_KeyPress;
            tb_buscar.KeyPress -= solo_Decimales_KeyPress;

            if (cb_criterio.SelectedItem == null)
            {
                return;
            }

            string opcionSeleccionada = cb_criterio.SelectedItem.ToString();

            switch (opcionSeleccionada)
            {
                case "Código":
                case "Cédula":
                    tb_buscar.KeyPress += solo_Numeros_KeyPress;
                    break;

                case "Nombre":
                case "Apellido":
                case "Departamento":
                    tb_buscar.KeyPress += solo_Letras_KeyPress;
                    break;
            }
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
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
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
                return;
            }

            if (sender is TextBox textBox && e.KeyChar == '.' && textBox.Text.Contains("."))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permite un punto decimal.");
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            BuscarEmpleado();
        }

        private void btn_mostrar_todos_Click(object sender, EventArgs e)
        {
            MostrarTodos();
        }

        private void cb_criterio_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_buscar.Clear();
            ConfigurarValidacionBusqueda();
            tb_buscar.Focus();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_criterio_SelectedIndexChanged(sender, e);
        }

        private void btn_buscar_Click_1(object sender, EventArgs e)
        {
            BuscarEmpleado();
        }

        private void btn_buscar_Click_2(object sender, EventArgs e)
        {
            BuscarEmpleado();
        }

        private void btn_mostrar_todos_Click_1(object sender, EventArgs e)
        {
            MostrarTodos();
        }

        private void FR_ConsultarEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void lbl_criterio_Click(object sender, EventArgs e)
        {

        }

        private void lbl_criterio_Click_1(object sender, EventArgs e)
        {

        }

        private void tb_buscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgv_empleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_empleados_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
