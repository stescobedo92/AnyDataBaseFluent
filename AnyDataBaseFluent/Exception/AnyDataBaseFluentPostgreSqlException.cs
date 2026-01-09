#region License
// Copyright 2021 Sergio Triana Escobedo
#endregion

namespace AnyDataBaseFluent.Exception
{
	/// <summary>
	/// Represents errors that occur when creating a PostgreSQL database.
	/// </summary>
	public class AnyDataBaseFluentPostgreSqlException : AnyDatabaseFluentDatabaseException
	{
		/// <summary>
		/// Creates a new instance of AnyDataBaseFluentPostgreSqlException.
		/// </summary>
		/// <param name="message">The error message.</param>
		public AnyDataBaseFluentPostgreSqlException( string message ) : base( message ) { }
	}
}
