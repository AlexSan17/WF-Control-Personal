namespace Control_Personal.CapaPresentacion
{
    partial class Liquidación
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            labelTitulo = new Label();
            lbl_criterio = new Label();
            cb_criterio = new ComboBox();
            tb_buscar = new TextBox();
            btn_buscar = new Button();
            gb_info = new GroupBox();
            lbl_nombres = new Label();
            tb_nombres = new TextBox();
            lbl_depto = new Label();
            tb_departamento = new TextBox();
            lbl_cargo = new Label();
            tb_cargo = new TextBox();
            lbl_sueldo = new Label();
            tb_sueldo = new TextBox();
            lbl_ingreso = new Label();
            tb_ingreso = new TextBox();
            gb_salida = new GroupBox();
            lbl_salida = new Label();
            dtp_salida = new DateTimePicker();
            lbl_motivo = new Label();
            cb_motivo = new ComboBox();
            btn_calcular = new Button();
            btn_limpiar = new Button();
            gb_resultados = new GroupBox();
            lbl_anios = new Label();
            tb_anios = new TextBox();
            lbl_dias = new Label();
            tb_dias = new TextBox();
            lbl_decimo3 = new Label();
            tb_decimo3 = new TextBox();
            lbl_decimo4 = new Label();
            tb_decimo4 = new TextBox();
            lbl_vacaciones = new Label();
            tb_vacaciones = new TextBox();
            lbl_desahucio = new Label();
            tb_desahucio = new TextBox();
            lbl_despido = new Label();
            tb_despido = new TextBox();
            lbl_iess = new Label();
            tb_iess = new TextBox();
            lbl_total = new Label();
            tb_total = new TextBox();
            btn_cerrar_global = new Button();
            gb_info.SuspendLayout();
            gb_salida.SuspendLayout();
            gb_resultados.SuspendLayout();
            SuspendLayout();
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            labelTitulo.Location = new Point(300, 9);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(260, 41);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "Acta de Finiquito";
            // 
            // lbl_criterio
            // 
            lbl_criterio.AutoSize = true;
            lbl_criterio.Location = new Point(20, 70);
            lbl_criterio.Name = "lbl_criterio";
            lbl_criterio.Size = new Size(82, 20);
            lbl_criterio.TabIndex = 1;
            lbl_criterio.Text = "Buscar por:";
            // 
            // cb_criterio
            // 
            cb_criterio.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_criterio.FormattingEnabled = true;
            cb_criterio.Items.AddRange(new object[] { "Cédula", "Nombre", "Apellido" });
            cb_criterio.Location = new Point(105, 67);
            cb_criterio.Name = "cb_criterio";
            cb_criterio.Size = new Size(120, 28);
            cb_criterio.TabIndex = 2;
            // 
            // tb_buscar
            // 
            tb_buscar.Location = new Point(235, 67);
            tb_buscar.Name = "tb_buscar";
            tb_buscar.Size = new Size(150, 27);
            tb_buscar.TabIndex = 3;
            // 
            // btn_buscar
            // 
            btn_buscar.Location = new Point(395, 65);
            btn_buscar.Name = "btn_buscar";
            btn_buscar.Size = new Size(94, 30);
            btn_buscar.TabIndex = 4;
            btn_buscar.Text = "Buscar";
            btn_buscar.UseVisualStyleBackColor = true;
            btn_buscar.Click += btn_buscar_Click;
            // 
            // gb_info
            // 
            gb_info.Controls.Add(lbl_nombres);
            gb_info.Controls.Add(tb_nombres);
            gb_info.Controls.Add(lbl_depto);
            gb_info.Controls.Add(tb_departamento);
            gb_info.Controls.Add(lbl_cargo);
            gb_info.Controls.Add(tb_cargo);
            gb_info.Controls.Add(lbl_sueldo);
            gb_info.Controls.Add(tb_sueldo);
            gb_info.Controls.Add(lbl_ingreso);
            gb_info.Controls.Add(tb_ingreso);
            gb_info.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            gb_info.Location = new Point(20, 110);
            gb_info.Name = "gb_info";
            gb_info.Size = new Size(460, 240);
            gb_info.TabIndex = 5;
            gb_info.TabStop = false;
            gb_info.Text = "Información del Empleado";
            // 
            // lbl_nombres
            // 
            lbl_nombres.AutoSize = true;
            lbl_nombres.Font = new Font("Segoe UI", 9F);
            lbl_nombres.Location = new Point(20, 40);
            lbl_nombres.Name = "lbl_nombres";
            lbl_nombres.Size = new Size(151, 20);
            lbl_nombres.TabIndex = 0;
            lbl_nombres.Text = "Nombres y Apellidos:";
            // 
            // tb_nombres
            // 
            tb_nombres.Font = new Font("Segoe UI", 9F);
            tb_nombres.Location = new Point(190, 37);
            tb_nombres.Name = "tb_nombres";
            tb_nombres.ReadOnly = true;
            tb_nombres.Size = new Size(250, 27);
            tb_nombres.TabIndex = 1;
            // 
            // lbl_depto
            // 
            lbl_depto.AutoSize = true;
            lbl_depto.Font = new Font("Segoe UI", 9F);
            lbl_depto.Location = new Point(20, 80);
            lbl_depto.Name = "lbl_depto";
            lbl_depto.Size = new Size(109, 20);
            lbl_depto.TabIndex = 2;
            lbl_depto.Text = "Departamento:";
            // 
            // tb_departamento
            // 
            tb_departamento.Font = new Font("Segoe UI", 9F);
            tb_departamento.Location = new Point(190, 77);
            tb_departamento.Name = "tb_departamento";
            tb_departamento.ReadOnly = true;
            tb_departamento.Size = new Size(250, 27);
            tb_departamento.TabIndex = 3;
            // 
            // lbl_cargo
            // 
            lbl_cargo.AutoSize = true;
            lbl_cargo.Font = new Font("Segoe UI", 9F);
            lbl_cargo.Location = new Point(20, 120);
            lbl_cargo.Name = "lbl_cargo";
            lbl_cargo.Size = new Size(52, 20);
            lbl_cargo.TabIndex = 4;
            lbl_cargo.Text = "Cargo:";
            // 
            // tb_cargo
            // 
            tb_cargo.Font = new Font("Segoe UI", 9F);
            tb_cargo.Location = new Point(190, 117);
            tb_cargo.Name = "tb_cargo";
            tb_cargo.ReadOnly = true;
            tb_cargo.Size = new Size(250, 27);
            tb_cargo.TabIndex = 5;
            // 
            // lbl_sueldo
            // 
            lbl_sueldo.AutoSize = true;
            lbl_sueldo.Font = new Font("Segoe UI", 9F);
            lbl_sueldo.Location = new Point(20, 160);
            lbl_sueldo.Name = "lbl_sueldo";
            lbl_sueldo.Size = new Size(93, 20);
            lbl_sueldo.TabIndex = 6;
            lbl_sueldo.Text = "Sueldo Base:";
            // 
            // tb_sueldo
            // 
            tb_sueldo.Font = new Font("Segoe UI", 9F);
            tb_sueldo.Location = new Point(190, 157);
            tb_sueldo.Name = "tb_sueldo";
            tb_sueldo.ReadOnly = true;
            tb_sueldo.Size = new Size(120, 27);
            tb_sueldo.TabIndex = 7;
            // 
            // lbl_ingreso
            // 
            lbl_ingreso.AutoSize = true;
            lbl_ingreso.Font = new Font("Segoe UI", 9F);
            lbl_ingreso.Location = new Point(20, 200);
            lbl_ingreso.Name = "lbl_ingreso";
            lbl_ingreso.Size = new Size(124, 20);
            lbl_ingreso.TabIndex = 8;
            lbl_ingreso.Text = "Fecha de Ingreso:";
            // 
            // tb_ingreso
            // 
            tb_ingreso.Font = new Font("Segoe UI", 9F);
            tb_ingreso.Location = new Point(190, 197);
            tb_ingreso.Name = "tb_ingreso";
            tb_ingreso.ReadOnly = true;
            tb_ingreso.Size = new Size(120, 27);
            tb_ingreso.TabIndex = 9;
            // 
            // gb_salida
            // 
            gb_salida.Controls.Add(lbl_salida);
            gb_salida.Controls.Add(dtp_salida);
            gb_salida.Controls.Add(lbl_motivo);
            gb_salida.Controls.Add(cb_motivo);
            gb_salida.Controls.Add(btn_calcular);
            gb_salida.Controls.Add(btn_limpiar);
            gb_salida.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            gb_salida.Location = new Point(20, 360);
            gb_salida.Name = "gb_salida";
            gb_salida.Size = new Size(460, 180);
            gb_salida.TabIndex = 6;
            gb_salida.TabStop = false;
            gb_salida.Text = "Datos de Cesación";
            // 
            // lbl_salida
            // 
            lbl_salida.AutoSize = true;
            lbl_salida.Font = new Font("Segoe UI", 9F);
            lbl_salida.Location = new Point(20, 40);
            lbl_salida.Name = "lbl_salida";
            lbl_salida.Size = new Size(116, 20);
            lbl_salida.TabIndex = 0;
            lbl_salida.Text = "Fecha de Salida:";
            // 
            // dtp_salida
            // 
            dtp_salida.Font = new Font("Segoe UI", 9F);
            dtp_salida.Format = DateTimePickerFormat.Short;
            dtp_salida.Location = new Point(190, 37);
            dtp_salida.Name = "dtp_salida";
            dtp_salida.Size = new Size(150, 27);
            dtp_salida.TabIndex = 1;
            // 
            // lbl_motivo
            // 
            lbl_motivo.AutoSize = true;
            lbl_motivo.Font = new Font("Segoe UI", 9F);
            lbl_motivo.Location = new Point(20, 80);
            lbl_motivo.Name = "lbl_motivo";
            lbl_motivo.Size = new Size(125, 20);
            lbl_motivo.TabIndex = 2;
            lbl_motivo.Text = "Motivo de Salida:";
            // 
            // cb_motivo
            // 
            cb_motivo.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_motivo.Font = new Font("Segoe UI", 9F);
            cb_motivo.Items.AddRange(new object[] { "Renuncia Voluntaria", "Despido Intempestivo", "Terminación de Contrato" });
            cb_motivo.Location = new Point(190, 77);
            cb_motivo.Name = "cb_motivo";
            cb_motivo.Size = new Size(250, 28);
            cb_motivo.TabIndex = 3;
            // 
            // btn_calcular
            // 
            btn_calcular.Font = new Font("Segoe UI", 9F);
            btn_calcular.Location = new Point(190, 125);
            btn_calcular.Name = "btn_calcular";
            btn_calcular.Size = new Size(115, 35);
            btn_calcular.TabIndex = 4;
            btn_calcular.Text = "Calcular";
            btn_calcular.UseVisualStyleBackColor = true;
            btn_calcular.Click += btn_calcular_Click;
            // 
            // btn_limpiar
            // 
            btn_limpiar.Font = new Font("Segoe UI", 9F);
            btn_limpiar.Location = new Point(315, 125);
            btn_limpiar.Name = "btn_limpiar";
            btn_limpiar.Size = new Size(115, 35);
            btn_limpiar.TabIndex = 5;
            btn_limpiar.Text = "Limpiar";
            btn_limpiar.UseVisualStyleBackColor = true;
            btn_limpiar.Click += btn_limpiar_Click;
            // 
            // gb_resultados
            // 
            gb_resultados.BackColor = Color.WhiteSmoke;
            gb_resultados.Controls.Add(lbl_anios);
            gb_resultados.Controls.Add(tb_anios);
            gb_resultados.Controls.Add(lbl_dias);
            gb_resultados.Controls.Add(tb_dias);
            gb_resultados.Controls.Add(lbl_decimo3);
            gb_resultados.Controls.Add(tb_decimo3);
            gb_resultados.Controls.Add(lbl_decimo4);
            gb_resultados.Controls.Add(tb_decimo4);
            gb_resultados.Controls.Add(lbl_vacaciones);
            gb_resultados.Controls.Add(tb_vacaciones);
            gb_resultados.Controls.Add(lbl_desahucio);
            gb_resultados.Controls.Add(tb_desahucio);
            gb_resultados.Controls.Add(lbl_despido);
            gb_resultados.Controls.Add(tb_despido);
            gb_resultados.Controls.Add(lbl_iess);
            gb_resultados.Controls.Add(tb_iess);
            gb_resultados.Controls.Add(lbl_total);
            gb_resultados.Controls.Add(tb_total);
            gb_resultados.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            gb_resultados.Location = new Point(500, 110);
            gb_resultados.Name = "gb_resultados";
            gb_resultados.Size = new Size(370, 430);
            gb_resultados.TabIndex = 7;
            gb_resultados.TabStop = false;
            gb_resultados.Text = "Desglose de Valores";
            // 
            // lbl_anios
            // 
            lbl_anios.AutoSize = true;
            lbl_anios.Font = new Font("Segoe UI", 9F);
            lbl_anios.Location = new Point(20, 40);
            lbl_anios.Name = "lbl_anios";
            lbl_anios.Size = new Size(134, 20);
            lbl_anios.TabIndex = 0;
            lbl_anios.Text = "AÃ±os de Servicio:";
            // 
            // tb_anios
            // 
            tb_anios.Font = new Font("Segoe UI", 9F);
            tb_anios.Location = new Point(180, 37);
            tb_anios.Name = "tb_anios";
            tb_anios.ReadOnly = true;
            tb_anios.Size = new Size(70, 27);
            tb_anios.TabIndex = 1;
            // 
            // lbl_dias
            // 
            lbl_dias.AutoSize = true;
            lbl_dias.Font = new Font("Segoe UI", 9F);
            lbl_dias.Location = new Point(20, 80);
            lbl_dias.Name = "lbl_dias";
            lbl_dias.Size = new Size(127, 20);
            lbl_dias.TabIndex = 2;
            lbl_dias.Text = "DÃ­as Laborados:";
            // 
            // tb_dias
            // 
            tb_dias.Font = new Font("Segoe UI", 9F);
            tb_dias.Location = new Point(180, 77);
            tb_dias.Name = "tb_dias";
            tb_dias.ReadOnly = true;
            tb_dias.Size = new Size(70, 27);
            tb_dias.TabIndex = 3;
            // 
            // lbl_decimo3
            // 
            lbl_decimo3.AutoSize = true;
            lbl_decimo3.Font = new Font("Segoe UI", 9F);
            lbl_decimo3.Location = new Point(20, 120);
            lbl_decimo3.Name = "lbl_decimo3";
            lbl_decimo3.Size = new Size(153, 20);
            lbl_decimo3.TabIndex = 4;
            lbl_decimo3.Text = "13er Sueldo (Propor.):";
            // 
            // tb_decimo3
            // 
            tb_decimo3.Font = new Font("Segoe UI", 9F);
            tb_decimo3.Location = new Point(180, 117);
            tb_decimo3.Name = "tb_decimo3";
            tb_decimo3.ReadOnly = true;
            tb_decimo3.Size = new Size(150, 27);
            tb_decimo3.TabIndex = 5;
            // 
            // lbl_decimo4
            // 
            lbl_decimo4.AutoSize = true;
            lbl_decimo4.Font = new Font("Segoe UI", 9F);
            lbl_decimo4.Location = new Point(20, 160);
            lbl_decimo4.Name = "lbl_decimo4";
            lbl_decimo4.Size = new Size(154, 20);
            lbl_decimo4.TabIndex = 6;
            lbl_decimo4.Text = "14to Sueldo (Propor.):";
            // 
            // tb_decimo4
            // 
            tb_decimo4.Font = new Font("Segoe UI", 9F);
            tb_decimo4.Location = new Point(180, 157);
            tb_decimo4.Name = "tb_decimo4";
            tb_decimo4.ReadOnly = true;
            tb_decimo4.Size = new Size(150, 27);
            tb_decimo4.TabIndex = 7;
            // 
            // lbl_vacaciones
            // 
            lbl_vacaciones.AutoSize = true;
            lbl_vacaciones.Font = new Font("Segoe UI", 9F);
            lbl_vacaciones.Location = new Point(20, 200);
            lbl_vacaciones.Name = "lbl_vacaciones";
            lbl_vacaciones.Size = new Size(147, 20);
            lbl_vacaciones.TabIndex = 8;
            lbl_vacaciones.Text = "Vacaciones (Propor.):";
            // 
            // tb_vacaciones
            // 
            tb_vacaciones.Font = new Font("Segoe UI", 9F);
            tb_vacaciones.Location = new Point(180, 197);
            tb_vacaciones.Name = "tb_vacaciones";
            tb_vacaciones.ReadOnly = true;
            tb_vacaciones.Size = new Size(150, 27);
            tb_vacaciones.TabIndex = 9;
            // 
            // lbl_desahucio
            // 
            lbl_desahucio.AutoSize = true;
            lbl_desahucio.Font = new Font("Segoe UI", 9F);
            lbl_desahucio.Location = new Point(20, 240);
            lbl_desahucio.Name = "lbl_desahucio";
            lbl_desahucio.Size = new Size(81, 20);
            lbl_desahucio.TabIndex = 10;
            lbl_desahucio.Text = "Desahucio:";
            // 
            // tb_desahucio
            // 
            tb_desahucio.Font = new Font("Segoe UI", 9F);
            tb_desahucio.Location = new Point(180, 237);
            tb_desahucio.Name = "tb_desahucio";
            tb_desahucio.ReadOnly = true;
            tb_desahucio.Size = new Size(150, 27);
            tb_desahucio.TabIndex = 11;
            // 
            // lbl_despido
            // 
            lbl_despido.AutoSize = true;
            lbl_despido.Font = new Font("Segoe UI", 9F);
            lbl_despido.Location = new Point(20, 280);
            lbl_despido.Name = "lbl_despido";
            lbl_despido.Size = new Size(158, 20);
            lbl_despido.TabIndex = 12;
            lbl_despido.Text = "Despido Intempestivo:";
            // 
            // tb_despido
            // 
            tb_despido.Font = new Font("Segoe UI", 9F);
            tb_despido.Location = new Point(180, 277);
            tb_despido.Name = "tb_despido";
            tb_despido.ReadOnly = true;
            tb_despido.Size = new Size(150, 27);
            tb_despido.TabIndex = 13;
            // 
            // lbl_iess
            // 
            lbl_iess.AutoSize = true;
            lbl_iess.Font = new Font("Segoe UI", 9F);
            lbl_iess.Location = new Point(20, 320);
            lbl_iess.Name = "lbl_iess";
            lbl_iess.Size = new Size(122, 20);
            lbl_iess.TabIndex = 14;
            lbl_iess.Text = "Desc. IESS 9.45%:";
            // 
            // tb_iess
            // 
            tb_iess.Font = new Font("Segoe UI", 9F);
            tb_iess.Location = new Point(180, 317);
            tb_iess.Name = "tb_iess";
            tb_iess.ReadOnly = true;
            tb_iess.Size = new Size(150, 27);
            tb_iess.TabIndex = 15;
            // 
            // lbl_total
            // 
            lbl_total.AutoSize = true;
            lbl_total.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbl_total.Location = new Point(20, 375);
            lbl_total.Name = "lbl_total";
            lbl_total.Size = new Size(154, 28);
            lbl_total.TabIndex = 16;
            lbl_total.Text = "Total a Recibir:";
            // 
            // tb_total
            // 
            tb_total.BackColor = Color.PaleGreen;
            tb_total.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            tb_total.Location = new Point(180, 372);
            tb_total.Name = "tb_total";
            tb_total.ReadOnly = true;
            tb_total.Size = new Size(150, 34);
            tb_total.TabIndex = 17;
            // 
            // btn_cerrar_global
            // 
            btn_cerrar_global.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_cerrar_global.Location = new Point(775, 64);
            btn_cerrar_global.Name = "btn_cerrar_global";
            btn_cerrar_global.Size = new Size(95, 30);
            btn_cerrar_global.TabIndex = 999;
            btn_cerrar_global.Text = "Cerrar";
            btn_cerrar_global.UseVisualStyleBackColor = true;
            btn_cerrar_global.Click += btn_cerrar_global_Click;
            // 
            // Liquidación
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 560);
            Controls.Add(labelTitulo);
            Controls.Add(lbl_criterio);
            Controls.Add(cb_criterio);
            Controls.Add(tb_buscar);
            Controls.Add(btn_buscar);
            Controls.Add(btn_cerrar_global);
            Controls.Add(gb_resultados);
            Controls.Add(gb_salida);
            Controls.Add(gb_info);
            Name = "Liquidación";
            Text = "Acta de Finiquito";
            Load += Liquidación_Load;
            gb_info.ResumeLayout(false);
            gb_info.PerformLayout();
            gb_salida.ResumeLayout(false);
            gb_salida.PerformLayout();
            gb_resultados.ResumeLayout(false);
            gb_resultados.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label lbl_criterio;
        private System.Windows.Forms.ComboBox cb_criterio;
        private System.Windows.Forms.TextBox tb_buscar;
        private System.Windows.Forms.Button btn_buscar;
        
        private System.Windows.Forms.GroupBox gb_info;
        private System.Windows.Forms.Label lbl_nombres;
        private System.Windows.Forms.TextBox tb_nombres;
        private System.Windows.Forms.Label lbl_depto;
        private System.Windows.Forms.TextBox tb_departamento;
        private System.Windows.Forms.Label lbl_cargo;
        private System.Windows.Forms.TextBox tb_cargo;
        private System.Windows.Forms.Label lbl_sueldo;
        private System.Windows.Forms.TextBox tb_sueldo;
        private System.Windows.Forms.Label lbl_ingreso;
        private System.Windows.Forms.TextBox tb_ingreso;
        
        private System.Windows.Forms.GroupBox gb_salida;
        private System.Windows.Forms.Label lbl_salida;
        private System.Windows.Forms.DateTimePicker dtp_salida;
        private System.Windows.Forms.Label lbl_motivo;
        private System.Windows.Forms.ComboBox cb_motivo;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Button btn_limpiar;
        
        private System.Windows.Forms.GroupBox gb_resultados;
        private System.Windows.Forms.Label lbl_anios;
        private System.Windows.Forms.TextBox tb_anios;
        private System.Windows.Forms.Label lbl_dias;
        private System.Windows.Forms.TextBox tb_dias;
        private System.Windows.Forms.Label lbl_decimo3;
        private System.Windows.Forms.TextBox tb_decimo3;
        private System.Windows.Forms.Label lbl_decimo4;
        private System.Windows.Forms.TextBox tb_decimo4;
        private System.Windows.Forms.Label lbl_vacaciones;
        private System.Windows.Forms.TextBox tb_vacaciones;
        private System.Windows.Forms.Label lbl_desahucio;
        private System.Windows.Forms.TextBox tb_desahucio;
        private System.Windows.Forms.Label lbl_despido;
        private System.Windows.Forms.TextBox tb_despido;
        private System.Windows.Forms.Label lbl_iess;
        private System.Windows.Forms.TextBox tb_iess;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.TextBox tb_total;
    
        private System.Windows.Forms.Button btn_cerrar_global;}
}