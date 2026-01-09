#region License
// Copyright 2021 Sergio Triana Escobedo
#endregion

namespace AnyDataBaseFluent.Exception
{
	/// <summary>
	/// Represents errors that occur when creating a MySQL database.
	/// </summary>
	public class AnyDataBaseFluentMySqlException : AnyDatabaseFluentDatabaseException
	{
		/// <summary>
		/// Creates a new instance of AnyDataBaseFluentMySqlException.
		/// </summary>
		/// <param name="message">The error message.</param>
		public AnyDataBaseFluentMySqlException( string message ) : base( message ) { }
	}
}
