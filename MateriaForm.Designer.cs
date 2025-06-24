namespace EscolaSystem
{
    partial class MateriaForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.NumericUpDown numCargaHoraria;
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
            txtNome = new TextBox();
            numCargaHoraria = new NumericUpDown();
            btnSalvar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)numCargaHoraria).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semilight", 12F);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(13, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(54, 21);
            label1.TabIndex = 0;
            label1.Text = "Curso:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semilight", 12F);
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(13, 79);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(108, 21);
            label2.TabIndex = 1;
            label2.Text = "Carga Horária:";
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.Location = new Point(13, 33);
            txtNome.Margin = new Padding(4, 3, 4, 3);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(413, 29);
            txtNome.TabIndex = 2;
            // 
            // numCargaHoraria
            // 
            numCargaHoraria.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numCargaHoraria.Location = new Point(13, 103);
            numCargaHoraria.Margin = new Padding(4, 3, 4, 3);
            numCargaHoraria.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numCargaHoraria.Name = "numCargaHoraria";
            numCargaHoraria.Size = new Size(117, 29);
            numCargaHoraria.TabIndex = 3;
            numCargaHoraria.Value = new decimal(new int[] { 40, 0, 0, 0 });
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.DarkSlateGray;
            btnSalvar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnSalvar.ForeColor = SystemColors.Window;
            btnSalvar.Location = new Point(242, 100);
            btnSalvar.Margin = new Padding(4, 3, 4, 3);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(88, 31);
            btnSalvar.TabIndex = 4;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.DarkSlateGray;
            btnCancelar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnCancelar.ForeColor = SystemColors.Window;
            btnCancelar.Location = new Point(338, 100);
            btnCancelar.Margin = new Padding(4, 3, 4, 3);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(88, 31);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // MateriaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 35, 41);
            ClientSize = new Size(439, 161);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(numCargaHoraria);
            Controls.Add(txtNome);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "MateriaForm";
            Text = "Cadastro de Matéria";
            ((System.ComponentModel.ISupportInitialize)numCargaHoraria).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}