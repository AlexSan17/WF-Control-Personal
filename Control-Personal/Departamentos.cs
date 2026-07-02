using System;
using System.Linq;
using System.Windows.Forms;

namespace Control_Personal
{
    public partial class Departamentos : Form
    {
        public Departamentos()
        {
            InitializeComponent();
            ConfigurarFormulario();
            MostrarPersonalPorDepartamento();
        }

        private void ConfigurarFormulario()
        {
            dgv_empleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_empleados.ReadOnly = true;
            dgv_empleados.AllowUserToAddRows = false;
            dgv_empleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void MostrarPersonalPorDepartamento()
        {
            if (Datos.ListaEmpleados.Count == 0)
            {
                dgv_empleados.Columns.Clear();
                dgv_empleados.DataSource = null;

                MessageBox.Show(
                    "No hay empleados registrados.",
                    "Personal por departamento",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                return;
            }

            var reporte = Datos.ListaEmpleados
                .GroupBy(emp => string.IsNullOrWhiteSpace(emp.Departamento) ? "Sin departamento" : emp.Departamento)
                .Select(grupo => new
                {
                    Departamento = grupo.Key,
                    TotalEmpleados = grupo.Count(),
                    Activos = grupo.Count(emp => emp.Estado != null && emp.Estado.Trim().ToLower() == "activo"),
                    Inactivos = grupo.Count(emp => emp.Estado != null && emp.Estado.Trim().ToLower() == "inactivo"),
                    PromedioSueldo = grupo.Average(emp => emp.Sueldo)
                })
                .ToList();

            dgv_empleados.Columns.Clear();
            dgv_empleados.DataSource = null;
            dgv_empleados.DataSource = reporte;
        }

        private void dgv_empleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Departamentos_Load(object sender, EventArgs e)
        {
            MostrarPersonalPorDepartamento();
        }
    }
}