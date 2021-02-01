#region License
// Copyright 2021 Sergio Triana Escobedo
#endregion

using AnyDataBaseFluent.Exception;

namespace AnyDataBaseFluent.Firebird
{
	/// <summary>
	/// Represents errors that occur when creating a Firebird database.
	/// </summary>
	public class AnyDatabaseFluentFirebirdException : AnyDatabaseFluentDatabaseException
	{
		/// <summary>
		/// Creates a new instance of AnyDatabaseFluentFirebirdException.
		/// </summary>
		/// <param name="message"></param>
		public AnyDatabaseFluentFirebirdException( string message ) : base( message ) { }
	}
}