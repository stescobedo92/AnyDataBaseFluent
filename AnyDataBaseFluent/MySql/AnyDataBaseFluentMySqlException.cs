#region License
// Copyright 2021 Sergio Triana Escobedo
#endregion

using AnyDataBaseFluent.Exception;

namespace AnyDataBaseFluent.MySql
{
	/// <summary>
	/// Represents errors that occur when creating a Firebird database.
	/// </summary>
	public class AnyDataBaseFluentMySqlException : AnyDatabaseFluentDatabaseException
	{
		/// <summary>
		/// Creates a new instance of FluentDatabaseFirebirdException.
		/// </summary>
		/// <param name="message"></param>
		public AnyDataBaseFluentMySqlException( string message ) : base( message ) { }
	}
}