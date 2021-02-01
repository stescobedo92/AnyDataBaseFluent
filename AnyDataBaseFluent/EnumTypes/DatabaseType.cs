using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnyDataBaseFluent.EnumTypes
{
    public enum DatabaseType
    {
		/// <summary>
		/// SQLite is a software library that implements a self-contained, serverless, zero-configuration, 
		/// transactional SQL database engine.
		/// http://sqlite.org
		/// </summary>
		SQLITE = 1,

		/// <summary>
		/// Microsoft SQL Server.
		/// http://www.microsoft.com/sql
		/// </summary>
		SQLSERVER = 2,

		/// <summary>
		/// Oracle Database runs on all industry-standard platforms and moves from a single instance 
		/// to Grid Computing without changing a single line of code.
		/// http://www.oracle.com
		/// </summary>
		ORACLE = 3,

		/// <summary>
		/// Microsoft Access.
		/// http://office.microsoft.com/access
		/// </summary>
		ACCESS = 4,

		/// <summary>
		/// The world's most advanced open source database.
		/// http://www.postgresql.org
		/// </summary>
		POSTGRESQL = 5,

		/// <summary>
		/// The world's most popular open source database.
		/// http://www.mysql.com
		/// </summary>
		MYSQL = 6,

		/// <summary>
		/// The RDBMS that's going where you're going.
		/// http://firebirdsql.org
		/// </summary>
		FIREBIRD = 7
	}
}
