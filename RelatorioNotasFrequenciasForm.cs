using EscolaSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mysqlsistema
{
    public partial class RelatorioNotasFrequenciasForm : Form
    {
        private DataTable dataTable = new DataTable();
        private PrintDocument printDocument = new PrintDocument();
        private int currentPage = 0;

        public RelatorioNotasFrequenciasForm()
        {
            InitializeComponent();
            printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);
            dataGridView.AutoGenerateColumns = false;
            ConfigureDataGridViewColumns();
            ConfigureDataTableColumns();
            LoadNotasFrequenciasData();
        }

        private void ConfigureDataGridViewColumns()
        {
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Aluno ID",
                DataPropertyName = "AlunoId",
                Width = 70
            });

            dataGridView.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Matéria ID",
                DataPropertyName = "MateriaId",
                Width = 70
            });

            dataGridView.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Nota1",
                DataPropertyName = "Nota1",
                Width = 60
            });

            dataGridView.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Nota2",
                DataPropertyName = "Nota2",
                Width = 60
            });

            dataGridView.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Nota3",
                DataPropertyName = "Nota3",
                Width = 60
            });

            dataGridView.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Nota4",
                DataPropertyName = "Nota4",
                Width = 60
            });

            dataGridView.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Horas Frequentadas",
                DataPropertyName = "HorasFrequentadas",
                Width = 100
            });
        }

        private void ConfigureDataTableColumns()
        {
            dataTable.Columns.Add("AlunoId", typeof(int));
            dataTable.Columns.Add("MateriaId", typeof(int));
            dataTable.Columns.Add("Nota1", typeof(double));
            dataTable.Columns.Add("Nota2", typeof(double));
            dataTable.Columns.Add("Nota3", typeof(double));
            dataTable.Columns.Add("Nota4", typeof(double));
            dataTable.Columns.Add("HorasFrequentadas", typeof(int));
        }

        private void LoadNotasFrequenciasData()
        {
            dataTable.Rows.Clear();
            foreach (var nf in DataRepository.NotasFrequencias)
            {
                dataTable.Rows.Add(
                    nf.AlunoId,
                    nf.MateriaId,
                    nf.Nota1,
                    nf.Nota2,
                    nf.Nota3,
                    nf.Nota4,
                    nf.HorasFrequentadas
                );
            }
            dataGridView.DataSource = dataTable;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarNotasFrequencias();
        }

        private void BuscarNotasFrequencias()
        {
            string criterio = txtCriterio.Text.Trim();
            if (string.IsNullOrEmpty(criterio))
            {
                LoadNotasFrequenciasData();
                return;
            }

            // Converter para número se possível
            bool isNumeric = int.TryParse(criterio, out int id);

            var nfFiltradas = DataRepository.NotasFrequencias
                .Where(nf =>
                    (isNumeric && (nf.AlunoId == id || nf.MateriaId == id)) ||
                    (!isNumeric && (
                        nf.Nota1.ToString().Contains(criterio) ||
                        nf.Nota2.ToString().Contains(criterio) ||
                        nf.Nota3.ToString().Contains(criterio) ||
                        nf.Nota4.ToString().Contains(criterio) ||
                        nf.HorasFrequentadas.ToString().Contains(criterio)
                    ))
                )
                .ToList();

            dataTable.Rows.Clear();
            foreach (var nf in nfFiltradas)
            {
                dataTable.Rows.Add(
                    nf.AlunoId,
                    nf.MateriaId,
                    nf.Nota1,
                    nf.Nota2,
                    nf.Nota3,
                    nf.Nota4,
                    nf.HorasFrequentadas
                );
            }
            dataGridView.DataSource = dataTable;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (dataTable.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum dado para imprimir");
                return;
            }

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                currentPage = 0;
                printDocument.Print();
            }
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font headerFont = new Font("Arial", 14, FontStyle.Bold);
            Font bodyFont = new Font("Arial", 10);

            float leftMargin = e.MarginBounds.Left;
            float topMargin = e.MarginBounds.Top;
            float yPos = topMargin;

            e.Graphics.DrawString("Relatório de Notas e Frequências", headerFont, Brushes.Black, leftMargin, yPos);
            yPos += headerFont.GetHeight() + 20;

            string[] headers = { "Aluno ID", "Matéria ID", "Nota1", "Nota2", "Nota3", "Nota4", "Horas" };
            float[] widths = { 70, 70, 60, 60, 60, 60, 60 };

            for (int i = 0; i < headers.Length; i++)
            {
                e.Graphics.DrawString(headers[i], bodyFont, Brushes.Black, leftMargin, yPos);
                leftMargin += widths[i];
            }

            yPos += bodyFont.GetHeight() + 10;
            leftMargin = e.MarginBounds.Left;

            e.Graphics.DrawLine(Pens.Black, leftMargin, yPos, leftMargin + widths.Sum(), yPos);
            yPos += 5;

            int rowsPerPage = (int)((e.MarginBounds.Height - yPos) / bodyFont.GetHeight());
            int startIndex = currentPage * rowsPerPage;
            int endIndex = Math.Min(startIndex + rowsPerPage, dataTable.Rows.Count);

            for (int i = startIndex; i < endIndex; i++)
            {
                DataRow row = dataTable.Rows[i];
                leftMargin = e.MarginBounds.Left;

                for (int j = 0; j < headers.Length; j++)
                {
                    e.Graphics.DrawString(row[j].ToString(), bodyFont, Brushes.Black, leftMargin, yPos);
                    leftMargin += widths[j];
                }

                yPos += bodyFont.GetHeight() + 5;
            }

            if (endIndex < dataTable.Rows.Count)
            {
                currentPage++;
                e.HasMorePages = true;
            }
            else
            {
                currentPage = 0;
                e.HasMorePages = false;
            }
        }
    }
}
