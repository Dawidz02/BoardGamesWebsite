using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Org.BouncyCastle.Math.EC.ECCurve;

namespace DataLibrary
{
    public class DataAccess : IDataAccess
    {
        public async Task<List<T>> LoadData<T, U>(string sql, U parameters, string connectionString)
        {
            using (IDbConnection connection = new MySqlConnection(connectionString))
            {
                var rows = await connection.QueryAsync<T>(sql, parameters);
                return rows.ToList();
            }
        }

        public async Task SaveData<T>(string sql, T parameters, string connectionString)
        {
            using (IDbConnection connection = new MySqlConnection(connectionString))
            {
                await connection.ExecuteAsync(sql, parameters);
            }
        }

        public async Task<int?> GetIdByName(string tableName, string nameValue, string connectionString)
        {
            string sql = $"SELECT Id FROM {tableName} WHERE GameName = @Name;";

            using (IDbConnection connection = new MySqlConnection(connectionString))
            {
                var result = await connection.ExecuteScalarAsync<int?>(sql, new { Name = nameValue });

                return result;
            }
        }
    }
}
