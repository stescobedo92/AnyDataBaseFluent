#region License
// Copyright 2021 Sergio Triana Escobedo
#endregion

namespace AnyDataBaseFluent.Exception
{
	/// <summary>
	/// Represents errors that occur when creating a SQL Server database.
	/// </summary>
	public class AnyDataBaseFluentSqlServerException : AnyDatabaseFluentDatabaseException
	{
		/// <summary>
		/// Creates a new instance of AnyDataBaseFluentSqlServerException.
		/// </summary>
		/// <param name="message">The error message.</param>
		public AnyDataBaseFluentSqlServerException( string message ) : base( message ) { }
	}
}
