using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnyDataBaseFluent.EnumTypes;

namespace AnyDataBaseFluent
{
    public static class DatabaseFactory
    {
		public static IDatabase Create(DatabaseType databaseServer)
		{
			switch (databaseServer)
			{
				case DatabaseType.ACCESS: return new Access.Database();
				case DatabaseType.FIREBIRD:	return new Firebird.Database();
				case DatabaseType.MYSQL: return new MySql.Database();
				case DatabaseType.ORACLE: return new Oracle.Database();
				case DatabaseType.POSTGRESQL: return new PostgreSql.Database();
				case DatabaseType.SQLITE: return new Sqlite.Database();
				case DatabaseType.SQLSERVER: return new SqlServer.Database();
				default: throw new NotSupportedException(string.Format("Database server '{0}' is not supported.", databaseServer));
			}
		}
	}
}
