namespace EscolaSystem
{
    partial class RelatorioAlunoForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtCriterio;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblResultados;
        private System.Windows.Forms.Button btnImprimir;

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
            txtCriterio = new TextBox();
            btnBuscar = new Button();
            dataGridView = new DataGridView();
            label1 = new Label();
            lblResultados = new Label();
            btnImprimir = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // txtCriterio
            // 
            txtCriterio.Font = new Font("Segoe UI", 12F);
            txtCriterio.Location = new Point(13, 34);
            txtCriterio.Margin = new Padding(4, 3, 4, 3);
            txtCriterio.Name = "txtCriterio";
            txtCriterio.Size = new Size(462, 29);
            txtCriterio.TabIndex = 0;
            txtCriterio.KeyPress += txtCriterio_KeyPress;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.DarkSlateGray;
            btnBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnBuscar.ForeColor = SystemColors.Window;
            btnBuscar.Location = new Point(484, 32);
            btnBuscar.Margin = new Padding(4, 3, 4, 3);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(88, 32);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.BackgroundColor = Color.FromArgb(0, 87, 160);
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(14, 69);
            dataGridView.Margin = new Padding(4, 3, 4, 3);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.Size = new Size(653, 575);
            dataGridView.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(13, 10);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(216, 21);
            label1.TabIndex = 3;
            label1.Text = "Digite CPF ou nome do aluno:";
            // 
            // lblResultados
            // 
            lblResultados.AutoSize = true;
            lblResultados.Location = new Point(14, 423);
            lblResultados.Margin = new Padding(4, 0, 4, 0);
            lblResultados.Name = "lblResultados";
            lblResultados.Size = new Size(0, 15);
            lblResultados.TabIndex = 4;
            // 
            // btnImprimir
            // 
            btnImprimir.BackColor = Color.DarkSlateGray;
            btnImprimir.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnImprimir.ForeColor = SystemColors.Window;
            btnImprimir.Location = new Point(580, 31);
            btnImprimir.Margin = new Padding(4, 3, 4, 3);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(88, 32);
            btnImprimir.TabIndex = 5;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = false;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // RelatorioAlunoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 35, 41);
            ClientSize = new Size(681, 656);
            Controls.Add(btnImprimir);
            Controls.Add(lblResultados);
            Controls.Add(label1);
            Controls.Add(dataGridView);
            Controls.Add(btnBuscar);
            Controls.Add(txtCriterio);
            Margin = new Padding(4, 3, 4, 3);
            Name = "RelatorioAlunoForm";
            Text = "Relatório de Alunos";
            Load += RelatorioAlunoForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void txtCriterio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                BuscarAlunos();
            }
        }
    }
}