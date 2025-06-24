using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Linq;

namespace EscolaSystem
{
    public partial class RelatorioAlunoForm : Form
    {
        private DataTable dataTable = new DataTable();
        private PrintDocument printDocument = new PrintDocument();
        private int currentPage = 0;

        public RelatorioAlunoForm()
        {
            InitializeComponent();

            // Configurar impressão
            printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);

            // Configurar DataGridView
            dataGridView.AutoGenerateColumns = false;
            ConfigureDataGridViewColumns();
            ConfigureDataTableColumns(); // Adicionado: Configura as colunas do DataTable
            LoadAlunosData(); // Carrega os dados ao abrir o formulário
        }

        private void ConfigureDataGridViewColumns()
        {
            // Adicionar colunas
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "ID",
                DataPropertyName = "Id",
                Width = 50
            });

            dataGridView.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Nome",
                DataPropertyName = "Nome",
                Width = 200
            });

            dataGridView.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "CPF",
                DataPropertyName = "CPF",
                Width = 120
            });

            dataGridView.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Turma",
                DataPropertyName = "Turma",
                Width = 100
            });

            dataGridView.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Situação",
                DataPropertyName = "Situacao",
                Width = 80
            });
        }

        private void ConfigureDataTableColumns()
        {
            // Adicionado: Configura as colunas do DataTable para corresponder aos dados
            dataTable.Columns.Add("Id", typeof(int));
            dataTable.Columns.Add("Nome", typeof(string));
            dataTable.Columns.Add("CPF", typeof(string));
            dataTable.Columns.Add("Turma", typeof(string));
            dataTable.Columns.Add("Situacao", typeof(string));
        }

        private void LoadAlunosData()
        {
            // Limpa o DataTable existente
            dataTable.Rows.Clear();

            // Preenche o DataTable com os dados dos alunos do DataRepository
            foreach (var aluno in DataRepository.Alunos)
            {
                var turma = DataRepository.Turmas.FirstOrDefault(t => t.Id == aluno.TurmaId);
                // Certifique-se de que o número de itens aqui corresponde ao número de colunas no dataTable
                dataTable.Rows.Add(aluno.Id, aluno.Nome, aluno.CPF, turma?.Serie, aluno.Situacao);
            }

            // Define o DataTable como fonte de dados do DataGridView
            dataGridView.DataSource = dataTable;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarAlunos();
        }

        private void BuscarAlunos()
        {
            string criterio = txtCriterio.Text.Trim();

            if (string.IsNullOrEmpty(criterio))
            {
                LoadAlunosData(); // Se o critério estiver vazio, carrega todos os alunos
                return;
            }

            // Filtra os alunos com base no critério (CPF ou Nome)
            var alunosFiltrados = DataRepository.Alunos
                .Where(a => a.CPF.Contains(criterio) || a.Nome.Contains(criterio))
                .ToList();

            // Limpa o DataTable e adiciona os alunos filtrados
            dataTable.Rows.Clear();
            foreach (var aluno in alunosFiltrados)
            {
                var turma = DataRepository.Turmas.FirstOrDefault(t => t.Id == aluno.TurmaId);
                dataTable.Rows.Add(aluno.Id, aluno.Nome, aluno.CPF, turma?.Serie, aluno.Situacao);
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
            // Configurar fonte
            Font headerFont = new Font("Arial", 14, FontStyle.Bold);
            Font bodyFont = new Font("Arial", 10);

            // Configurar margens
            float leftMargin = e.MarginBounds.Left;
            float topMargin = e.MarginBounds.Top;
            float yPos = topMargin;

            // Título
            e.Graphics.DrawString("Relatório de Alunos", headerFont, Brushes.Black, leftMargin, yPos);
            yPos += headerFont.GetHeight() + 20;

            // Cabeçalho da tabela
            string[] headers = { "ID", "Nome", "CPF", "Turma", "Situação" };
            float[] widths = { 50, 200, 120, 100, 80 };

            // Desenhar cabeçalhos
            for (int i = 0; i < headers.Length; i++)
            {
                e.Graphics.DrawString(headers[i], bodyFont, Brushes.Black, leftMargin, yPos);
                leftMargin += widths[i];
            }

            yPos += bodyFont.GetHeight() + 10;
            leftMargin = e.MarginBounds.Left;

            // Linha separadora
            e.Graphics.DrawLine(Pens.Black, leftMargin, yPos, leftMargin + 550, yPos);
            yPos += 5;

            // Dados
            int rowsPerPage = (int)((e.MarginBounds.Height - yPos) / bodyFont.GetHeight());
            int startIndex = currentPage * rowsPerPage;
            int endIndex = Math.Min(startIndex + rowsPerPage, dataTable.Rows.Count);

            for (int i = startIndex; i < endIndex; i++)
            {
                DataRow row = dataTable.Rows[i];
                leftMargin = e.MarginBounds.Left;

                e.Graphics.DrawString(row["Id"].ToString(), bodyFont, Brushes.Black, leftMargin, yPos);
                leftMargin += widths[0];

                e.Graphics.DrawString(row["Nome"].ToString(), bodyFont, Brushes.Black, leftMargin, yPos);
                leftMargin += widths[1];

                e.Graphics.DrawString(row["CPF"].ToString(), bodyFont, Brushes.Black, leftMargin, yPos);
                leftMargin += widths[2];

                e.Graphics.DrawString(row["Turma"].ToString(), bodyFont, Brushes.Black, leftMargin, yPos);
                leftMargin += widths[3];

                e.Graphics.DrawString(row["Situacao"].ToString(), bodyFont, Brushes.Black, leftMargin, yPos);

                yPos += bodyFont.GetHeight() + 5;
            }

            // Verificar se há mais páginas
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

        private void RelatorioAlunoForm_Load(object sender, EventArgs e)
        {

        }
    }
}

