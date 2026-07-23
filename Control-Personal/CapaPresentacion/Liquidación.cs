using System;
using System.Linq;
using System.Windows.Forms;
using Control_Personal.CapaNegocios;
using Control_Personal.Entidades;
using System.Drawing;

namespace Control_Personal.CapaPresentacion
{
    public partial class Liquidación : Form
    {
        private N_Empleado objEmpleado = new N_Empleado();
        private N_Liquidacion objLiquidacion = new N_Liquidacion();
        private Empleado empleadoActual = null;

        public Liquidación()
        {
            InitializeComponent();
        }

        private void Liquidación_Load(object sender, EventArgs e)
        {
            cb_criterio.SelectedIndex = 0;
            cb_motivo.SelectedIndex = 0;
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

            if (criterio == "Cédula")
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
                tb_sueldo.Text = empleadoActual.Sueldo.ToString("0.00");
                tb_ingreso.Text = empleadoActual.FechaIngreso.ToString("dd/MM/yyyy");
                
                // Limpiar resultados anteriores
                LimpiarResultados();
            }
            else
            {
                MessageBox.Show("Empleado no encontrado o no está Activo.");
                LimpiarTodo();
            }
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            if (empleadoActual == null)
            {
                MessageBox.Show("Busque un empleado primero.");
                return;
            }

            DateTime fechaSalida = dtp_salida.Value;
            if (fechaSalida < empleadoActual.FechaIngreso)
            {
                MessageBox.Show("La fecha de salida no puede ser anterior a la fecha de ingreso.");
                return;
            }

            string motivo = cb_motivo.SelectedItem.ToString();
            
            try
            {
                var resultados = objLiquidacion.Calcular(empleadoActual.Sueldo, empleadoActual.FechaIngreso, fechaSalida, motivo);
                
                tb_anios.Text = resultados.AniosServicio.ToString();
                tb_dias.Text = resultados.DiasLaboradosTotales.ToString();
                
                tb_decimo3.Text = resultados.DecimoTercero.ToString("0.00");
                tb_decimo4.Text = resultados.DecimoCuarto.ToString("0.00");
                tb_vacaciones.Text = resultados.Vacaciones.ToString("0.00");
                tb_desahucio.Text = resultados.Desahucio.ToString("0.00");
                tb_despido.Text = resultados.DespidoIntempestivo.ToString("0.00");
                tb_iess.Text = resultados.AporteIESSProporcional.ToString("0.00");
                
                tb_total.Text = resultados.TotalLiquidacion.ToString("0.00");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al calcular: " + ex.Message);
            }
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
            tb_sueldo.Text = "";
            tb_ingreso.Text = "";
            
            dtp_salida.Value = DateTime.Now;
            cb_motivo.SelectedIndex = 0;

            LimpiarResultados();
        }

        private void LimpiarResultados()
        {
            tb_anios.Text = "0";
            tb_dias.Text = "0";
            
            tb_decimo3.Text = "0.00";
            tb_decimo4.Text = "0.00";
            tb_vacaciones.Text = "0.00";
            tb_desahucio.Text = "0.00";
            tb_despido.Text = "0.00";
            tb_iess.Text = "0.00";
            
            tb_total.Text = "0.00";
    }

        private void btn_cerrar_global_Click(object sender, EventArgs e)
        {
            this.Close();
        }}
}
