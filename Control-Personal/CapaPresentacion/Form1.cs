using Control_Personal.CapaDatos;
using Control_Personal.Entidades;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Control_Personal.CapaPresentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AbrirFormulario<T>() where T : Form, new()
        {
            foreach (Form formulario in this.MdiChildren.ToArray())
            {
                formulario.Close();
            }

            T nuevoFormulario = new T();
            nuevoFormulario.MdiParent = this;
            nuevoFormulario.StartPosition = FormStartPosition.Manual;

            nuevoFormulario.Show();

            int x = (this.ClientSize.Width - nuevoFormulario.Width) / 2;
            int y = (this.ClientSize.Height - nuevoFormulario.Height) / 2;

            if (x < 0)
            {
                x = 0;
            }

            if (y < 0)
            {
                y = 0;
            }

            nuevoFormulario.Location = new Point(x, y);
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FR_RegistrarEmpleado>();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FR_ConsultarEmpleado>();
        }

        private void moficarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FR_ModificarEmpleado>();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FR_EliminarEmpleado>();
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void listadoGeneralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FR_Reportes>();
        }



        private void personalActivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var objNegocio = new Control_Personal.CapaNegocios.N_Empleado();
            int activos = objNegocio.Listar().Count(emp => emp.Estado != null && emp.Estado.Trim().ToLower() == "activo");

            if (activos == 0)
            {
                MessageBox.Show("No hay empleados activos registrados.", "Personal activo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Actualmente hay {activos} empleado(s) activo(s).", "Personal activo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void personalInactivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var objNegocio = new Control_Personal.CapaNegocios.N_Empleado();
            int inactivos = objNegocio.Listar().Count(emp => emp.Estado != null && emp.Estado.Trim().ToLower() == "inactivo");

            if (inactivos == 0)
            {
                MessageBox.Show("No hay empleados inactivos registrados.", "Personal inactivo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Actualmente hay {inactivos} empleado(s) inactivo(s).", "Personal inactivo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void salirDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Desea salir del sistema?",
                "Salir del sistema",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void beneficiosDelPersonalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FR_BeneficiosPersonal>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
