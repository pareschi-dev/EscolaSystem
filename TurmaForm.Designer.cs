namespace EscolaSystem
{
    partial class TurmaForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbEscola;
        private System.Windows.Forms.TextBox txtAnoLetivo;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;

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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cmbEscola = new ComboBox();
            txtAnoLetivo = new TextBox();
            txtSerie = new TextBox();
            btnSalvar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semilight", 12F);
            label1.Location = new Point(13, 29);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(57, 21);
            label1.TabIndex = 0;
            label1.Text = "Escola:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semilight", 12F);
            label2.Location = new Point(13, 166);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(86, 21);
            label2.TabIndex = 1;
            label2.Text = "Ano Letivo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semilight", 12F);
            label3.Location = new Point(13, 99);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(56, 21);
            label3.TabIndex = 2;
            label3.Text = "Turma:";
            // 
            // cmbEscola
            // 
            cmbEscola.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEscola.Font = new Font("Segoe UI", 12F);
            cmbEscola.FormattingEnabled = true;
            cmbEscola.Location = new Point(13, 53);
            cmbEscola.Margin = new Padding(4, 3, 4, 3);
            cmbEscola.Name = "cmbEscola";
            cmbEscola.Size = new Size(432, 29);
            cmbEscola.TabIndex = 3;
            // 
            // txtAnoLetivo
            // 
            txtAnoLetivo.Font = new Font("Segoe UI", 12F);
            txtAnoLetivo.Location = new Point(13, 123);
            txtAnoLetivo.Margin = new Padding(4, 3, 4, 3);
            txtAnoLetivo.Name = "txtAnoLetivo";
            txtAnoLetivo.Size = new Size(432, 29);
            txtAnoLetivo.TabIndex = 4;
            // 
            // txtSerie
            // 
            txtSerie.Font = new Font("Segoe UI", 12F);
            txtSerie.Location = new Point(13, 190);
            txtSerie.Margin = new Padding(4, 3, 4, 3);
            txtSerie.Name = "txtSerie";
            txtSerie.Size = new Size(123, 29);
            txtSerie.TabIndex = 5;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.DarkSlateGray;
            btnSalvar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnSalvar.ForeColor = Color.MintCream;
            btnSalvar.Location = new Point(261, 187);
            btnSalvar.Margin = new Padding(4, 3, 4, 3);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(88, 32);
            btnSalvar.TabIndex = 6;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.DarkSlateGray;
            btnCancelar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.MintCream;
            btnCancelar.Location = new Point(357, 187);
            btnCancelar.Margin = new Padding(4, 3, 4, 3);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(88, 32);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // TurmaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(458, 233);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(txtSerie);
            Controls.Add(txtAnoLetivo);
            Controls.Add(cmbEscola);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "TurmaForm";
            Text = "Cadastro de Turma";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}