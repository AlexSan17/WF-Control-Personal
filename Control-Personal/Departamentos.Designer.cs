namespace Control_Personal
{
    partial class Departamentos
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
            Fecha = new DataGridViewTextBoxColumn();
            Sueldo = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            lbl_criterio = new Label();
            cb_criterio = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgv_empleados).BeginInit();
            SuspendLayout();
            // 
            // dgv_empleados
            // 
            dgv_empleados.AllowUserToResizeRows = false;
            dgv_empleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_empleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_empleados.Columns.AddRange(new DataGridViewColumn[] { Codigo, Cedula, Nombre, Apellido, Telefono, Edad, Sexo, Cargo, Dirección, Correo, Fecha, Sueldo, Estado });
            dgv_empleados.Location = new Point(12, 44);
            dgv_empleados.Name = "dgv_empleados";
            dgv_empleados.ReadOnly = true;
            dgv_empleados.RowHeadersWidth = 51;
            dgv_empleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_empleados.Size = new Size(958, 398);
            dgv_empleados.TabIndex = 16;
            dgv_empleados.CellContentClick += dgv_empleados_CellContentClick;
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
            // lbl_criterio
            // 
            lbl_criterio.AutoSize = true;
            lbl_criterio.Location = new Point(60, 10);
            lbl_criterio.Name = "lbl_criterio";
            lbl_criterio.Size = new Size(82, 20);
            lbl_criterio.TabIndex = 13;
            lbl_criterio.Text = "Buscar por:";
            // 
            // cb_criterio
            // 
            cb_criterio.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_criterio.FormattingEnabled = true;
            cb_criterio.Items.AddRange(new object[] { "Nombre", "Apellido", "Cedula", "Codigo empleado", "Departamento" });
            cb_criterio.Location = new Point(203, 10);
            cb_criterio.Name = "cb_criterio";
            cb_criterio.Size = new Size(212, 28);
            cb_criterio.TabIndex = 12;
            // 
            // Departamentos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1073, 450);
            Controls.Add(dgv_empleados);
            Controls.Add(lbl_criterio);
            Controls.Add(cb_criterio);
            Name = "Departamentos";
            Text = "Departamentos";
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
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Sueldo;
        private DataGridViewTextBoxColumn Estado;
        private Label lbl_criterio;
        private ComboBox cb_criterio;
    }
}