#region License
// Copyright 2021 Sergio Triana Escobedo
#endregion

using AnyDataBaseFluent.Exception;

namespace AnyDatabase.Access
{
	/// <summary>
	/// Represents errors that occur when creating a Access database.
	/// </summary>
	public class AnyDatabaseAccessException : AnyDatabaseFluentDatabaseException
	{
		/// <summary>
		/// Creates a new instance of FluentDatabaseAccessException.
		/// </summary>
		/// <param name="message"></param>
		public AnyDatabaseAccessException( string message ) : base( message ) { }
	}
}