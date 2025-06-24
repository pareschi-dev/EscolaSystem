namespace EscolaSystem
{
    partial class NotasFrequenciaForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.GroupBox gbSelecao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTurma;
        private System.Windows.Forms.ComboBox cmbAluno;
        private System.Windows.Forms.ComboBox cmbMateria;
        private System.Windows.Forms.Label lblCargaHoraria;
        private System.Windows.Forms.GroupBox gbNotas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNota1;
        private System.Windows.Forms.TextBox txtNota2;
        private System.Windows.Forms.TextBox txtNota3;
        private System.Windows.Forms.TextBox txtNota4;
        private System.Windows.Forms.GroupBox gbFrequencia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtHorasFrequentadas;
        private System.Windows.Forms.GroupBox gbResultado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblMedia;
        private System.Windows.Forms.Label lblFrequencia;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnSalvar;

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
            gbSelecao = new GroupBox();
            cmbEscola = new ComboBox();
            label12 = new Label();
            lblCargaHoraria = new Label();
            cmbMateria = new ComboBox();
            cmbAluno = new ComboBox();
            cmbTurma = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            gbNotas = new GroupBox();
            txtNota4 = new TextBox();
            txtNota3 = new TextBox();
            txtNota2 = new TextBox();
            txtNota1 = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            gbFrequencia = new GroupBox();
            txtHorasFrequentadas = new TextBox();
            label8 = new Label();
            gbResultado = new GroupBox();
            lblStatus = new Label();
            lblFrequencia = new Label();
            lblMedia = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            btnCalcular = new Button();
            btnSalvar = new Button();
            gbSelecao.SuspendLayout();
            gbNotas.SuspendLayout();
            gbFrequencia.SuspendLayout();
            gbResultado.SuspendLayout();
            SuspendLayout();
            // 
            // gbSelecao
            // 
            gbSelecao.Controls.Add(cmbEscola);
            gbSelecao.Controls.Add(label12);
            gbSelecao.Controls.Add(lblCargaHoraria);
            gbSelecao.Controls.Add(cmbMateria);
            gbSelecao.Controls.Add(cmbAluno);
            gbSelecao.Controls.Add(cmbTurma);
            gbSelecao.Controls.Add(label3);
            gbSelecao.Controls.Add(label2);
            gbSelecao.Controls.Add(label1);
            gbSelecao.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbSelecao.Location = new Point(14, 14);
            gbSelecao.Margin = new Padding(4, 3, 4, 3);
            gbSelecao.Name = "gbSelecao";
            gbSelecao.Padding = new Padding(4, 3, 4, 3);
            gbSelecao.Size = new Size(653, 169);
            gbSelecao.TabIndex = 0;
            gbSelecao.TabStop = false;
            gbSelecao.Text = "Seleção";
            gbSelecao.Enter += gbSelecao_Enter;
            // 
            // cmbEscola
            // 
            cmbEscola.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEscola.FormattingEnabled = true;
            cmbEscola.Location = new Point(8, 59);
            cmbEscola.Margin = new Padding(4, 3, 4, 3);
            cmbEscola.Name = "cmbEscola";
            cmbEscola.Size = new Size(285, 29);
            cmbEscola.TabIndex = 8;
            cmbEscola.SelectedIndexChanged += cmbEscola_SelectedIndexChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(8, 35);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(57, 21);
            label12.TabIndex = 7;
            label12.Text = "Escola:";
            // 
            // lblCargaHoraria
            // 
            lblCargaHoraria.AutoSize = true;
            lblCargaHoraria.Location = new Point(614, 67);
            lblCargaHoraria.Margin = new Padding(4, 0, 4, 0);
            lblCargaHoraria.Name = "lblCargaHoraria";
            lblCargaHoraria.Size = new Size(18, 21);
            lblCargaHoraria.TabIndex = 6;
            lblCargaHoraria.Text = "0";
            // 
            // cmbMateria
            // 
            cmbMateria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMateria.FormattingEnabled = true;
            cmbMateria.Location = new Point(361, 59);
            cmbMateria.Margin = new Padding(4, 3, 4, 3);
            cmbMateria.Name = "cmbMateria";
            cmbMateria.Size = new Size(245, 29);
            cmbMateria.TabIndex = 5;
            cmbMateria.SelectedIndexChanged += cmbMateria_SelectedIndexChanged;
            // 
            // cmbAluno
            // 
            cmbAluno.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAluno.FormattingEnabled = true;
            cmbAluno.Location = new Point(8, 128);
            cmbAluno.Margin = new Padding(4, 3, 4, 3);
            cmbAluno.Name = "cmbAluno";
            cmbAluno.Size = new Size(285, 29);
            cmbAluno.TabIndex = 4;
            cmbAluno.SelectedIndexChanged += cmbAluno_SelectedIndexChanged;
            // 
            // cmbTurma
            // 
            cmbTurma.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTurma.FormattingEnabled = true;
            cmbTurma.Location = new Point(361, 128);
            cmbTurma.Margin = new Padding(4, 3, 4, 3);
            cmbTurma.Name = "cmbTurma";
            cmbTurma.Size = new Size(284, 29);
            cmbTurma.TabIndex = 3;
            cmbTurma.SelectedIndexChanged += cmbTurma_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(361, 35);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(66, 21);
            label3.TabIndex = 2;
            label3.Text = "Matéria:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 104);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(55, 21);
            label2.TabIndex = 1;
            label2.Text = "Aluno:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(361, 104);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(56, 21);
            label1.TabIndex = 0;
            label1.Text = "Turma:";
            // 
            // gbNotas
            // 
            gbNotas.Controls.Add(txtNota4);
            gbNotas.Controls.Add(txtNota3);
            gbNotas.Controls.Add(txtNota2);
            gbNotas.Controls.Add(txtNota1);
            gbNotas.Controls.Add(label7);
            gbNotas.Controls.Add(label6);
            gbNotas.Controls.Add(label5);
            gbNotas.Controls.Add(label4);
            gbNotas.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbNotas.Location = new Point(14, 199);
            gbNotas.Margin = new Padding(4, 3, 4, 3);
            gbNotas.Name = "gbNotas";
            gbNotas.Padding = new Padding(4, 3, 4, 3);
            gbNotas.Size = new Size(230, 176);
            gbNotas.TabIndex = 1;
            gbNotas.TabStop = false;
            gbNotas.Text = "Notas";
            // 
            // txtNota4
            // 
            txtNota4.Location = new Point(127, 68);
            txtNota4.Margin = new Padding(4, 3, 4, 3);
            txtNota4.Name = "txtNota4";
            txtNota4.Size = new Size(93, 29);
            txtNota4.TabIndex = 7;
            // 
            // txtNota3
            // 
            txtNota3.Location = new Point(127, 137);
            txtNota3.Margin = new Padding(4, 3, 4, 3);
            txtNota3.Name = "txtNota3";
            txtNota3.Size = new Size(93, 29);
            txtNota3.TabIndex = 6;
            // 
            // txtNota2
            // 
            txtNota2.Location = new Point(9, 137);
            txtNota2.Margin = new Padding(4, 3, 4, 3);
            txtNota2.Name = "txtNota2";
            txtNota2.Size = new Size(93, 29);
            txtNota2.TabIndex = 5;
            // 
            // txtNota1
            // 
            txtNota1.Location = new Point(9, 68);
            txtNota1.Margin = new Padding(4, 3, 4, 3);
            txtNota1.Name = "txtNota1";
            txtNota1.Size = new Size(93, 29);
            txtNota1.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(127, 44);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(61, 21);
            label7.TabIndex = 3;
            label7.Text = "Nota 4:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(128, 107);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(60, 21);
            label6.TabIndex = 2;
            label6.Text = "Nota 3:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 113);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(60, 21);
            label5.TabIndex = 1;
            label5.Text = "Nota 2:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 44);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(58, 21);
            label4.TabIndex = 0;
            label4.Text = "Nota 1:";
            // 
            // gbFrequencia
            // 
            gbFrequencia.Controls.Add(txtHorasFrequentadas);
            gbFrequencia.Controls.Add(label8);
            gbFrequencia.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbFrequencia.Location = new Point(13, 405);
            gbFrequencia.Margin = new Padding(4, 3, 4, 3);
            gbFrequencia.Name = "gbFrequencia";
            gbFrequencia.Padding = new Padding(4, 3, 4, 3);
            gbFrequencia.Size = new Size(653, 81);
            gbFrequencia.TabIndex = 2;
            gbFrequencia.TabStop = false;
            gbFrequencia.Text = "Frequência";
            // 
            // txtHorasFrequentadas
            // 
            txtHorasFrequentadas.Location = new Point(205, 30);
            txtHorasFrequentadas.Margin = new Padding(4, 3, 4, 3);
            txtHorasFrequentadas.Name = "txtHorasFrequentadas";
            txtHorasFrequentadas.Size = new Size(116, 29);
            txtHorasFrequentadas.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(23, 38);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(174, 21);
            label8.TabIndex = 0;
            label8.Text = "Horas Frequentadas (h):";
            // 
            // gbResultado
            // 
            gbResultado.Controls.Add(lblStatus);
            gbResultado.Controls.Add(lblFrequencia);
            gbResultado.Controls.Add(lblMedia);
            gbResultado.Controls.Add(label11);
            gbResultado.Controls.Add(label10);
            gbResultado.Controls.Add(label9);
            gbResultado.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbResultado.Location = new Point(309, 199);
            gbResultado.Margin = new Padding(4, 3, 4, 3);
            gbResultado.Name = "gbResultado";
            gbResultado.Padding = new Padding(4, 3, 4, 3);
            gbResultado.Size = new Size(359, 176);
            gbResultado.TabIndex = 3;
            gbResultado.TabStop = false;
            gbResultado.Text = "Resultado";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(385, 35);
            lblStatus.Margin = new Padding(4, 0, 4, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 21);
            lblStatus.TabIndex = 5;
            // 
            // lblFrequencia
            // 
            lblFrequencia.AutoSize = true;
            lblFrequencia.Location = new Point(315, 44);
            lblFrequencia.Margin = new Padding(4, 0, 4, 0);
            lblFrequencia.Name = "lblFrequencia";
            lblFrequencia.Size = new Size(31, 21);
            lblFrequencia.TabIndex = 4;
            lblFrequencia.Text = "0%";
            // 
            // lblMedia
            // 
            lblMedia.AutoSize = true;
            lblMedia.Location = new Point(81, 44);
            lblMedia.Margin = new Padding(4, 0, 4, 0);
            lblMedia.Name = "lblMedia";
            lblMedia.Size = new Size(30, 21);
            lblMedia.TabIndex = 3;
            lblMedia.Text = "0.0";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(24, 113);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(55, 21);
            label11.TabIndex = 2;
            label11.Text = "Status:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(218, 44);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(89, 21);
            label10.TabIndex = 1;
            label10.Text = "Frequência:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(22, 44);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(57, 21);
            label9.TabIndex = 0;
            label9.Text = "Média:";
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.DarkSlateGray;
            btnCalcular.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCalcular.ForeColor = SystemColors.Window;
            btnCalcular.Location = new Point(246, 508);
            btnCalcular.Margin = new Padding(4, 3, 4, 3);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(88, 32);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.DarkSlateGray;
            btnSalvar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSalvar.ForeColor = SystemColors.Window;
            btnSalvar.Location = new Point(342, 508);
            btnSalvar.Margin = new Padding(4, 3, 4, 3);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(88, 32);
            btnSalvar.TabIndex = 5;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // NotasFrequenciaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(681, 558);
            Controls.Add(btnSalvar);
            Controls.Add(btnCalcular);
            Controls.Add(gbResultado);
            Controls.Add(gbFrequencia);
            Controls.Add(gbNotas);
            Controls.Add(gbSelecao);
            Margin = new Padding(4, 3, 4, 3);
            Name = "NotasFrequenciaForm";
            Text = "Lançamento de Notas e Frequência";
            gbSelecao.ResumeLayout(false);
            gbSelecao.PerformLayout();
            gbNotas.ResumeLayout(false);
            gbNotas.PerformLayout();
            gbFrequencia.ResumeLayout(false);
            gbFrequencia.PerformLayout();
            gbResultado.ResumeLayout(false);
            gbResultado.PerformLayout();
            ResumeLayout(false);
        }

        private ComboBox cmbEscola;
        private Label label12;
    }
}