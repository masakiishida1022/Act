using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Act.Domain.Entities;
using Act.Domain.ValueObjects;
using Microsoft.Data.Sqlite;

namespace Act.Infrastructure.SQLite
{
    public sealed class ControllerSQLite
    {
        public IReadOnlyList<ControllerEntity> GetData()
        {
            
            string sql = @"
select Model
from ControllerTabe
where Model = model
LIMIT 1
";
            return SQLiteHelper.Query<ControllerEntity>(sql, CreateEntity);
        }

        private ControllerEntity CreateEntity(SqliteDataReader reader)
        {
            Model model = new Model(Convert.ToString(reader["Model"]));
            return new ControllerEntity(model);
        }
    }
}
