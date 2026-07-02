using Control_Personal.CapaDatos;
using Control_Personal.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Control_Personal.CapaPresentacion
{
    public partial class Activo : Form
    {
        public Activo()
        {
            InitializeComponent();
            ConfigurarFormulario();
            MostrarEmpleadosActivos();
        }

        private void ConfigurarFormulario()
        {
            dgv_empleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_empleados.ReadOnly = true;
            dgv_empleados.AllowUserToAddRows = false;
            dgv_empleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void MostrarEmpleadosActivos()
        {
            List<Empleado> empleadosActivos = Datos.ListaEmpleados
                .Where(emp => emp.Estado != null && emp.Estado.Trim().ToLower() == "activo")
                .ToList();

            dgv_empleados.Columns.Clear();
            dgv_empleados.DataSource = null;

            dgv_empleados.DataSource = empleadosActivos.Select(emp => new
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

            if (empleadosActivos.Count == 0)
            {
                MessageBox.Show(
                    "No hay empleados activos registrados.",
                    "Personal activo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        private void dgv_empleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Activo_Load(object sender, EventArgs e)
        {
            MostrarEmpleadosActivos();
        }

        private void Activo_Load_1(object sender, EventArgs e)
        {

        }
    }
}
