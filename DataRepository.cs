using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using MySql.Data.MySqlClient;

namespace EscolaSystem
{
    public static class DataRepository
    {
        public static List<Escola> Escolas { get; set; } = new List<Escola>();
        public static List<Turma> Turmas { get; set; } = new List<Turma>();
        public static List<Aluno> Alunos { get; set; } = new List<Aluno>();
        public static List<Materia> Materias { get; set; } = new List<Materia>();
        public static List<NotaFrequencia> NotasFrequencias { get; set; } = new List<NotaFrequencia>();

        /// <summary>
        /// </summary>
        public static void SaveData()
        {
            bool dbAvailable = DbConnection.IsDbConnectionAvailable();

            if (dbAvailable)
            {
                try
                {
                    SaveDataToDatabase();
                    Console.WriteLine("Dados salvos com sucesso no MySQL.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao salvar no MySQL: {ex.Message}.");
                }
            }
            else
            {
                Console.WriteLine("MySQL não disponível. Dados não foram salvos.");
            }
        }

        /// <summary>
        /// Salva os dados no banco de dados MySQL
        /// </summary>
        private static void SaveDataToDatabase()
        {
            using (var connection = DbConnection.GetConnection())
            {
                SaveEscolasToDb(connection);
                SaveTurmasToDb(connection);
                SaveAlunosToDb(connection);
                SaveMateriasToDb(connection);
                SaveNotasFrequenciasToDb(connection);
            }
        }

