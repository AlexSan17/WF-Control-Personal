using Control_Personal.Entidades;
using Control_Personal.CapaNegocios;
using System;
using System.Linq;
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
        private List<Empleado> listaOriginal = new List<Empleado>();
        private List<Empleado> listaFiltrada = new List<Empleado>();
        private int paginaActual = 1;
        private int registrosPorPagina = 10;

        public FR_Reportes()
        {
            InitializeComponent();
            this.Load += FR_Reportes_Load;
        }

        private void FR_Reportes_Load(object sender, EventArgs e)
        {
            dgv_empleados.Columns.Clear();
            listaOriginal = new N_Empleado().Listar();
            listaFiltrada = new List<Empleado>(listaOriginal);
            ActualizarGrilla();
        }

        private void cb_departamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            string dep = cb_departamento.SelectedItem?.ToString() ?? "Todos";
            if (dep == "Todos")
            {
                listaFiltrada = new List<Empleado>(listaOriginal);
            }
            else
            {
                listaFiltrada = listaOriginal.Where(emp => emp.Departamento != null && emp.Departamento.Trim().Equals(dep, StringComparison.OrdinalIgnoreCase)).ToList();
            }
            paginaActual = 1;
            ActualizarGrilla();
        }

        private void ActualizarGrilla()
        {
            int totalRegistros = listaFiltrada.Count;
            int totalPaginas = (int)Math.Ceiling((double)totalRegistros / registrosPorPagina);
            if (totalPaginas == 0) totalPaginas = 1;

            if (paginaActual < 1) paginaActual = 1;
            if (paginaActual > totalPaginas) paginaActual = totalPaginas;

            var listaPagina = listaFiltrada.Skip((paginaActual - 1) * registrosPorPagina).Take(registrosPorPagina).ToList();
            
            dgv_empleados.DataSource = listaPagina;
            
            lbl_pagina.Text = $"Página {paginaActual} de {totalPaginas}";
            
            btn_anterior.Enabled = paginaActual > 1;
            btn_siguiente.Enabled = paginaActual < totalPaginas;
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            paginaActual--;
            ActualizarGrilla();
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            paginaActual++;
            ActualizarGrilla();
        }
    
        private void btn_cerrar_global_Click(object sender, EventArgs e)
        {
            this.Close();
        }}
}

