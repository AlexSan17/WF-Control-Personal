using System;
using System.Drawing;
using System.Windows.Forms;
using Control_Personal.CapaNegocios;

namespace Control_Personal.CapaPresentacion
{
    public class FR_BeneficiosPersonal : Form
    {
        private DataGridView dgvBeneficios;
        private Label lblTitulo;
        private Button btn_buscar;
        private TextBox tb_buscar;
        private Label lbl_criterio;
        private ComboBox cb_criterio;
        private Label label1;
        private ComboBox cb_beneficios;
        private Label lbl_tipo_pago;
        private ComboBox cb_tipo_pago;
        private Button btn_actualizar;
        
        private N_Beneficios objBeneficios = new N_Beneficios();

        public FR_BeneficiosPersonal()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            dgvBeneficios = new DataGridView();
            lblTitulo = new Label();
            btn_buscar = new Button();
            tb_buscar = new TextBox();
            lbl_criterio = new Label();
            cb_criterio = new ComboBox();
            label1 = new Label();
            cb_beneficios = new ComboBox();
            lbl_tipo_pago = new Label();
            cb_tipo_pago = new ComboBox();
            btn_actualizar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBeneficios).BeginInit();
            SuspendLayout();
            // 
            // dgvBeneficios
            // 
            dgvBeneficios.AllowUserToAddRows = false;
            dgvBeneficios.AllowUserToDeleteRows = false;
            dgvBeneficios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvBeneficios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBeneficios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBeneficios.Location = new Point(20, 80);
            dgvBeneficios.Name = "dgvBeneficios";
            dgvBeneficios.ReadOnly = true;
            dgvBeneficios.RowHeadersWidth = 51;
            dgvBeneficios.Size = new Size(758, 268);
            dgvBeneficios.TabIndex = 1;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.Location = new Point(20, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(463, 37);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Reporte de Beneficios Acumulados";
            // 
            // btn_buscar
            // 
            btn_buscar.Location = new Point(18, 429);
            btn_buscar.Name = "btn_buscar";
            btn_buscar.Size = new Size(94, 29);
            btn_buscar.TabIndex = 24;
            btn_buscar.Text = "Buscar";
            btn_buscar.UseVisualStyleBackColor = true;
            btn_buscar.Click += btn_buscar_Click;
            // 
            // tb_buscar
            // 
            tb_buscar.Location = new Point(340, 364);
            tb_buscar.Name = "tb_buscar";
            tb_buscar.Size = new Size(168, 27);
            tb_buscar.TabIndex = 23;
            // 
            // lbl_criterio
            // 
            lbl_criterio.AutoSize = true;
            lbl_criterio.BackColor = SystemColors.Control;
            lbl_criterio.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_criterio.ForeColor = SystemColors.ControlText;
            lbl_criterio.Location = new Point(18, 366);
            lbl_criterio.Name = "lbl_criterio";
            lbl_criterio.Size = new Size(89, 20);
            lbl_criterio.TabIndex = 22;
            lbl_criterio.Text = "Buscar por:";
            // 
            // cb_criterio
            // 
            cb_criterio.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_criterio.FormattingEnabled = true;
            cb_criterio.Items.AddRange(new object[] { "Nombre", "Apellido", "Cedula", "Codigo", "Departamento" });
            cb_criterio.Location = new Point(122, 363);
            cb_criterio.Name = "cb_criterio";
            cb_criterio.Size = new Size(212, 28);
            cb_criterio.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(18, 396);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 25;
            label1.Text = "Beneficios:";
            // 
            // cb_beneficios
            // 
            cb_beneficios.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_beneficios.FormattingEnabled = true;
            cb_beneficios.Items.AddRange(new object[] { "Todos", "Décimo Tercero", "Décimo Cuarto", "Vacaciones" });
            cb_beneficios.Location = new Point(122, 397);
            cb_beneficios.Name = "cb_beneficios";
            cb_beneficios.Size = new Size(212, 28);
            cb_beneficios.TabIndex = 26;
            cb_beneficios.SelectedIndexChanged += cb_beneficios_SelectedIndexChanged;
            // 
            // lbl_tipo_pago
            // 
            lbl_tipo_pago.AutoSize = true;
            lbl_tipo_pago.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_tipo_pago.Location = new Point(340, 396);
            lbl_tipo_pago.Name = "lbl_tipo_pago";
            lbl_tipo_pago.Size = new Size(104, 20);
            lbl_tipo_pago.TabIndex = 27;
            lbl_tipo_pago.Text = "Tipo de Pago:";
            lbl_tipo_pago.Visible = false;
            // 
            // cb_tipo_pago
            // 
            cb_tipo_pago.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_tipo_pago.FormattingEnabled = true;
            cb_tipo_pago.Items.AddRange(new object[] { "Acumulado", "Mensual" });
            cb_tipo_pago.Location = new Point(452, 397);
            cb_tipo_pago.Name = "cb_tipo_pago";
            cb_tipo_pago.Size = new Size(150, 28);
            cb_tipo_pago.TabIndex = 28;
            cb_tipo_pago.Visible = false;
            // 
            // btn_actualizar
            // 
            btn_actualizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_actualizar.Location = new Point(122, 431);
            btn_actualizar.Name = "btn_actualizar";
            btn_actualizar.Size = new Size(94, 29);
            btn_actualizar.TabIndex = 29;
            btn_actualizar.Text = "Actualizar";
            btn_actualizar.UseVisualStyleBackColor = true;
            btn_actualizar.Visible = false;
            btn_actualizar.Click += btn_actualizar_Click;
            // 
            // FR_BeneficiosPersonal
            // 
            ClientSize = new Size(818, 476);
            Controls.Add(btn_actualizar);
            Controls.Add(cb_tipo_pago);
            Controls.Add(lbl_tipo_pago);
            Controls.Add(cb_beneficios);
            Controls.Add(label1);
            Controls.Add(btn_buscar);
            Controls.Add(tb_buscar);
            Controls.Add(lbl_criterio);
            Controls.Add(cb_criterio);
            Controls.Add(dgvBeneficios);
            Controls.Add(lblTitulo);
            Name = "FR_BeneficiosPersonal";
            Text = "Beneficios del Personal";
            Load += FR_BeneficiosPersonal_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBeneficios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void FR_BeneficiosPersonal_Load(object sender, EventArgs e)
        {
            cb_beneficios.SelectedIndex = 0;
            cb_tipo_pago.SelectedIndex = 0;
            ActualizarTabla();
        }

        private void cb_beneficios_SelectedIndexChanged(object sender, EventArgs e)
        {
            string seleccionado = cb_beneficios.SelectedItem?.ToString();
            if (seleccionado == "Décimo Tercero" || seleccionado == "Décimo Cuarto")
            {
                lbl_tipo_pago.Visible = true;
                cb_tipo_pago.Visible = true;
            }
            else
            {
                lbl_tipo_pago.Visible = false;
                cb_tipo_pago.Visible = false;
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (cb_criterio.SelectedItem == null || string.IsNullOrWhiteSpace(tb_buscar.Text))
            {
                MessageBox.Show("Seleccione un criterio y escriba un valor para buscar.");
                return;
            }
            btn_actualizar.Visible = true;
            ActualizarTabla();
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            ActualizarTabla();
        }

        private void ActualizarTabla()
        {
            string criterio = cb_criterio.SelectedItem?.ToString() ?? "";
            string busqueda = tb_buscar.Text.Trim();
            string beneficio = cb_beneficios.SelectedItem?.ToString() ?? "Todos";
            string pago = cb_tipo_pago.SelectedItem?.ToString() ?? "Acumulado";

            if (!btn_actualizar.Visible)
            {
                criterio = "";
                busqueda = "";
            }

            dgvBeneficios.DataSource = objBeneficios.CalcularBeneficios(criterio, busqueda, beneficio, pago);
        }
    }
}
