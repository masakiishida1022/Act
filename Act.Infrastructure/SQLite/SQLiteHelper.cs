using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act.Infrastructure.SQLite
{
    internal class SQLiteHelper
    {
        internal const string ConnectionString = @"C:\Users\masaki\OneDrive\デスクトップ\ActData.db";

        internal static IReadOnlyList<T> Query<T>(string sql,Func<SqliteDataReader,T> createEntity)
        {
            var result = new List<T>();
            using (var connection = new SqliteConnection(SQLiteHelper.ConnectionString))
            using (var command = new SqliteCommand(sql, connection))
            {
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        result.Add(createEntity(reader));
                    }
                }
            }

            return result;
        }
    }
}
