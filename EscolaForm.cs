using System;
using System.Drawing;
using System.Windows.Forms;

namespace EscolaSystem
{
    public partial class EscolaForm : Form
    {
        public EscolaForm()
        {
            InitializeComponent();
            txtCNPJ.Leave += txtCNPJ_Leave;
            // Impede que a janela seja maximizada
            this.MaximizeBox = false;

            // Impede o redimensionamento manual da janela
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNomeFantasia.Text))
            {
                MessageBox.Show("Nome Fantasia é obrigatório!");
                return;
            }

            if (!IsCnpjValid(txtCNPJ.Text))
            {
                MessageBox.Show("CNPJ inválido!");
                return;
            }

            var escola = new Escola
            {
                Id = DataRepository.GetNextEscolaId(),
                NomeFantasia = txtNomeFantasia.Text,
                RazaoSocial = txtRazaoSocial.Text,
                CNPJ = txtCNPJ.Text.Replace(".", "").Replace("/", "").Replace("-", ""),
                Endereco = txtEndereco.Text,
                Telefone = txtTelefone.Text
            };

            DataRepository.Escolas.Add(escola);
            DataRepository.SaveData(); // Salva os dados em JSON
            MessageBox.Show("Escola salva com sucesso!");
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCNPJ_Leave(object sender, EventArgs e)
        {
            if (IsCnpjValid(txtCNPJ.Text))
            {
                txtCNPJ.BackColor = Color.LightGreen;
            }
            else
            {
                txtCNPJ.BackColor = Color.LightCoral;
            }
        }

        private bool IsCnpjValid(string cnpj)
        {
            cnpj = cnpj.Replace(".", "").Replace("/", "").Replace("-", "").Trim();

            if (cnpj.Length != 14) return false;

            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCnpj, digito;
            int soma, resto;

            tempCnpj = cnpj.Substring(0, 12);
            soma = 0;

            for (int i = 0; i < 12; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];

            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = resto.ToString();
            tempCnpj += digito;
            soma = 0;

            for (int i = 0; i < 13; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];

            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito += resto.ToString();

            return cnpj.EndsWith(digito);
        }
    }
}

