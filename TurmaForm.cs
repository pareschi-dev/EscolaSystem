using System;
using System.Linq;
using System.Windows.Forms;

namespace EscolaSystem
{
    public partial class TurmaForm : Form
    {
        public TurmaForm()
        {
            InitializeComponent();
            LoadEscolas();
            // Impede que a janela seja maximizada
            this.MaximizeBox = false;

            // Impede o redimensionamento manual da janela
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void LoadEscolas()
        {
            cmbEscola.DisplayMember = "NomeFantasia";
            cmbEscola.ValueMember = "Id";
            cmbEscola.DataSource = DataRepository.Escolas.ToList();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (cmbEscola.SelectedItem == null)
            {
                MessageBox.Show("Selecione uma escola!");
                return;
            }

            var turma = new Turma
            {
                Id = DataRepository.GetNextTurmaId(),
                EscolaId = ((Escola)cmbEscola.SelectedItem).Id,
                AnoLetivo = txtAnoLetivo.Text,
                Serie = txtSerie.Text
            };

            DataRepository.Turmas.Add(turma);
            DataRepository.SaveData(); // Salva os dados em JSON
            MessageBox.Show("Turma salva com sucesso!");
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

