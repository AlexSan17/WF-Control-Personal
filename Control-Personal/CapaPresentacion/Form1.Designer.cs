namespace Control_Personal.CapaPresentacion
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            gestionDePersonalToolStripMenuItem = new ToolStripMenuItem();
            registrarToolStripMenuItem = new ToolStripMenuItem();
            moficarToolStripMenuItem = new ToolStripMenuItem();
            eliminarToolStripMenuItem = new ToolStripMenuItem();
            consultarToolStripMenuItem = new ToolStripMenuItem();
            reportesToolStripMenuItem = new ToolStripMenuItem();
            listadoGeneralToolStripMenuItem = new ToolStripMenuItem();
            personalActivoToolStripMenuItem = new ToolStripMenuItem();
            personalInactivoToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            salirDelSistemaToolStripMenuItem = new ToolStripMenuItem();
            beneficiosDelPersonalToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { gestionDePersonalToolStripMenuItem, reportesToolStripMenuItem, salirToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // gestionDePersonalToolStripMenuItem
            // 
            gestionDePersonalToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { registrarToolStripMenuItem, moficarToolStripMenuItem, eliminarToolStripMenuItem, consultarToolStripMenuItem });
            gestionDePersonalToolStripMenuItem.Name = "gestionDePersonalToolStripMenuItem";
            gestionDePersonalToolStripMenuItem.Size = new Size(155, 24);
            gestionDePersonalToolStripMenuItem.Text = "Gestion de personal";
            // 
            // registrarToolStripMenuItem
            // 
            registrarToolStripMenuItem.Name = "registrarToolStripMenuItem";
            registrarToolStripMenuItem.Size = new Size(156, 26);
            registrarToolStripMenuItem.Text = "Registrar";
            registrarToolStripMenuItem.Click += registrarToolStripMenuItem_Click;
            // 
            // moficarToolStripMenuItem
            // 
            moficarToolStripMenuItem.Name = "moficarToolStripMenuItem";
            moficarToolStripMenuItem.Size = new Size(156, 26);
            moficarToolStripMenuItem.Text = "Modificar";
            moficarToolStripMenuItem.Click += moficarToolStripMenuItem_Click;
            // 
            // eliminarToolStripMenuItem
            // 
            eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            eliminarToolStripMenuItem.Size = new Size(156, 26);
            eliminarToolStripMenuItem.Text = "Eliminar";
            eliminarToolStripMenuItem.Click += eliminarToolStripMenuItem_Click;
            // 
            // consultarToolStripMenuItem
            // 
            consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            consultarToolStripMenuItem.Size = new Size(156, 26);
            consultarToolStripMenuItem.Text = "Consultar";
            consultarToolStripMenuItem.Click += consultarToolStripMenuItem_Click;
            // 
            // reportesToolStripMenuItem
            // 
            reportesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listadoGeneralToolStripMenuItem, personalActivoToolStripMenuItem, personalInactivoToolStripMenuItem, beneficiosDelPersonalToolStripMenuItem });
            reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            reportesToolStripMenuItem.Size = new Size(82, 24);
            reportesToolStripMenuItem.Text = "Reportes";
            reportesToolStripMenuItem.Click += reportesToolStripMenuItem_Click;
            // 
            // listadoGeneralToolStripMenuItem
            // 
            listadoGeneralToolStripMenuItem.Name = "listadoGeneralToolStripMenuItem";
            listadoGeneralToolStripMenuItem.Size = new Size(248, 26);
            listadoGeneralToolStripMenuItem.Text = "Listado General";
            listadoGeneralToolStripMenuItem.Click += listadoGeneralToolStripMenuItem_Click;
            // 
            // personalActivoToolStripMenuItem
            // 
            personalActivoToolStripMenuItem.Name = "personalActivoToolStripMenuItem";
            personalActivoToolStripMenuItem.Size = new Size(248, 26);
            personalActivoToolStripMenuItem.Text = "Personal Activo";
            personalActivoToolStripMenuItem.Click += personalActivoToolStripMenuItem_Click;
            // 
            // personalInactivoToolStripMenuItem
            // 
            personalInactivoToolStripMenuItem.Name = "personalInactivoToolStripMenuItem";
            personalInactivoToolStripMenuItem.Size = new Size(248, 26);
            personalInactivoToolStripMenuItem.Text = "Personal Inactivo";
            personalInactivoToolStripMenuItem.Click += personalInactivoToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salirDelSistemaToolStripMenuItem });
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(52, 24);
            salirToolStripMenuItem.Text = "Salir";
            // 
            // salirDelSistemaToolStripMenuItem
            // 
            salirDelSistemaToolStripMenuItem.Name = "salirDelSistemaToolStripMenuItem";
            salirDelSistemaToolStripMenuItem.Size = new Size(200, 26);
            salirDelSistemaToolStripMenuItem.Text = "Salir del sistema";
            salirDelSistemaToolStripMenuItem.Click += salirDelSistemaToolStripMenuItem_Click;
            // 
            // beneficiosDelPersonalToolStripMenuItem
            // 
            beneficiosDelPersonalToolStripMenuItem.Name = "beneficiosDelPersonalToolStripMenuItem";
            beneficiosDelPersonalToolStripMenuItem.Size = new Size(248, 26);
            beneficiosDelPersonalToolStripMenuItem.Text = "Beneficios del Personal ";
            beneficiosDelPersonalToolStripMenuItem.Click += beneficiosDelPersonalToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de control de personal";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem gestionDePersonalToolStripMenuItem;
        private ToolStripMenuItem registrarToolStripMenuItem;
        private ToolStripMenuItem moficarToolStripMenuItem;
        private ToolStripMenuItem eliminarToolStripMenuItem;
        private ToolStripMenuItem consultarToolStripMenuItem;
        private ToolStripMenuItem reportesToolStripMenuItem;
        private ToolStripMenuItem listadoGeneralToolStripMenuItem;
        private ToolStripMenuItem personalActivoToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem salirDelSistemaToolStripMenuItem;
        private ToolStripMenuItem personalInactivoToolStripMenuItem;
        private ToolStripMenuItem beneficiosDelPersonalToolStripMenuItem;
    }
}

