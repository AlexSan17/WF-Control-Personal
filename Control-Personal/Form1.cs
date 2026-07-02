using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Control_Personal
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

        private void personalPorDepartamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Departamentos>();
        }

        private void personalActivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Activo>();
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
    }
}