        /// <summary>
        /// Salva as escolas no banco de dados
        /// </summary>
        /// 
        private static void SaveEscolasToDb(MySqlConnection connection)
        {
            foreach (var escola in Escolas)
            {
                string query = @"INSERT INTO escolas (id, nome_fantasia, razao_social, cnpj, endereco, telefone) 
                                VALUES (@id, @nomeFantasia, @razaoSocial, @cnpj, @endereco, @telefone)
                                ON DUPLICATE KEY UPDATE 
                                nome_fantasia = @nomeFantasia, 
                                razao_social = @razaoSocial, 
                                cnpj = @cnpj, 
                                endereco = @endereco, 
                                telefone = @telefone";

                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id", escola.Id);
                    cmd.Parameters.AddWithValue("@nomeFantasia", escola.NomeFantasia);
                    cmd.Parameters.AddWithValue("@razaoSocial", escola.RazaoSocial);
                    cmd.Parameters.AddWithValue("@cnpj", escola.CNPJ);
                    cmd.Parameters.AddWithValue("@endereco", escola.Endereco);
                    cmd.Parameters.AddWithValue("@telefone", escola.Telefone);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Salva as turmas no banco de dados
        /// </summary>
        private static void SaveTurmasToDb(MySqlConnection connection)
        {
            foreach (var turma in Turmas)
            {
                string query = @"INSERT INTO turmas (id, escola_id, ano_letivo, serie) 
                                VALUES (@id, @escolaId, @anoLetivo, @serie)
                                ON DUPLICATE KEY UPDATE 
                                escola_id = @escolaId, 
                                ano_letivo = @anoLetivo, 
                                serie = @serie";

                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id", turma.Id);
                    cmd.Parameters.AddWithValue("@escolaId", turma.EscolaId);
                    cmd.Parameters.AddWithValue("@anoLetivo", turma.AnoLetivo);
                    cmd.Parameters.AddWithValue("@serie", turma.Serie);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Salva os alunos no banco de dados
        /// </summary>
        private static void SaveAlunosToDb(MySqlConnection connection)
        {
            foreach (var aluno in Alunos)
            {
                string query = @"INSERT INTO alunos (id, turma_id, nome, cpf, situacao) 
                                VALUES (@id, @turmaId, @nome, @cpf, @situacao)
                                ON DUPLICATE KEY UPDATE 
                                turma_id = @turmaId, 
                                nome = @nome, 
                                cpf = @cpf, 
                                situacao = @situacao";

                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id", aluno.Id);
                    cmd.Parameters.AddWithValue("@turmaId", aluno.TurmaId);
                    cmd.Parameters.AddWithValue("@nome", aluno.Nome);
                    cmd.Parameters.AddWithValue("@cpf", aluno.CPF);
                    cmd.Parameters.AddWithValue("@situacao", aluno.Situacao);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Salva as matérias no banco de dados
        /// </summary>
        private static void SaveMateriasToDb(MySqlConnection connection)
        {
            foreach (var materia in Materias)
            {
                string query = @"INSERT INTO materias (id, nome, carga_horaria) 
                                VALUES (@id, @nome, @cargaHoraria)
                                ON DUPLICATE KEY UPDATE 
                                nome = @nome, 
                                carga_horaria = @cargaHoraria";

                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id", materia.Id);
                    cmd.Parameters.AddWithValue("@nome", materia.Nome);
                    cmd.Parameters.AddWithValue("@cargaHoraria", materia.CargaHoraria);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Salva as notas e frequências no banco de dados
        /// </summary>
        private static void SaveNotasFrequenciasToDb(MySqlConnection connection)
        {
            foreach (var notaFreq in NotasFrequencias)
            {
                string query = @"INSERT INTO notas_frequencias (aluno_id, materia_id, nota1, nota2, nota3, nota4, horas_frequentadas) 
                                VALUES (@alunoId, @materiaId, @nota1, @nota2, @nota3, @nota4, @horasFrequentadas)
                                ON DUPLICATE KEY UPDATE 
                                nota1 = @nota1, 
                                nota2 = @nota2, 
                                nota3 = @nota3, 
                                nota4 = @nota4, 
                                horas_frequentadas = @horasFrequentadas";

                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@alunoId", notaFreq.AlunoId);
                    cmd.Parameters.AddWithValue("@materiaId", notaFreq.MateriaId);
                    cmd.Parameters.AddWithValue("@nota1", notaFreq.Nota1);
                    cmd.Parameters.AddWithValue("@nota2", notaFreq.Nota2);
                    cmd.Parameters.AddWithValue("@nota3", notaFreq.Nota3);
                    cmd.Parameters.AddWithValue("@nota4", notaFreq.Nota4);
                    cmd.Parameters.AddWithValue("@horasFrequentadas", notaFreq.HorasFrequentadas);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void LoadData()
        {
            bool dbAvailable = DbConnection.IsDbConnectionAvailable();

            if (dbAvailable)
            {
                try
                {
                    using (var connection = DbConnection.GetConnection())
                    {
                        // Clear existing in-memory data
                        Escolas.Clear();
                        Turmas.Clear();
                        Alunos.Clear();
                        Materias.Clear();
                        NotasFrequencias.Clear();

                        // Load data from database tables
                        LoadEscolasFromDb(connection);
                        LoadTurmasFromDb(connection);
                        LoadAlunosFromDb(connection);
                        LoadMateriasFromDb(connection);
                        LoadNotasFrequenciasFromDb(connection);
                    }
                    Console.WriteLine("Dados carregados com sucesso do MySQL.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao carregar do MySQL: {ex.Message}.");
                }
            }
            else
            {
                Console.WriteLine("MySQL não disponível. Dados não foram carregados.");
            }
        }

        // Helper methods to load data from each table
        private static void LoadEscolasFromDb(MySqlConnection connection)
        {
            string query = "SELECT id, nome_fantasia, razao_social, cnpj, endereco, telefone FROM escolas";
            using (var cmd = new MySqlCommand(query, connection))
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Escolas.Add(new Escola
                    {
                        Id = reader.GetInt32("id"),
                        NomeFantasia = reader.GetString("nome_fantasia"),
                        RazaoSocial = reader.GetString("razao_social"),
                        CNPJ = reader.GetString("cnpj"),
                        Endereco = reader.GetString("endereco"),
                        Telefone = reader.GetString("telefone")
                    });
                }
            }
        }

        private static void LoadTurmasFromDb(MySqlConnection connection)
        {
            string query = "SELECT id, escola_id, ano_letivo, serie FROM turmas";
            using (var cmd = new MySqlCommand(query, connection))
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Turmas.Add(new Turma
                    {
                        Id = reader.GetInt32("id"),
                        EscolaId = reader.GetInt32("escola_id"),
                        AnoLetivo = reader.GetString("ano_letivo"),
                        Serie = reader.GetString("serie")
                    });
                }
            }
        }

        private static void LoadAlunosFromDb(MySqlConnection connection)
        {
            string query = "SELECT id, turma_id, nome, cpf, situacao FROM alunos";
            using (var cmd = new MySqlCommand(query, connection))
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Alunos.Add(new Aluno
                    {
                        Id = reader.GetInt32("id"),
                        TurmaId = reader.GetInt32("turma_id"),
                        Nome = reader.GetString("nome"),
                        CPF = reader.GetString("cpf"),
                        Situacao = reader.GetString("situacao")
                    });
                }
            }
        }

        private static void LoadMateriasFromDb(MySqlConnection connection)
        {
            string query = "SELECT id, nome, carga_horaria FROM materias";
            using (var cmd = new MySqlCommand(query, connection))
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Materias.Add(new Materia
                    {
                        Id = reader.GetInt32("id"),
                        Nome = reader.GetString("nome"),
                        CargaHoraria = reader.GetInt32("carga_horaria")
                    });
                }
            }
        }

        private static void LoadNotasFrequenciasFromDb(MySqlConnection connection)
        {
            string query = "SELECT aluno_id, materia_id, nota1, nota2, nota3, nota4, horas_frequentadas FROM notas_frequencias";
            using (var cmd = new MySqlCommand(query, connection))
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    NotasFrequencias.Add(new NotaFrequencia
                    {
                        AlunoId = reader.GetInt32("aluno_id"),
                        MateriaId = reader.GetInt32("materia_id"),
                        Nota1 = reader.GetDouble("nota1"),
                        Nota2 = reader.GetDouble("nota2"),
                        Nota3 = reader.GetDouble("nota3"),
                        Nota4 = reader.GetDouble("nota4"),
                        HorasFrequentadas = reader.GetInt32("horas_frequentadas")
                    });
                }
            }
        }

        public static int GetNextEscolaId()
        {
            return Escolas.Any() ? Escolas.Max(e => e.Id) + 1 : 1;
        }

        public static int GetNextTurmaId()
        {
            return Turmas.Any() ? Turmas.Max(t => t.Id) + 1 : 1;
        }

        public static int GetNextAlunoId()
        {
            return Alunos.Any() ? Alunos.Max(a => a.Id) + 1 : 1;
        }

        public static int GetNextMateriaId()
        {
            return Materias.Any() ? Materias.Max(m => m.Id) + 1 : 1;
        }
    }

    public class Escola
    {
        public int Id { get; set; }
        public string NomeFantasia { get; set; }
        public string RazaoSocial { get; set; }
        public string CNPJ { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
    }

    public class Turma
    {
        public int Id { get; set; }
        public int EscolaId { get; set; }
        public string AnoLetivo { get; set; }
        public string Serie { get; set; }
    }

    public class Aluno
    {
        public int Id { get; set; }
        public int TurmaId { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Situacao { get; set; }
    }

    public class Materia
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int CargaHoraria { get; set; }
    }

    public class NotaFrequencia
    {
        public int AlunoId { get; set; }
        public int MateriaId { get; set; }
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }
        public double Nota3 { get; set; }
        public double Nota4 { get; set; }
        public int HorasFrequentadas { get; set; }
    }
}

