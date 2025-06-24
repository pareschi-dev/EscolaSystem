using System;
using System.Linq;
using System.Windows.Forms;

namespace EscolaSystem
{
    public partial class NotasFrequenciaForm : Form
    {
        public NotasFrequenciaForm()
        {
            InitializeComponent();
            LoadTurmas();
            // Impede que a janela seja maximizada
            this.MaximizeBox = false;

            // Impede o redimensionamento manual da janela
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void LoadTurmas()
        {
            cmbTurma.DisplayMember = "Serie";
            cmbTurma.ValueMember = "Id";
            cmbTurma.DataSource = DataRepository.Turmas
                .Select(t => new { t.Id, Serie = $"{t.Serie} ({t.AnoLetivo})" }).ToList();
        }

        private void LoadAlunos()
        {
            if (cmbTurma.SelectedItem == null) return;

            int turmaId = ((dynamic)cmbTurma.SelectedItem).Id;
            cmbAluno.DisplayMember = "Nome";
            cmbAluno.ValueMember = "Id";
            cmbAluno.DataSource = DataRepository.Alunos
                .Where(a => a.TurmaId == turmaId)
                .ToList();
        }

        private void LoadMaterias()
        {
            cmbMateria.DisplayMember = "Nome";
            cmbMateria.ValueMember = "Id";
            cmbMateria.DataSource = DataRepository.Materias.ToList();
        }

        private void LoadCargaHoraria()
        {
            if (cmbMateria.SelectedItem == null) return;

            var materia = (Materia)cmbMateria.SelectedItem;
            lblCargaHoraria.Text = materia.CargaHoraria.ToString();
        }
        private void LoadEscolas()
        {
            cmbEscola.DisplayMember = "NomeFantasia";
            cmbEscola.ValueMember = "Id";
            cmbEscola.DataSource = DataRepository.Escolas.ToList();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double nota1, nota2, nota3, nota4;
            int horasFrequentadas;
            int cargaHoraria = int.Parse(lblCargaHoraria.Text);

            if (!double.TryParse(txtNota1.Text, out nota1) ||
                !double.TryParse(txtNota2.Text, out nota2) ||
                !double.TryParse(txtNota3.Text, out nota3) ||
                !double.TryParse(txtNota4.Text, out nota4) ||
                !int.TryParse(txtHorasFrequentadas.Text, out horasFrequentadas))
            {
                MessageBox.Show("Dados inválidos!");
                return;
            }

            double media = (nota1 + nota2 + nota3 + nota4) / 4;
            double percentualFrequencia = (double)horasFrequentadas / cargaHoraria * 100;

            lblMedia.Text = media.ToString("F2");
            lblFrequencia.Text = percentualFrequencia.ToString("F2") + "%";
            lblStatus.Text = (media >= 6 && percentualFrequencia > 80) ? "Aprovado" : "Reprovado";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (cmbAluno.SelectedItem == null || cmbMateria.SelectedItem == null)
            {
                MessageBox.Show("Selecione aluno e matéria!");
                return;
            }

            double nota1, nota2, nota3, nota4;
            int horasFrequentadas;

            if (!double.TryParse(txtNota1.Text, out nota1) ||
                !double.TryParse(txtNota2.Text, out nota2) ||
                !double.TryParse(txtNota3.Text, out nota3) ||
                !double.TryParse(txtNota4.Text, out nota4) ||
                !int.TryParse(txtHorasFrequentadas.Text, out horasFrequentadas))
            {
                MessageBox.Show("Dados inválidos!");
                return;
            }

            var registro = new NotaFrequencia
            {
                AlunoId = ((Aluno)cmbAluno.SelectedItem).Id,
                MateriaId = ((Materia)cmbMateria.SelectedItem).Id,
                Nota1 = nota1,
                Nota2 = nota2,
                Nota3 = nota3,
                Nota4 = nota4,
                HorasFrequentadas = horasFrequentadas
            };

            // Remove existing if any
            DataRepository.NotasFrequencias.RemoveAll(nf =>
                nf.AlunoId == registro.AlunoId && nf.MateriaId == registro.MateriaId);

            DataRepository.NotasFrequencias.Add(registro);
            DataRepository.SaveData(); // Salva os dados em JSON
            MessageBox.Show("Dados salvos com sucesso!");
        }

        private void cmbTurma_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadAlunos();
        }

        private void cmbAluno_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMaterias();
        }

        private void cmbMateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCargaHoraria();
        }

        private void gbSelecao_Enter(object sender, EventArgs e)
        {

        }

        private void cmbEscola_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadEscolas();
        }
    }
}

