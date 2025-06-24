namespace EscolaSystem
{
    partial class AlunoForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.GroupBox gbDados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbTurma;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.DateTimePicker dtpNascimento;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.ComboBox cmbSituacao;
        private System.Windows.Forms.GroupBox gbResponsavel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtResponsavel;
        private System.Windows.Forms.MaskedTextBox txtCelularResponsavel;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox txtCPF;

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
            gbDados = new System.Windows.Forms.GroupBox();
            txtCPF = new System.Windows.Forms.MaskedTextBox();
            label8 = new System.Windows.Forms.Label();
            cmbSituacao = new System.Windows.Forms.ComboBox();
            cmbSexo = new System.Windows.Forms.ComboBox();
            dtpNascimento = new System.Windows.Forms.DateTimePicker();
            txtNome = new System.Windows.Forms.TextBox();
            cmbTurma = new System.Windows.Forms.ComboBox();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            gbResponsavel = new System.Windows.Forms.GroupBox();
            txtCelularResponsavel = new System.Windows.Forms.MaskedTextBox();
            txtResponsavel = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            btnSalvar = new System.Windows.Forms.Button();
            btnCancelar = new System.Windows.Forms.Button();
            gbDados.SuspendLayout();
            gbResponsavel.SuspendLayout();
            SuspendLayout();
            // 
            // gbDados
            // 
            gbDados.Controls.Add(txtCPF);
            gbDados.Controls.Add(label8);
            gbDados.Controls.Add(cmbSituacao);
            gbDados.Controls.Add(cmbSexo);
            gbDados.Controls.Add(dtpNascimento);
            gbDados.Controls.Add(txtNome);
            gbDados.Controls.Add(cmbTurma);
            gbDados.Controls.Add(label5);
            gbDados.Controls.Add(label4);
            gbDados.Controls.Add(label3);
            gbDados.Controls.Add(label2);
            gbDados.Controls.Add(label1);
            gbDados.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            gbDados.ForeColor = System.Drawing.SystemColors.Window;
            gbDados.Location = new System.Drawing.Point(14, 14);
            gbDados.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            gbDados.Name = "gbDados";
            gbDados.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            gbDados.Size = new System.Drawing.Size(510, 384);
            gbDados.TabIndex = 0;
            gbDados.TabStop = false;
            gbDados.Text = "Dados Pessoais";
            // 
            // txtCPF
            // 
            txtCPF.Location = new System.Drawing.Point(8, 205);
            txtCPF.Mask = "000.000.000-00";
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new System.Drawing.Size(493, 29);
            txtCPF.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(8, 181);
            label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(41, 21);
            label8.TabIndex = 10;
            label8.Text = "CPF:";
            // 
            // cmbSituacao
            // 
            cmbSituacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbSituacao.FormattingEnabled = true;
            cmbSituacao.Items.AddRange(new object[] { "Ativo", "Desativado" });
            cmbSituacao.Location = new System.Drawing.Point(8, 345);
            cmbSituacao.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cmbSituacao.Name = "cmbSituacao";
            cmbSituacao.Size = new System.Drawing.Size(184, 29);
            cmbSituacao.TabIndex = 9;
            // 
            // cmbSexo
            // 
            cmbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbSexo.FormattingEnabled = true;
            cmbSexo.Items.AddRange(new object[] { "Masculino", "Feminino" });
            cmbSexo.Location = new System.Drawing.Point(271, 275);
            cmbSexo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cmbSexo.Name = "cmbSexo";
            cmbSexo.Size = new System.Drawing.Size(230, 29);
            cmbSexo.TabIndex = 8;
            // 
            // dtpNascimento
            // 
            dtpNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtpNascimento.Location = new System.Drawing.Point(8, 275);
            dtpNascimento.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dtpNascimento.Name = "dtpNascimento";
            dtpNascimento.Size = new System.Drawing.Size(184, 29);
            dtpNascimento.TabIndex = 7;
            // 
            // txtNome
            // 
            txtNome.BackColor = System.Drawing.SystemColors.Window;
            txtNome.Location = new System.Drawing.Point(8, 135);
            txtNome.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtNome.Name = "txtNome";
            txtNome.Size = new System.Drawing.Size(493, 29);
            txtNome.TabIndex = 6;
            // 
            // cmbTurma
            // 
            cmbTurma.BackColor = System.Drawing.SystemColors.Window;
            cmbTurma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbTurma.FormattingEnabled = true;
            cmbTurma.Location = new System.Drawing.Point(8, 65);
            cmbTurma.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cmbTurma.Name = "cmbTurma";
            cmbTurma.Size = new System.Drawing.Size(493, 29);
            cmbTurma.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(8, 321);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(76, 21);
            label5.TabIndex = 4;
            label5.Text = "Situação:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(271, 251);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(50, 21);
            label4.TabIndex = 3;
            label4.Text = "Sexo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(8, 251);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(101, 21);
            label3.TabIndex = 2;
            label3.Text = "Nascimento:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(8, 111);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(59, 21);
            label2.TabIndex = 1;
            label2.Text = "Nome:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(8, 41);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(61, 21);
            label1.TabIndex = 0;
            label1.Text = "Turma:";
            // 
            // gbResponsavel
            // 
            gbResponsavel.Controls.Add(txtCelularResponsavel);
            gbResponsavel.Controls.Add(txtResponsavel);
            gbResponsavel.Controls.Add(label7);
            gbResponsavel.Controls.Add(label6);
            gbResponsavel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            gbResponsavel.ForeColor = System.Drawing.SystemColors.Window;
            gbResponsavel.Location = new System.Drawing.Point(14, 404);
            gbResponsavel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            gbResponsavel.Name = "gbResponsavel";
            gbResponsavel.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            gbResponsavel.Size = new System.Drawing.Size(510, 131);
            gbResponsavel.TabIndex = 1;
            gbResponsavel.TabStop = false;
            gbResponsavel.Text = "Responsável";
            // 
            // txtCelularResponsavel
            // 
            txtCelularResponsavel.Location = new System.Drawing.Point(8, 92);
            txtCelularResponsavel.Mask = "(99) 00000-0000";
            txtCelularResponsavel.Name = "txtCelularResponsavel";
            txtCelularResponsavel.Size = new System.Drawing.Size(493, 29);
            txtCelularResponsavel.TabIndex = 3;
            // 
            // txtResponsavel
            // 
            txtResponsavel.Location = new System.Drawing.Point(8, 43);
            txtResponsavel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtResponsavel.Name = "txtResponsavel";
            txtResponsavel.Size = new System.Drawing.Size(493, 29);
            txtResponsavel.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(8, 68);
            label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(61, 21);
            label7.TabIndex = 1;
            label7.Text = "Celular:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(8, 19);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(109, 21);
            label6.TabIndex = 0;
            label6.Text = "Nome Responsável:";
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new System.Drawing.Point(271, 547);
            btnSalvar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new System.Drawing.Size(125, 35);
            btnSalvar.TabIndex = 2;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new System.Drawing.Point(393, 547);
            btnCancelar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(125, 35);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // AlunoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(34, 45, 50);
            this.ClientSize = new System.Drawing.Size(538, 594);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.gbResponsavel);
            this.Controls.Add(this.gbDados);

            // Estas são as linhas críticas:
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Name = "AlunoForm";
            this.Text = "Cadastro de Aluno";
            this.gbDados.ResumeLayout(false);
            this.gbDados.PerformLayout();
            this.gbResponsavel.ResumeLayout(false);
            this.gbResponsavel.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}