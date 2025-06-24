using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace EscolaSystem
{
    public partial class AlunoForm : Form
    {
        public AlunoForm()
        {
            InitializeComponent();
            // Garante que o formulário não pode ser redimensionado
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // Centraliza o formulário na tela (mesmo se o InitializeComponent tentar sobrescrever)
            this.StartPosition = FormStartPosition.CenterScreen;

            // Garante que o formulário mantenha o tamanho definido
            this.AutoSize = false;
            this.AutoSizeMode = AutoSizeMode.GrowOnly;


            LoadTurmas();
            txtCPF.BackColor = SystemColors.Window;
            txtCPF.TextChanged += txtCPF_TextChanged;
        }

        private void LoadTurmas()
        {
            cmbTurma.DisplayMember = "Serie";
            cmbTurma.ValueMember = "Id";
            cmbTurma.DataSource = DataRepository.Turmas
                .Select(t => new { t.Id, Serie = $"{t.Serie} ({t.AnoLetivo})" }).ToList();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (cmbTurma.SelectedItem == null)
            {
                MessageBox.Show("Selecione uma turma!");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Nome é obrigatório!");
                return;
            }

            var aluno = new Aluno
            {
                Id = DataRepository.GetNextAlunoId(),
                TurmaId = ((dynamic)cmbTurma.SelectedItem).Id,
                Nome = txtNome.Text,
                CPF = txtCPF.Text,
                Situacao = cmbSituacao.Text
            };

            DataRepository.Alunos.Add(aluno);
            DataRepository.SaveData(); // Salva os dados em JSON
            MessageBox.Show("Aluno salvo com sucesso!");
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCPF_TextChanged(object sender, EventArgs e)
        {
            string cpf = txtCPF.Text;

            // Remove caracteres não numéricos
            string cleanCpf = new string(cpf.Where(char.IsDigit).ToArray());

            // Atualiza a cor conforme a validação
            if (cleanCpf.Length == 11 && ValidarCPF(cleanCpf))
            {
                txtCPF.BackColor = Color.LightGreen;
            }
            else
            {
                txtCPF.BackColor = Color.Coral;
            }
        }

        private bool ValidarCPF(string cpf)
        {
            // Verifica se todos os dígitos são iguais
            if (cpf.All(d => d == cpf[0]))
                return false;

            int[] multiplicadores1 = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicadores2 = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            string tempCpf = cpf.Substring(0, 9);
            int soma = 0;

            // Cálculo do primeiro dígito verificador
            for (int i = 0; i < 9; i++)
            {
                soma += (tempCpf[i] - '0') * multiplicadores1[i];
            }

            int resto = soma % 11;
            resto = resto < 2 ? 0 : 11 - resto;

            tempCpf += resto;

            // Cálculo do segundo dígito verificador
            soma = 0;
            for (int i = 0; i < 10; i++)
            {
                soma += (tempCpf[i] - '0') * multiplicadores2[i];
            }

            resto = soma % 11;
            resto = resto < 2 ? 0 : 11 - resto;

            return cpf.EndsWith(tempCpf + resto);
        }
    }
}