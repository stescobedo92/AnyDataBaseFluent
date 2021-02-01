#region License
// Copyright 2021 Sergio Triana Escobedo
#endregion
namespace AnyDataBaseFluent.Firebird
{
	/// <summary>
	/// Represents errors that occur when creating a Firebird database.
	/// </summary>
	public class AnyDataBaseFluentSqliteException : AnyDataBaseFluentException
	{
		/// <summary>
		/// Creates a new instance of FluentDatabaseFirebirdException.
		/// </summary>
		/// <param name="message"></param>
		public AnyDataBaseFluentSqliteException( string message ) : base( message ) { }
	}
}