namespace EscolaSystem
{
    partial class EscolaForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNomeFantasia;
        private System.Windows.Forms.TextBox txtRazaoSocial;
        private System.Windows.Forms.MaskedTextBox txtCNPJ;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
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
            label4 = new Label();
            label5 = new Label();
            txtNomeFantasia = new TextBox();
            txtRazaoSocial = new TextBox();
            txtCNPJ = new MaskedTextBox();
            txtEndereco = new TextBox();
            txtTelefone = new MaskedTextBox();
            btnSalvar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.MintCream;
            label1.Font = new Font("Segoe UI Semilight", 12F);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(13, 24);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(52, 21);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semilight", 12F);
            label2.Location = new Point(13, 94);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(95, 21);
            label2.TabIndex = 1;
            label2.Text = "Razão Social";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semilight", 12F);
            label3.Location = new Point(13, 164);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(45, 21);
            label3.TabIndex = 2;
            label3.Text = "CNPJ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semilight", 12F);
            label4.Location = new Point(13, 234);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(73, 21);
            label4.TabIndex = 3;
            label4.Text = "Endereço";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semilight", 12F);
            label5.Location = new Point(341, 164);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(67, 21);
            label5.TabIndex = 4;
            label5.Text = "Telefone";
            // 
            // txtNomeFantasia
            // 
            txtNomeFantasia.Font = new Font("Segoe UI", 12F);
            txtNomeFantasia.Location = new Point(13, 48);
            txtNomeFantasia.Margin = new Padding(4, 3, 4, 3);
            txtNomeFantasia.Name = "txtNomeFantasia";
            txtNomeFantasia.Size = new Size(527, 29);
            txtNomeFantasia.TabIndex = 5;
            // 
            // txtRazaoSocial
            // 
            txtRazaoSocial.Font = new Font("Segoe UI", 12F);
            txtRazaoSocial.Location = new Point(13, 118);
            txtRazaoSocial.Margin = new Padding(4, 3, 4, 3);
            txtRazaoSocial.Name = "txtRazaoSocial";
            txtRazaoSocial.Size = new Size(527, 29);
            txtRazaoSocial.TabIndex = 6;
            // 
            // txtCNPJ
            // 
            txtCNPJ.Font = new Font("Segoe UI", 12F);
            txtCNPJ.Location = new Point(13, 188);
            txtCNPJ.Margin = new Padding(4, 3, 4, 3);
            txtCNPJ.Mask = "00,000,000/0000-00";
            txtCNPJ.Name = "txtCNPJ";
            txtCNPJ.Size = new Size(235, 29);
            txtCNPJ.TabIndex = 7;
            // 
            // txtEndereco
            // 
            txtEndereco.Font = new Font("Segoe UI", 12F);
            txtEndereco.Location = new Point(13, 258);
            txtEndereco.Margin = new Padding(4, 3, 4, 3);
            txtEndereco.Multiline = true;
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(527, 80);
            txtEndereco.TabIndex = 8;
            // 
            // txtTelefone
            // 
            txtTelefone.Font = new Font("Segoe UI", 12F);
            txtTelefone.Location = new Point(341, 188);
            txtTelefone.Margin = new Padding(4, 3, 4, 3);
            txtTelefone.Mask = "(00) 00000-0000";
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(199, 29);
            txtTelefone.TabIndex = 9;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.DarkSlateGray;
            btnSalvar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSalvar.ForeColor = SystemColors.Window;
            btnSalvar.Location = new Point(175, 363);
            btnSalvar.Margin = new Padding(4, 3, 4, 3);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(88, 32);
            btnSalvar.TabIndex = 10;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.DarkSlateGray;
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCancelar.ForeColor = SystemColors.Window;
            btnCancelar.Location = new Point(269, 363);
            btnCancelar.Margin = new Padding(4, 3, 4, 3);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(88, 32);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // EscolaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(555, 413);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(txtTelefone);
            Controls.Add(txtEndereco);
            Controls.Add(txtCNPJ);
            Controls.Add(txtRazaoSocial);
            Controls.Add(txtNomeFantasia);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "EscolaForm";
            Text = "Cadastro de Escola";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}