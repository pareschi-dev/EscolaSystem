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
    public partial class RelatorioEscolaForm : Form
    {
        private DataTable dataTable = new DataTable();
        private PrintDocument printDocument = new PrintDocument();
        private int currentPage = 0;

        public RelatorioEscolaForm()
        {
            InitializeComponent();
            printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);
            dataGridView.AutoGenerateColumns = false;
            ConfigureDataGridViewColumns();
            ConfigureDataTableColumns();
            LoadEscolasData();
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
                HeaderText = "Nome Fantasia",
                DataPropertyName = "NomeFantasia",
                Width = 200
            });

            dataGridView.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Razão Social",
                DataPropertyName = "RazaoSocial",
                Width = 200
            });

            dataGridView.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "CNPJ",
                DataPropertyName = "CNPJ",
                Width = 150
            });
        }

        private void ConfigureDataTableColumns()
        {
            dataTable.Columns.Add("Id", typeof(int));
            dataTable.Columns.Add("NomeFantasia", typeof(string));
            dataTable.Columns.Add("RazaoSocial", typeof(string));
            dataTable.Columns.Add("CNPJ", typeof(string));
        }

        private void LoadEscolasData()
        {
            dataTable.Rows.Clear();
            foreach (var escola in DataRepository.Escolas)
            {
                dataTable.Rows.Add(escola.Id, escola.NomeFantasia, escola.RazaoSocial, escola.CNPJ);
            }
            dataGridView.DataSource = dataTable;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarEscolas();
        }

        private void BuscarEscolas()
        {
            string criterio = txtCriterio.Text.Trim();
            if (string.IsNullOrEmpty(criterio))
            {
                LoadEscolasData();
                return;
            }

            var escolasFiltradas = DataRepository.Escolas
                .Where(e => e.NomeFantasia.Contains(criterio) ||
                           e.RazaoSocial.Contains(criterio) ||
                           e.CNPJ.Contains(criterio))
                .ToList();

            dataTable.Rows.Clear();
            foreach (var escola in escolasFiltradas)
            {
                dataTable.Rows.Add(escola.Id, escola.NomeFantasia, escola.RazaoSocial, escola.CNPJ);
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

            e.Graphics.DrawString("Relatório de Escolas", headerFont, Brushes.Black, leftMargin, yPos);
            yPos += headerFont.GetHeight() + 20;

            string[] headers = { "ID", "Nome Fantasia", "Razão Social", "CNPJ" };
            float[] widths = { 50, 200, 200, 150 };

            for (int i = 0; i < headers.Length; i++)
            {
                e.Graphics.DrawString(headers[i], bodyFont, Brushes.Black, leftMargin, yPos);
                leftMargin += widths[i];
            }

            yPos += bodyFont.GetHeight() + 10;
            leftMargin = e.MarginBounds.Left;

            e.Graphics.DrawLine(Pens.Black, leftMargin, yPos, leftMargin + 600, yPos);
            yPos += 5;

            int rowsPerPage = (int)((e.MarginBounds.Height - yPos) / bodyFont.GetHeight());
            int startIndex = currentPage * rowsPerPage;
            int endIndex = Math.Min(startIndex + rowsPerPage, dataTable.Rows.Count);

            for (int i = startIndex; i < endIndex; i++)
            {
                DataRow row = dataTable.Rows[i];
                leftMargin = e.MarginBounds.Left;

                e.Graphics.DrawString(row["Id"].ToString(), bodyFont, Brushes.Black, leftMargin, yPos);
                leftMargin += widths[0];

                e.Graphics.DrawString(row["NomeFantasia"].ToString(), bodyFont, Brushes.Black, leftMargin, yPos);
                leftMargin += widths[1];

                e.Graphics.DrawString(row["RazaoSocial"].ToString(), bodyFont, Brushes.Black, leftMargin, yPos);
                leftMargin += widths[2];

                e.Graphics.DrawString(row["CNPJ"].ToString(), bodyFont, Brushes.Black, leftMargin, yPos);

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
