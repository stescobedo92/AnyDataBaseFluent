#region License
// Copyright 2021 Sergio Triana Escobedo
#endregion

namespace AnyDataBaseFluent.Exception
{
	/// <summary>
	/// Represents errors that occur when creating a Firebird database.
	/// </summary>
	public class AnyDatabaseFluentFirebirdException : AnyDatabaseFluentDatabaseException
	{
		/// <summary>
		/// Creates a new instance of AnyDatabaseFluentFirebirdException.
		/// </summary>
		/// <param name="message">The error message.</param>
		public AnyDatabaseFluentFirebirdException( string message ) : base( message ) { }
	}
}
