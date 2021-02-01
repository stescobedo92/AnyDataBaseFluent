#region License
// Copyright 2021 Sergio Triana Escobedo
#endregion

using AnyDataBaseFluent.Exception;

namespace AnyDataBaseFluent.SqlServer
{
	/// <summary>
	/// Represents errors that occur when creating a Firebird database.
	/// </summary>
	public class AnyDataBaseFluentSqlServerException : AnyDatabaseFluentDatabaseException
	{
		/// <summary>
		/// Creates a new instance of FluentDatabaseFirebirdException.
		/// </summary>
		/// <param name="message"></param>
		public AnyDataBaseFluentSqlServerException( string message ) : base( message ) { }
	}
}