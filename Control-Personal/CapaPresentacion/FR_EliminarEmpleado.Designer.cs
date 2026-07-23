namespace Control_Personal.CapaPresentacion
{
    partial class FR_EliminarEmpleado
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
            btn_buscar = new Button();
            tb_buscar = new TextBox();
            lbl_criterio = new Label();
            cb_criterio = new ComboBox();
            btn_mostrar_todos = new Button();
            btn_cerrar_global = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_empleados).BeginInit();
            SuspendLayout();
            // 
            // dgv_empleados
            // 
            dgv_empleados.AllowUserToResizeRows = false;
            dgv_empleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_empleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_empleados.Columns.AddRange(new DataGridViewColumn[] { Codigo, Cedula, Nombre, Apellido, Telefono, Edad, Sexo, Cargo, Dirección, Correo, Departamento, Fecha, Sueldo, Estado });
            dgv_empleados.Location = new Point(12, 44);
            dgv_empleados.Name = "dgv_empleados";
            dgv_empleados.ReadOnly = true;
            dgv_empleados.RowHeadersWidth = 51;
            dgv_empleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_empleados.Size = new Size(958, 398);
            dgv_empleados.TabIndex = 11;
            dgv_empleados.CellContentClick += dgv_empleados_CellContentClick_1;
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
            // btn_buscar
            // 
            btn_buscar.Location = new Point(513, 9);
            btn_buscar.Name = "btn_buscar";
            btn_buscar.Size = new Size(94, 29);
            btn_buscar.TabIndex = 9;
            btn_buscar.Text = "Buscar";
            btn_buscar.UseVisualStyleBackColor = true;
            btn_buscar.Click += btn_buscar_Click_2;
            // 
            // tb_buscar
            // 
            tb_buscar.Location = new Point(339, 11);
            tb_buscar.Name = "tb_buscar";
            tb_buscar.Size = new Size(168, 27);
            tb_buscar.TabIndex = 8;
            tb_buscar.TextChanged += tb_buscar_TextChanged;
            // 
            // lbl_criterio
            // 
            lbl_criterio.AutoSize = true;
            lbl_criterio.Location = new Point(17, 13);
            lbl_criterio.Name = "lbl_criterio";
            lbl_criterio.Size = new Size(82, 20);
            lbl_criterio.TabIndex = 7;
            lbl_criterio.Text = "Buscar por:";
            lbl_criterio.Click += lbl_criterio_Click_1;
            // 
            // cb_criterio
            // 
            cb_criterio.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_criterio.FormattingEnabled = true;
            cb_criterio.Items.AddRange(new object[] { "Nombre", "Apellido", "Cedula", "Codigo empleado", "Departamento" });
            cb_criterio.Location = new Point(121, 10);
            cb_criterio.Name = "cb_criterio";
            cb_criterio.Size = new Size(212, 28);
            cb_criterio.TabIndex = 6;
            cb_criterio.SelectedIndexChanged += cb_criterio_SelectedIndexChanged;
            // 
            // btn_mostrar_todos
            // 
            btn_mostrar_todos.Location = new Point(613, 10);
            btn_mostrar_todos.Name = "btn_mostrar_todos";
            btn_mostrar_todos.Size = new Size(94, 29);
            btn_mostrar_todos.TabIndex = 10;
            btn_mostrar_todos.Text = "Eliminar";
            btn_mostrar_todos.UseVisualStyleBackColor = true;
            btn_mostrar_todos.Click += btn_mostrar_todos_Click;
            // 
            // btn_cerrar_global
            // 
            btn_cerrar_global.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_cerrar_global.Location = new Point(873, 8);
            btn_cerrar_global.Name = "btn_cerrar_global";
            btn_cerrar_global.Size = new Size(95, 30);
            btn_cerrar_global.TabIndex = 999;
            btn_cerrar_global.Text = "Cerrar";
            btn_cerrar_global.UseVisualStyleBackColor = true;
            btn_cerrar_global.Click += btn_cerrar_global_Click;
            // 
            // FR_EliminarEmpleado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(980, 450);
            Controls.Add(btn_mostrar_todos);
            Controls.Add(btn_buscar);
            Controls.Add(tb_buscar);
            Controls.Add(lbl_criterio);
            Controls.Add(cb_criterio);
            Controls.Add(btn_cerrar_global);
            Controls.Add(dgv_empleados);
            Name = "FR_EliminarEmpleado";
            Text = "FR_EliminarEmpleado";
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
        private Button btn_buscar;
        private TextBox tb_buscar;
        private Label lbl_criterio;
        private ComboBox cb_criterio;
        private Button btn_mostrar_todos;
    
        private System.Windows.Forms.Button btn_cerrar_global;}
}
