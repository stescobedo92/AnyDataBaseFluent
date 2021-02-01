using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnyDataBaseFluent.Exception
{
	/// <summary>
	/// Represents errors that occur when using FluentDatabase.
	/// </summary>
	public class AnyDatabaseFluentDatabaseException : System.Exception
    {
        /// <summary>
		/// Creates a new instance of FluentDatabaseException.
		/// </summary>
		/// <param name="message">The error message.</param>
		public AnyDatabaseFluentDatabaseException(string message) : base(message) { }
    }
}
