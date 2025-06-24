using MySql.Data.MySqlClient;
using System;

namespace EscolaSystem
{
    public static class DbConnection
    {
        private static string ConnectionString = "Server=127.0.0.1;Port=3306;Database=escolasystem;Uid=root;"; // Altere conforme sua configuração

        public static MySqlConnection GetConnection()
        {
            MySqlConnection connection = new MySqlConnection(ConnectionString);
            try
            {
                connection.Open();
                Console.WriteLine("Conexão com o MySQL aberta com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao abrir conexão com o MySQL: {ex.Message}");
                throw;
            }
            return connection;
        }

        public static void CloseConnection(MySqlConnection connection)
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                try
                {
                    connection.Close();
                    Console.WriteLine("Conexão com o MySQL fechada com sucesso!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao fechar conexão com o MySQL: {ex.Message}");
                    throw;
                }
            }
        }

        /// <summary>
        /// Verifica se a conexão com o banco de dados MySQL está disponível
        /// </summary>
        /// <returns>True se a conexão estiver disponível, False caso contrário</returns>
        public static bool IsDbConnectionAvailable()
        {
            try
            {
                using (var connection = new MySqlConnection(ConnectionString))
                {
                    connection.Open();
                    return connection.State == System.Data.ConnectionState.Open;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Banco de dados MySQL não disponível: {ex.Message}");
                return false;
            }
        }
    }
}

