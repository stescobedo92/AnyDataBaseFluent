using System;
using AnyDataBaseFluent.EnumTypes;
using AnyDataBaseFluent.Interfaces;

namespace AnyDataBaseFluent
{
    /// <summary>
    /// Factory class for creating database instances based on the database type.
    /// </summary>
    public static class DatabaseFactory
    {
        /// <summary>
        /// Creates a new database instance for the specified database type.
        /// </summary>
        /// <param name="databaseType">The type of database to create.</param>
        /// <returns>A new instance of <see cref="IDatabase"/>.</returns>
        /// <exception cref="NotSupportedException">Thrown when the database type is not supported.</exception>
        public static IDatabase Create(DatabaseType databaseType) => databaseType switch
        {
            DatabaseType.ACCESS => new Access.Database(),
            DatabaseType.FIREBIRD => new Firebird.Database(),
            DatabaseType.MYSQL => new MySql.Database(),
            DatabaseType.ORACLE => new Oracle.Database(),
            DatabaseType.POSTGRESQL => new PostgreSql.Database(),
            DatabaseType.SQLITE => new Sqlite.Database(),
            DatabaseType.SQLSERVER => new SqlServer.Database(),
            _ => throw new NotSupportedException($"Database server '{databaseType}' is not supported.")
        };
    }
}
