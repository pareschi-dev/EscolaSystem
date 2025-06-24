namespace mysqlsistema
{
    partial class RelatorioNotasFrequenciasForm
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
            btnImprimir = new Button();
            label1 = new Label();
            dataGridView = new DataGridView();
            btnBuscar = new Button();
            txtCriterio = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // btnImprimir
            // 
            btnImprimir.BackColor = Color.DarkSlateGray;
            btnImprimir.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnImprimir.ForeColor = SystemColors.Window;
            btnImprimir.Location = new Point(578, 30);
            btnImprimir.Margin = new Padding(4, 3, 4, 3);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(88, 32);
            btnImprimir.TabIndex = 10;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(13, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(216, 21);
            label1.TabIndex = 9;
            label1.Text = "Digite CPF ou nome do aluno:";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.BackgroundColor = Color.FromArgb(0, 87, 160);
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(13, 69);
            dataGridView.Margin = new Padding(4, 3, 4, 3);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.Size = new Size(653, 575);
            dataGridView.TabIndex = 8;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.DarkSlateGray;
            btnBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnBuscar.ForeColor = SystemColors.Window;
            btnBuscar.Location = new Point(482, 31);
            btnBuscar.Margin = new Padding(4, 3, 4, 3);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(88, 32);
            btnBuscar.TabIndex = 7;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // txtCriterio
            // 
            txtCriterio.Font = new Font("Segoe UI", 12F);
            txtCriterio.Location = new Point(13, 33);
            txtCriterio.Margin = new Padding(4, 3, 4, 3);
            txtCriterio.Name = "txtCriterio";
            txtCriterio.Size = new Size(462, 29);
            txtCriterio.TabIndex = 6;
            // 
            // RelatorioNotasFrequenciasForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 35, 41);
            ClientSize = new Size(681, 656);
            Controls.Add(btnImprimir);
            Controls.Add(label1);
            Controls.Add(dataGridView);
            Controls.Add(btnBuscar);
            Controls.Add(txtCriterio);
            Name = "RelatorioNotasFrequenciasForm";
            Text = "RelatorioNotasFrequenciasForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnImprimir;
        private Label label1;
        private DataGridView dataGridView;
        private Button btnBuscar;
        private TextBox txtCriterio;
    }
}