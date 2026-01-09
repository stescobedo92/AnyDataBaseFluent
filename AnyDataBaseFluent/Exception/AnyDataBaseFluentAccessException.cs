#region License
// Copyright 2021 Sergio Triana Escobedo
#endregion

namespace AnyDataBaseFluent.Exception
{
	/// <summary>
	/// Represents errors that occur when creating an Access database.
	/// </summary>
	public class AnyDataBaseFluentAccessException : AnyDatabaseFluentDatabaseException
	{
		/// <summary>
		/// Creates a new instance of AnyDataBaseFluentAccessException.
		/// </summary>
		/// <param name="message">The error message.</param>
		public AnyDataBaseFluentAccessException( string message ) : base( message ) { }
	}
}
