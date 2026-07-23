using System;
using System.Linq;
using System.Windows.Forms;
using Control_Personal.CapaNegocios;
using Control_Personal.Entidades;

namespace Control_Personal.CapaPresentacion
{
    public partial class Form2 : Form
    {
        private N_Empleado objEmpleado = new N_Empleado();
        private N_RolPago objRol = new N_RolPago();
        private Empleado empleadoActual = null;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cb_criterio.SelectedIndex = 0;
            LimpiarTodo();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string busqueda = tb_buscar.Text.Trim().ToLower();
            string criterio = cb_criterio.SelectedItem.ToString();

            if (string.IsNullOrWhiteSpace(busqueda))
            {
                MessageBox.Show("Ingrese un valor para buscar.");
                return;
            }

            var empleados = objEmpleado.Listar().Where(emp => emp.Estado != null && emp.Estado.Trim().ToLower() == "activo");

            if (criterio == "Cédula" || criterio == "Cedula")
                empleadoActual = empleados.FirstOrDefault(x => x.Cedula != null && x.Cedula.ToLower().Contains(busqueda));
            else if (criterio == "Nombre")
                empleadoActual = empleados.FirstOrDefault(x => x.Nombres != null && x.Nombres.ToLower().Contains(busqueda));
            else if (criterio == "Apellido")
                empleadoActual = empleados.FirstOrDefault(x => x.Apellidos != null && x.Apellidos.ToLower().Contains(busqueda));

            if (empleadoActual != null)
            {
                tb_nombres.Text = empleadoActual.Nombres + " " + empleadoActual.Apellidos;
                tb_cargo.Text = empleadoActual.Cargo;
                tb_departamento.Text = empleadoActual.Departamento;
                
                int diasTrabajados = (DateTime.Now - empleadoActual.FechaIngreso).Days;
                if (diasTrabajados < 0) diasTrabajados = 0;
                tb_dias.Text = diasTrabajados.ToString();

                tb_sueldo_base.Text = empleadoActual.Sueldo.ToString("0.00");
                
                // Limpiar los valores editables para calcular nuevo rol
                tb_horas_extras.Text = "0.00";
                tb_anticipos.Text = "0.00";
                
                RealizarCalculos();
            }
            else
            {
                MessageBox.Show("Empleado no encontrado.");
                LimpiarTodo();
            }
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            RealizarCalculos();
        }

        private void RealizarCalculos()
        {
            if (empleadoActual == null) return;

            decimal sueldoBase = empleadoActual.Sueldo;
            decimal horasExtras = 0;
            decimal anticipos = 0;

            if (!decimal.TryParse(tb_horas_extras.Text, out horasExtras)) horasExtras = 0;
            if (!decimal.TryParse(tb_anticipos.Text, out anticipos)) anticipos = 0;

            tb_horas_extras.Text = horasExtras.ToString("0.00");
            tb_anticipos.Text = anticipos.ToString("0.00");

            decimal totalIngresos = sueldoBase + horasExtras;
            tb_total_ingresos.Text = totalIngresos.ToString("0.00");

            decimal iess = objRol.CalcularIESS(sueldoBase, horasExtras);
            tb_iess.Text = iess.ToString("0.00");

            decimal totalEgresos = iess + anticipos;
            tb_total_egresos.Text = totalEgresos.ToString("0.00");

            decimal liquido = objRol.CalcularLiquidoAPagar(sueldoBase, horasExtras, iess, anticipos);
            tb_liquido.Text = liquido.ToString("0.00");
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            LimpiarTodo();
        }

        private void LimpiarTodo()
        {
            empleadoActual = null;
            tb_buscar.Text = "";
            
            tb_nombres.Text = "";
            tb_cargo.Text = "";
            tb_departamento.Text = "";
            tb_dias.Text = "";
            
            tb_sueldo_base.Text = "0.00";
            tb_horas_extras.Text = "0.00";
            tb_total_ingresos.Text = "0.00";
            
            tb_iess.Text = "0.00";
            tb_anticipos.Text = "0.00";
            tb_total_egresos.Text = "0.00";
            
            tb_liquido.Text = "0.00";
        }
    
        private void btn_cerrar_global_Click(object sender, EventArgs e)
        {
            this.Close();
        }}
}
