namespace AnyDataBaseFluent.Exception
{
    /// <summary>
    /// Represents errors that occur when using AnyDataBaseFluent.
    /// </summary>
    public class AnyDatabaseFluentDatabaseException : System.Exception
    {
        /// <summary>
        /// Creates a new instance of AnyDatabaseFluentDatabaseException.
        /// </summary>
        /// <param name="message">The error message.</param>
        public AnyDatabaseFluentDatabaseException(string message) : base(message) { }
    }
}
