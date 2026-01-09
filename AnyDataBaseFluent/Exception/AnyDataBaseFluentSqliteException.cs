#region License
// Copyright 2021 Sergio Triana Escobedo
#endregion

namespace AnyDataBaseFluent.Exception
{
	/// <summary>
	/// Represents errors that occur when creating a SQLite database.
	/// </summary>
	public class AnyDataBaseFluentSqliteException : AnyDatabaseFluentDatabaseException
	{
		/// <summary>
		/// Creates a new instance of AnyDataBaseFluentSqliteException.
		/// </summary>
		/// <param name="message">The error message.</param>
		public AnyDataBaseFluentSqliteException( string message ) : base( message ) { }
	}
}
