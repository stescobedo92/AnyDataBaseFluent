#region License
// Copyright 2021 Sergio Triana Escobedo
#endregion

namespace AnyDataBaseFluent.Exception
{
	/// <summary>
	/// Represents errors that occur when creating an Oracle database.
	/// </summary>
	public class AnyDataBaseFluentOracleException : AnyDatabaseFluentDatabaseException
	{
		/// <summary>
		/// Creates a new instance of AnyDataBaseFluentOracleException.
		/// </summary>
		/// <param name="message">The error message.</param>
		public AnyDataBaseFluentOracleException( string message ) : base( message ) { }
	}
}
