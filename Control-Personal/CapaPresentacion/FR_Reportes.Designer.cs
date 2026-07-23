namespace Control_Personal.CapaPresentacion
{
    partial class FR_Reportes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgv_empleados = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            Cedula = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            Edad = new DataGridViewTextBoxColumn();
            Sexo = new DataGridViewTextBoxColumn();
            Cargo = new DataGridViewTextBoxColumn();
            Dirección = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            Departamento = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            Sueldo = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            btn_cerrar_global = new Button();
            lbl_departamento = new Label();
            cb_departamento = new ComboBox();
            btn_anterior = new Button();
            btn_siguiente = new Button();
            lbl_pagina = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_empleados).BeginInit();
            SuspendLayout();
            // 
            // dgv_empleados
            // 
            dgv_empleados.AllowUserToResizeRows = false;
            dgv_empleados.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_empleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_empleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_empleados.Columns.AddRange(new DataGridViewColumn[] { Codigo, Cedula, Nombre, Apellido, Telefono, Edad, Sexo, Cargo, Dirección, Correo, Departamento, Fecha, Sueldo, Estado });
            dgv_empleados.Location = new Point(29, 60);
            dgv_empleados.Name = "dgv_empleados";
            dgv_empleados.ReadOnly = true;
            dgv_empleados.RowHeadersWidth = 51;
            dgv_empleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_empleados.Size = new Size(948, 310);
            dgv_empleados.TabIndex = 16;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Codigo";
            Codigo.MinimumWidth = 6;
            Codigo.Name = "Codigo";
            Codigo.ReadOnly = true;
            // 
            // Cedula
            // 
            Cedula.HeaderText = "Cedula";
            Cedula.MinimumWidth = 6;
            Cedula.Name = "Cedula";
            Cedula.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            Apellido.HeaderText = "Apellido";
            Apellido.MinimumWidth = 6;
            Apellido.Name = "Apellido";
            Apellido.ReadOnly = true;
            // 
            // Telefono
            // 
            Telefono.HeaderText = "Telefono";
            Telefono.MinimumWidth = 6;
            Telefono.Name = "Telefono";
            Telefono.ReadOnly = true;
            // 
            // Edad
            // 
            Edad.HeaderText = "Edad";
            Edad.MinimumWidth = 6;
            Edad.Name = "Edad";
            Edad.ReadOnly = true;
            // 
            // Sexo
            // 
            Sexo.HeaderText = "Sexo";
            Sexo.MinimumWidth = 6;
            Sexo.Name = "Sexo";
            Sexo.ReadOnly = true;
            // 
            // Cargo
            // 
            Cargo.HeaderText = "Cargo";
            Cargo.MinimumWidth = 6;
            Cargo.Name = "Cargo";
            Cargo.ReadOnly = true;
            // 
            // Dirección
            // 
            Dirección.HeaderText = "Dirección";
            Dirección.MinimumWidth = 6;
            Dirección.Name = "Dirección";
            Dirección.ReadOnly = true;
            // 
            // Correo
            // 
            Correo.HeaderText = "Correo";
            Correo.MinimumWidth = 6;
            Correo.Name = "Correo";
            Correo.ReadOnly = true;
            // 
            // Departamento
            // 
            Departamento.HeaderText = "Departamento";
            Departamento.MinimumWidth = 6;
            Departamento.Name = "Departamento";
            Departamento.ReadOnly = true;
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha ingreso";
            Fecha.MinimumWidth = 6;
            Fecha.Name = "Fecha";
            Fecha.ReadOnly = true;
            // 
            // Sueldo
            // 
            Sueldo.HeaderText = "sueldo";
            Sueldo.MinimumWidth = 6;
            Sueldo.Name = "Sueldo";
            Sueldo.ReadOnly = true;
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.MinimumWidth = 6;
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            // 
            // btn_cerrar_global
            // 
            btn_cerrar_global.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_cerrar_global.Location = new Point(882, 385);
            btn_cerrar_global.Name = "btn_cerrar_global";
            btn_cerrar_global.Size = new Size(95, 30);
            btn_cerrar_global.TabIndex = 999;
            btn_cerrar_global.Text = "Cerrar";
            btn_cerrar_global.UseVisualStyleBackColor = true;
            btn_cerrar_global.Click += btn_cerrar_global_Click;
            // 
            // lbl_departamento
            // 
            lbl_departamento.AutoSize = true;
            lbl_departamento.Location = new Point(29, 20);
            lbl_departamento.Name = "lbl_departamento";
            lbl_departamento.Size = new Size(178, 20);
            lbl_departamento.TabIndex = 100;
            lbl_departamento.Text = "Filtrar por Departamento:";
            // 
            // cb_departamento
            // 
            cb_departamento.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_departamento.FormattingEnabled = true;
            cb_departamento.Items.AddRange(new object[] { "Todos", "Recursos Humanos", "Administración y Finanzas", "Ventas", "Marketing", "Sistemas / TI", "Operaciones", "Logística y Bodega", "Gerencia General" });
            cb_departamento.Location = new Point(213, 17);
            cb_departamento.Name = "cb_departamento";
            cb_departamento.Size = new Size(212, 28);
            cb_departamento.TabIndex = 101;
            cb_departamento.SelectedIndexChanged += cb_departamento_SelectedIndexChanged;
            // 
            // btn_anterior
            // 
            btn_anterior.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_anterior.Location = new Point(29, 385);
            btn_anterior.Name = "btn_anterior";
            btn_anterior.Size = new Size(95, 30);
            btn_anterior.TabIndex = 102;
            btn_anterior.Text = "< Anterior";
            btn_anterior.UseVisualStyleBackColor = true;
            btn_anterior.Click += btn_anterior_Click;
            // 
            // btn_siguiente
            // 
            btn_siguiente.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_siguiente.Location = new Point(130, 385);
            btn_siguiente.Name = "btn_siguiente";
            btn_siguiente.Size = new Size(95, 30);
            btn_siguiente.TabIndex = 103;
            btn_siguiente.Text = "Siguiente >";
            btn_siguiente.UseVisualStyleBackColor = true;
            btn_siguiente.Click += btn_siguiente_Click;
            // 
            // lbl_pagina
            // 
            lbl_pagina.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lbl_pagina.AutoSize = true;
            lbl_pagina.Location = new Point(240, 390);
            lbl_pagina.Name = "lbl_pagina";
            lbl_pagina.Size = new Size(99, 20);
            lbl_pagina.TabIndex = 104;
            lbl_pagina.Text = "Página 1 de X";
            // 
            // FR_Reportes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(999, 431);
            Controls.Add(btn_cerrar_global);
            Controls.Add(lbl_departamento);
            Controls.Add(cb_departamento);
            Controls.Add(btn_anterior);
            Controls.Add(btn_siguiente);
            Controls.Add(lbl_pagina);
            Controls.Add(dgv_empleados);
            Name = "FR_Reportes";
            Text = "FR_Reportes";
            ((System.ComponentModel.ISupportInitialize)dgv_empleados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_empleados;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Cedula;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn Edad;
        private DataGridViewTextBoxColumn Sexo;
        private DataGridViewTextBoxColumn Cargo;
        private DataGridViewTextBoxColumn Dirección;
        private DataGridViewTextBoxColumn Correo;
        private DataGridViewTextBoxColumn Departamento;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Sueldo;
        private DataGridViewTextBoxColumn Estado;
    
        private System.Windows.Forms.Button btn_cerrar_global;
        private System.Windows.Forms.Label lbl_departamento;
        private System.Windows.Forms.ComboBox cb_departamento;
        private System.Windows.Forms.Button btn_anterior;
        private System.Windows.Forms.Button btn_siguiente;
        private System.Windows.Forms.Label lbl_pagina;
}
}
