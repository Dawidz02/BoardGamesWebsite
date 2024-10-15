
namespace DataLibrary
{
    public interface IDataAccess
    {
        Task<List<T>> LoadData<T, U>(string sql, U parameters, string connectionString);
        Task SaveData<T>(string sql, T parameters, string connectionString);
        Task<int?> GetIdByName(string tableName, string nameValue, string connectionString);
    }
}