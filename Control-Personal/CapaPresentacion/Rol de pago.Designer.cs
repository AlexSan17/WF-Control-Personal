namespace Control_Personal.CapaPresentacion
{
    partial class Form2
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_nombres = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_departamento = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_cargo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_dias = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_sueldo_base = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_horas_extras = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_total_ingresos = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_iess = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tb_anticipos = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tb_total_egresos = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tb_liquido = new System.Windows.Forms.Label();
            this.tb_liquido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_liquido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            
            this.lbl_criterio = new System.Windows.Forms.Label();
            this.cb_criterio = new System.Windows.Forms.ComboBox();
            this.tb_buscar = new System.Windows.Forms.TextBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            
            this.lbl_desde = new System.Windows.Forms.Label();
            this.dtp_desde = new System.Windows.Forms.DateTimePicker();
            this.lbl_hasta = new System.Windows.Forms.Label();
            this.dtp_hasta = new System.Windows.Forms.DateTimePicker();
            
            this.SuspendLayout();
            
            // TITULO
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(216, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rol de pago de Empleado";
            
            // BUSCADOR
            this.lbl_criterio.AutoSize = true;
            this.lbl_criterio.Location = new System.Drawing.Point(25, 70);
            this.lbl_criterio.Name = "lbl_criterio";
            this.lbl_criterio.Size = new System.Drawing.Size(79, 20);
            this.lbl_criterio.Text = "Buscar por:";
            
            this.cb_criterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_criterio.FormattingEnabled = true;
            this.cb_criterio.Items.AddRange(new object[] { "Cédula", "Nombre", "Apellido" });
            this.cb_criterio.Location = new System.Drawing.Point(120, 67);
            this.cb_criterio.Name = "cb_criterio";
            this.cb_criterio.Size = new System.Drawing.Size(120, 28);
            
            this.tb_buscar.Location = new System.Drawing.Point(250, 67);
            this.tb_buscar.Name = "tb_buscar";
            this.tb_buscar.Size = new System.Drawing.Size(150, 27);
            
            this.btn_buscar.Location = new System.Drawing.Point(410, 66);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(94, 29);
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            
            // FECHAS
            this.lbl_desde.AutoSize = true;
            this.lbl_desde.Location = new System.Drawing.Point(520, 70);
            this.lbl_desde.Name = "lbl_desde";
            this.lbl_desde.Size = new System.Drawing.Size(54, 20);
            this.lbl_desde.Text = "Desde:";
            
            this.dtp_desde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_desde.Location = new System.Drawing.Point(580, 67);
            this.dtp_desde.Name = "dtp_desde";
            this.dtp_desde.Size = new System.Drawing.Size(120, 27);
            
            this.lbl_hasta.AutoSize = true;
            this.lbl_hasta.Location = new System.Drawing.Point(710, 70);
            this.lbl_hasta.Name = "lbl_hasta";
            this.lbl_hasta.Size = new System.Drawing.Size(50, 20);
            this.lbl_hasta.Text = "Hasta:";
            
            this.dtp_hasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_hasta.Location = new System.Drawing.Point(766, 67);
            this.dtp_hasta.Name = "dtp_hasta";
            this.dtp_hasta.Size = new System.Drawing.Size(120, 27);
            
            // INFORMACION EMPLEADO
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(264, 31);
            this.label6.Text = "Información empleado:";
            
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 20);
            this.label2.Text = "Nombres y apellidos:";
            
            this.tb_nombres.Location = new System.Drawing.Point(198, 167);
            this.tb_nombres.Name = "tb_nombres";
            this.tb_nombres.ReadOnly = true;
            this.tb_nombres.Size = new System.Drawing.Size(200, 27);
            
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.Text = "Departamento:";
            
            this.tb_departamento.Location = new System.Drawing.Point(198, 207);
            this.tb_departamento.Name = "tb_departamento";
            this.tb_departamento.ReadOnly = true;
            this.tb_departamento.Size = new System.Drawing.Size(200, 27);
            
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.Text = "Cargo:";
            
            this.tb_cargo.Location = new System.Drawing.Point(198, 247);
            this.tb_cargo.Name = "tb_cargo";
            this.tb_cargo.ReadOnly = true;
            this.tb_cargo.Size = new System.Drawing.Size(200, 27);
            
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 20);
            this.label5.Text = "DÃ­as laborados:";
            
            this.tb_dias.Location = new System.Drawing.Point(198, 287);
            this.tb_dias.Name = "tb_dias";
            this.tb_dias.ReadOnly = true;
            this.tb_dias.Size = new System.Drawing.Size(100, 27);

            // INGRESOS
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(453, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(222, 31);
            this.label7.Text = "Ingresos:";
            
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(453, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 20);
            this.label8.Text = "Sueldo Básico:";
            
            this.tb_sueldo_base.Location = new System.Drawing.Point(595, 167);
            this.tb_sueldo_base.Name = "tb_sueldo_base";
            this.tb_sueldo_base.ReadOnly = true;
            this.tb_sueldo_base.Size = new System.Drawing.Size(125, 27);
            
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(453, 210);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 20);
            this.label9.Text = "Horas Extras:";
            
            this.tb_horas_extras.Location = new System.Drawing.Point(595, 207);
            this.tb_horas_extras.Name = "tb_horas_extras";
            this.tb_horas_extras.Size = new System.Drawing.Size(125, 27);
            
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(453, 250);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 20);
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label10.Text = "Total Ingresos:";
            
            this.tb_total_ingresos.Location = new System.Drawing.Point(595, 247);
            this.tb_total_ingresos.Name = "tb_total_ingresos";
            this.tb_total_ingresos.ReadOnly = true;
            this.tb_total_ingresos.Size = new System.Drawing.Size(125, 27);

            // EGRESOS
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(453, 300);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(220, 31);
            this.label11.Text = "Egresos (Descuentos):";
            
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(453, 350);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(162, 20);
            this.label12.Text = "Aporte IESS (9.45%): ";
            
            this.tb_iess.Location = new System.Drawing.Point(595, 347);
            this.tb_iess.Name = "tb_iess";
            this.tb_iess.ReadOnly = true;
            this.tb_iess.Size = new System.Drawing.Size(125, 27);
            
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(453, 390);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(160, 20);
            this.label13.Text = "Anticipos:";
            
            this.tb_anticipos.Location = new System.Drawing.Point(595, 387);
            this.tb_anticipos.Name = "tb_anticipos";
            this.tb_anticipos.Size = new System.Drawing.Size(125, 27);
            
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(453, 430);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 20);
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label14.Text = "Total Egresos:";
            
            this.tb_total_egresos.Location = new System.Drawing.Point(595, 427);
            this.tb_total_egresos.Name = "tb_total_egresos";
            this.tb_total_egresos.ReadOnly = true;
            this.tb_total_egresos.Size = new System.Drawing.Size(125, 27);

            // LIQUIDO
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(25, 390);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(263, 28);
            this.label15.Text = "LÃ­quido a recibir:";
            
            this.tb_liquido.Location = new System.Drawing.Point(220, 390);
            this.tb_liquido.Name = "tb_liquido";
            this.tb_liquido.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.tb_liquido.BackColor = System.Drawing.Color.LightGreen;
            this.tb_liquido.Size = new System.Drawing.Size(178, 27);

            // BUTTONS
            this.btn_calcular.Location = new System.Drawing.Point(25, 450);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(130, 40);
            this.btn_calcular.Text = "Calcular Rol";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            
            this.btn_limpiar.Location = new System.Drawing.Point(170, 450);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(130, 40);
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);

            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 520);
            this.Controls.Add(this.tb_liquido);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.tb_total_egresos);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tb_anticipos);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tb_iess);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tb_total_ingresos);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tb_horas_extras);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tb_sueldo_base);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_dias);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_cargo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_departamento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_nombres);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            
            this.Controls.Add(this.lbl_criterio);
            this.Controls.Add(this.cb_criterio);
            this.Controls.Add(this.tb_buscar);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.btn_limpiar);
            
            this.Controls.Add(this.lbl_desde);
            this.Controls.Add(this.dtp_desde);
            this.Controls.Add(this.lbl_hasta);
            this.Controls.Add(this.dtp_hasta);

            this.Name = "Form2";
            this.Text = "Rol de Pagos";
            this.Load += new System.EventHandler(this.Form2_Load);
            
            this.ResumeLayout(false);
            // 
            // btn_cerrar_global
            // 
            this.btn_cerrar_global = new System.Windows.Forms.Button();
            this.btn_cerrar_global.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cerrar_global.Location = new System.Drawing.Point(this.ClientSize.Width - 110, this.ClientSize.Height - 40);
            this.btn_cerrar_global.Name = "btn_cerrar_global";
            
            this.btn_cerrar_global = new System.Windows.Forms.Button();
            this.btn_cerrar_global.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cerrar_global.Location = new System.Drawing.Point(this.ClientSize.Width - 110, this.ClientSize.Height - 40);
            this.btn_cerrar_global.Name = "btn_cerrar_global";
            this.btn_cerrar_global.Size = new System.Drawing.Size(95, 30);
            this.btn_cerrar_global.TabIndex = 999;
            this.btn_cerrar_global.Text = "Cerrar";
            this.btn_cerrar_global.UseVisualStyleBackColor = true;
            this.btn_cerrar_global.Click += new System.EventHandler(this.btn_cerrar_global_Click);
            this.Controls.Add(this.btn_cerrar_global);
            
            ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_nombres;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_departamento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_cargo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_dias;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_sueldo_base;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_horas_extras;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_total_ingresos;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_iess;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tb_anticipos;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tb_total_egresos;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label tb_liquido;
        
        private System.Windows.Forms.Label lbl_criterio;
        private System.Windows.Forms.ComboBox cb_criterio;
        private System.Windows.Forms.TextBox tb_buscar;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Button btn_limpiar;
        
        private System.Windows.Forms.Label lbl_desde;
        private System.Windows.Forms.DateTimePicker dtp_desde;
        private System.Windows.Forms.Label lbl_hasta;
        private System.Windows.Forms.DateTimePicker dtp_hasta;
    
        private System.Windows.Forms.Button btn_cerrar_global;}
}
