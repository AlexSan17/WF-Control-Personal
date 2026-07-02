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
namespace Control_Personal.CapaPresentacion
{
    public partial class FR_RegistrarEmpleado : Form
    {
        public FR_RegistrarEmpleado()
        {
            InitializeComponent();
            ConfigurarFormulario();
        }
        private void ConfigurarFormulario()
        {
            tb_fecha_de_ingreso.Format = DateTimePickerFormat.Short;
            tb_fecha_de_ingreso.Value = DateTime.Today;
            tb_estado.Text = "Activo";

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
            }
            if (sender is TextBox textBox && e.KeyChar == '.' && textBox.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
                MessageBox.Show("Solo se permite un punto decimal.");
            }
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

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
            tb_fecha_de_ingreso.Value = DateTime.Today;

            tb_Codigo_Empleado.Focus();
            tb_cedula.MaxLength = 10;
            tb_edad.MaxLength = 2;
            tb_telefono.MaxLength = 10;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tb_Codigo_Empleado.Text.Trim() == "" ||
                tb_cedula.Text.Trim() == "" ||
                tb_nombre.Text.Trim() == "" ||
                tb_apellido.Text.Trim() == "" ||
                tb_edad.Text.Trim() == "" ||
                tb_sexo.Text.Trim() == "" ||
                tb_direccion.Text.Trim() == "" ||
                tb_telefono.Text.Trim() == "" ||
                tb_correo.Text.Trim() == "" ||
                tb_cargo.Text.Trim() == "" ||
                tb_departamento.Text.Trim() == "" ||
                tb_sueldo.Text.Trim() == "" ||
                tb_estado.Text.Trim() == "")
            {
                MessageBox.Show("Todos los campos son obligatorios.");
                return;
            }

            if (Datos.ListaEmpleados.Any(emp => emp.Codigo == tb_Codigo_Empleado.Text.Trim()))
            {
                MessageBox.Show("El código del empleado ya existe.");
                return;
            }

            if (Datos.ListaEmpleados.Any(emp => emp.Cedula == tb_cedula.Text.Trim()))
            {
                MessageBox.Show("La cédula ya está registrada.");
                return;
            }

            if (!CedulaValida(tb_cedula.Text.Trim()))
            {
                MessageBox.Show("La cédula no es válida.");
                return;
            }

            if (!int.TryParse(tb_edad.Text.Trim(), out int edad))
            {
                MessageBox.Show("La edad debe ser un número.");
                return;
            }

            if (edad < 18)
            {
                MessageBox.Show("La edad debe ser mayor o igual a 18 años.");
                return;
            }

            if (!CorreoValido(tb_correo.Text.Trim()))
            {
                MessageBox.Show("El correo electrónico no tiene un formato válido.");
                return;
            }

            if (!decimal.TryParse(tb_sueldo.Text.Trim(), out decimal sueldo))
            {
                MessageBox.Show("El sueldo debe ser un número.");
                return;
            }

            if (sueldo <= 0)
            {
                MessageBox.Show("El sueldo debe ser mayor que cero.");
                return;
            }

            Empleado nuevoEmpleado = new Empleado
            {
                Codigo = tb_Codigo_Empleado.Text,
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
                FechaIngreso = tb_fecha_de_ingreso.Value,
                Sueldo = sueldo,
                Estado = tb_estado.Text.Trim()
            };

            Datos.ListaEmpleados.Add(nuevoEmpleado);

            MessageBox.Show("Empleado registrado correctamente.");

            button2_Click(sender, e);
        }
        private bool CorreoValido(string correo)
        {
            string patron = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(correo, patron);
        }

        private bool CedulaValida(string cedula)
        {
            if (cedula.Length != 10)
                return false;

            return cedula.All(char.IsDigit);
        }

        private void tb_Codigo_Empleado_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_direccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_cedula_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

