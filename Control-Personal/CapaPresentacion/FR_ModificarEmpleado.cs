using Control_Personal.CapaDatos;
using Control_Personal.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System;
using System.Linq;
using System.Text.RegularExpressions;
using Control_Personal.CapaNegocios;

namespace Control_Personal.CapaPresentacion
{
    public partial class FR_ModificarEmpleado : Form
    {
        public FR_ModificarEmpleado()
        {
            InitializeComponent();
            ConfigurarFormulario();
        }
        private void ConfigurarFormulario()
        {
            btn_buscar.Click += btn_buscar_Click;
            // Asignar validaciones a campos de texto
            tb_nombre.KeyPress += solo_Letras_KeyPress;
            tb_apellido.KeyPress += solo_Letras_KeyPress;
            tb_sexo.KeyPress += solo_Letras_KeyPress;
            tb_cargo.KeyPress += solo_Letras_KeyPress;
            tb_departamento.KeyPress += solo_Letras_KeyPress;

            tb_cedula.KeyPress += solo_Numeros_KeyPress;
            tb_edad.KeyPress += solo_Numeros_KeyPress;
            tb_telefono.KeyPress += solo_Numeros_KeyPress;

            tb_sueldo.KeyPress += solo_Decimales_KeyPress;
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

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
        private void button2_Click(object sender, EventArgs e)
        {
            tb_Codigo_Empleado.Text = "";
            tb_cedula.Text = "";
            tb_nombre.Text = "";
            tb_apellido.Text = "";
            tb_edad.Text = "";
            tb_sexo.Text = "";
            tb_direccion.Text = "";
            tb_telefono.Text = "";
            tb_correo.Text = "";
            tb_cargo.Text = "";
            tb_departamento.Text = "";
            tb_sueldo.Text = "";
            tb_estado.Text = "Activo";

            tb_Codigo_Empleado.Focus();
            tb_cedula.MaxLength = 10;
            tb_edad.MaxLength = 2;
            tb_telefono.MaxLength = 10;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(tb_edad.Text.Trim(), out int edad)) edad = 0;
            if (!decimal.TryParse(tb_sueldo.Text.Trim(), out decimal sueldo)) sueldo = 0;

            Empleado empleadoModificado = new Empleado
            {
                Codigo = tb_Codigo_Empleado.Text.Trim(),
                Cedula = tb_cedula.Text.Trim(),
                Nombres = tb_nombre.Text.Trim(),
                Apellidos = tb_apellido.Text.Trim(),
                Edad = edad,
                Sexo = tb_sexo.Text.Trim(),
                Direccion = tb_direccion.Text.Trim(),
                Telefono = tb_telefono.Text.Trim(),
                Correo = tb_correo.Text.Trim(),
                Cargo = tb_cargo.Text.Trim(),
                Departamento = tb_departamento.Text.Trim(),
                Sueldo = sueldo,
                Estado = tb_estado.Text.Trim()
            };

            N_Empleado objNegocio = new N_Empleado();
            string mensaje;
            
            bool respuesta = objNegocio.Editar(empleadoModificado, out mensaje);

            if (respuesta)
            {
                MessageBox.Show("Empleado modificado correctamente.");
                button2_Click(sender, e);
            }
            else
            {
                MessageBox.Show(mensaje, "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tb_Codigo_Empleado_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_direccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void cb_criterio_SelectedIndexChanged(object sender, EventArgs e)
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
                case "Codigo":
                    tb_buscar.KeyPress += solo_Numeros_KeyPress;
                    return;
                case "Cedula":
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

        private void tb_buscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (cb_criterio.SelectedItem == null || string.IsNullOrWhiteSpace(tb_buscar.Text))
            {
                MessageBox.Show("Seleccione un criterio y escriba un valor a buscar.");
                return;
            }

            string criterio = cb_criterio.Text;
            string busqueda = tb_buscar.Text.Trim();
            
            N_Empleado objNegocio = new N_Empleado();
            Empleado encontrado = objNegocio.Consultar(criterio, busqueda).FirstOrDefault();

            if (encontrado != null)
            {
                tb_Codigo_Empleado.Text = encontrado.Codigo;
                tb_cedula.Text = encontrado.Cedula;
                tb_nombre.Text = encontrado.Nombres;
                tb_apellido.Text = encontrado.Apellidos;
                tb_edad.Text = encontrado.Edad.ToString();
                tb_sexo.Text = encontrado.Sexo;
                tb_direccion.Text = encontrado.Direccion;
                tb_telefono.Text = encontrado.Telefono;
                tb_correo.Text = encontrado.Correo;
                tb_cargo.Text = encontrado.Cargo;
                tb_departamento.Text = encontrado.Departamento;
                tb_sueldo.Text = encontrado.Sueldo.ToString();
                tb_estado.Text = encontrado.Estado;
            }
            else
            {
                MessageBox.Show("Empleado no encontrado.");
            }
        }
    
        private void btn_cerrar_global_Click(object sender, EventArgs e)
        {
            this.Close();
        }}
}

