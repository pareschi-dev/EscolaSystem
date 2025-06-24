using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace EscolaSystem
{
    public partial class MateriaForm : Form
    {
        public MateriaForm()
        {
            InitializeComponent();
            // Impede que a janela seja maximizada
            this.MaximizeBox = false;

            // Impede o redimensionamento manual da janela
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Nome é obrigatório!");
                return;
            }

            var materia = new Materia
            {
                Id = DataRepository.GetNextMateriaId(),
                Nome = txtNome.Text,
                CargaHoraria = (int)numCargaHoraria.Value
            };

            DataRepository.Materias.Add(materia);
            DataRepository.SaveData(); // Salva os dados em JSON
            MessageBox.Show("Matéria salva com sucesso!");
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

