using Control_Personal.Entidades;
using Control_Personal.CapaNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Control_Personal.CapaPresentacion
{
    public partial class FR_Reportes : Form
    {
        public FR_Reportes()
        {
            InitializeComponent();
            this.Load += FR_Reportes_Load;
        }

        private void FR_Reportes_Load(object sender, EventArgs e)
        {
            dgv_empleados.Columns.Clear();
            dgv_empleados.DataSource = new N_Empleado().Listar();
        }
    }
}

