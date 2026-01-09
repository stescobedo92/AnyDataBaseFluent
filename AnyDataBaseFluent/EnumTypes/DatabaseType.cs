using System;

namespace AnyDataBaseFluent.EnumTypes
{
    /// <summary>
    /// Defines the supported database types.
    /// </summary>
    public enum DatabaseType
    {
        /// <summary>
        /// SQLite - A lightweight, serverless, self-contained SQL database engine.
        /// </summary>
        SQLITE = 1,

        /// <summary>
        /// Microsoft SQL Server - Enterprise-grade relational database management system.
        /// </summary>
        SQLSERVER = 2,

        /// <summary>
        /// Oracle Database - Commercial enterprise database platform.
        /// </summary>
        ORACLE = 3,

        /// <summary>
        /// Microsoft Access - Desktop database management system.
        /// </summary>
        ACCESS = 4,

        /// <summary>
        /// PostgreSQL - Advanced open source relational database.
        /// </summary>
        POSTGRESQL = 5,

        /// <summary>
        /// MySQL - Popular open source relational database.
        /// </summary>
        MYSQL = 6,

        /// <summary>
        /// Firebird - Open source relational database with high compatibility.
        /// </summary>
        FIREBIRD = 7
    }
}
