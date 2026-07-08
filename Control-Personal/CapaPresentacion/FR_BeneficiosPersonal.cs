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
        private N_Beneficios objBeneficios = new N_Beneficios();

        public FR_BeneficiosPersonal()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            dgvBeneficios = new DataGridView();
            lblTitulo = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvBeneficios).BeginInit();
            SuspendLayout();
           
            dgvBeneficios.AllowUserToAddRows = false;
            dgvBeneficios.AllowUserToDeleteRows = false;
            dgvBeneficios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvBeneficios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBeneficios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBeneficios.Location = new Point(20, 80);
            dgvBeneficios.Name = "dgvBeneficios";
            dgvBeneficios.ReadOnly = true;
            dgvBeneficios.RowHeadersWidth = 51;
            dgvBeneficios.Size = new Size(740, 340);
            dgvBeneficios.TabIndex = 1;
            dgvBeneficios.CellContentClick += dgvBeneficios_CellContentClick;
            
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.Location = new Point(20, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(463, 37);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Reporte de Beneficios Acumulados";
            lblTitulo.Click += lblTitulo_Click;
            
            ClientSize = new Size(800, 450);
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
            dgvBeneficios.DataSource = objBeneficios.CalcularBeneficios();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void dgvBeneficios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
