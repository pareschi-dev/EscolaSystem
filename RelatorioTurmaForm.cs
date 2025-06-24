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
    public partial class RelatorioTurmaForm : Form
    {
        private DataTable dataTable = new DataTable();
        private PrintDocument printDocument = new PrintDocument();
        private int currentPage = 0;

        public RelatorioTurmaForm()
        {
            InitializeComponent();
            printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);
            dataGridView.AutoGenerateColumns = false;
            ConfigureDataGridViewColumns();
            ConfigureDataTableColumns();
            LoadTurmasData();
        }

        private void ConfigureDataGridViewColumns()
        {
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "ID",
                DataPropertyName = "Id",
                Width = 50
            });

            dataGridView.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Escola ID",
                DataPropertyName = "EscolaId",
                Width = 70
            });

            dataGridView.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Ano Letivo",
                DataPropertyName = "AnoLetivo",
                Width = 100
            });

            dataGridView.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Série",
                DataPropertyName = "Serie",
                Width = 100
            });
        }

        private void ConfigureDataTableColumns()
        {
            dataTable.Columns.Add("Id", typeof(int));
            dataTable.Columns.Add("EscolaId", typeof(int));
            dataTable.Columns.Add("AnoLetivo", typeof(string));
            dataTable.Columns.Add("Serie", typeof(string));
        }

        private void LoadTurmasData()
        {
            dataTable.Rows.Clear();
            foreach (var turma in DataRepository.Turmas)
            {
                dataTable.Rows.Add(
                    turma.Id,
                    turma.EscolaId,
                    turma.AnoLetivo,
                    turma.Serie
                );
            }
            dataGridView.DataSource = dataTable;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarTurmas();
        }

        private void BuscarTurmas()
        {
            string criterio = txtCriterio.Text.Trim();
            if (string.IsNullOrEmpty(criterio))
            {
                LoadTurmasData();
                return;
            }

            var turmasFiltradas = DataRepository.Turmas
                .Where(turma => turma.AnoLetivo.Contains(criterio) ||
                               turma.Serie.Contains(criterio))
                .ToList();

            dataTable.Rows.Clear();
            foreach (var turma in turmasFiltradas)
            {
                dataTable.Rows.Add(
                    turma.Id,
                    turma.EscolaId,
                    turma.AnoLetivo,
                    turma.Serie
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

            e.Graphics.DrawString("Relatório de Turmas", headerFont, Brushes.Black, leftMargin, yPos);
            yPos += headerFont.GetHeight() + 20;

            string[] headers = { "ID", "Escola ID", "Ano Letivo", "Série" };
            float[] widths = { 50, 70, 100, 100 };

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
