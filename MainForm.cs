using mysqlsistema;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace EscolaSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            DataRepository.LoadData(); // Carrega os dados ao iniciar o MainForm

            this.FormBorderStyle = FormBorderStyle.None;     // Remove bordas e barra de título
            this.WindowState = FormWindowState.Maximized;    // Maximiza a janela
        }

            private void escolasToolStripMenuItem_Click(object sender, System.EventArgs e)
            {
                var form = new EscolaForm { MdiParent = this };
                form.Show();
            }

            private void turmasToolStripMenuItem_Click(object sender, System.EventArgs e)
            {
                var form = new TurmaForm { MdiParent = this };
                form.Show();
            }

            private void alunosToolStripMenuItem_Click(object sender, System.EventArgs e)
            {
                var form = new AlunoForm { MdiParent = this };
                form.Show();
            }

            private void matériasToolStripMenuItem_Click(object sender, System.EventArgs e)
            {
                var form = new MateriaForm { MdiParent = this };
                form.Show();
            }

            private void notasFrequênciaToolStripMenuItem_Click(object sender, System.EventArgs e)
            {
                var form = new NotasFrequenciaForm { MdiParent = this };
                form.Show();
            }

            private void relatórioAlunosToolStripMenuItem_Click(object sender, EventArgs e)
            {
                var form = new RelatorioAlunoForm { MdiParent = this };
                form.Show();
            }

            private void sairToolStripMenuItem_Click(object sender, EventArgs e)
            {
                Close();
            }

            private void escolaToolStripMenuItem_Click(object sender, EventArgs e)
            {
                var form = new RelatorioEscolaForm { MdiParent = this };
                form.Show();
            }

            private void turmasToolStripMenuItem1_Click(object sender, EventArgs e)
            {
                var form = new RelatorioTurmaForm { MdiParent = this };
                form.Show();
            }

            private void notasFrequênciasToolStripMenuItem_Click(object sender, EventArgs e)
            {
                var form = new RelatorioNotasFrequenciasForm { MdiParent = this };
                form.Show();
            }

            private void matériasToolStripMenuItem1_Click(object sender, EventArgs e)
            {
                var form = new RelatorioMateriaForm { MdiParent = this };
                form.Show();
            }

            private void button1_Click(object sender, EventArgs e)
            {
                var form = new RelatorioAlunoForm { MdiParent = this };
                form.Show();
            }

            private void button2_Click(object sender, EventArgs e)
            {
                var form = new RelatorioEscolaForm { MdiParent = this };
                form.Show();
            }

            private void button4_Click(object sender, EventArgs e)
            {
                var form = new RelatorioMateriaForm { MdiParent = this };
                form.Show();
            }

            private void button3_Click(object sender, EventArgs e)
            {
                var form = new NotasFrequenciaForm { MdiParent = this };
                form.Show();
            }

            private void button8_Click(object sender, EventArgs e)
            {
                var form = new RelatorioTurmaForm { MdiParent = this };
                form.Show();
            }

            private void button5_Click(object sender, EventArgs e)
            {
                Close();
            }
        }
    }




