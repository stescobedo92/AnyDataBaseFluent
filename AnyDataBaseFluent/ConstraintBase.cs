using System.IO;
using AnyDataBaseFluent.EnumTypes;
using AnyDataBaseFluent.Interfaces;

namespace AnyDataBaseFluent
{
    /// <summary>
    /// Base class for creating a constraint. Use this instead of implementing <see cref="IConstraint"/> directly.
    /// </summary>
    public abstract class ConstraintBase : IConstraint
    {
        protected string Name { get; set; }
        protected ConstraintType Type { get; set; }
        protected string Schema { get; set; }
        protected string Table { get; set; }
        protected string Column { get; set; }
        protected string Expression { get; set; }

        /// <inheritdoc />
        public IConstraint WithName(string name)
        {
            Name = name;
            return this;
        }

        /// <inheritdoc />
        public IConstraint UsingSchema(string schema)
        {
            Schema = schema;
            return this;
        }

        /// <inheritdoc />
        public IConstraint OfType(ConstraintType type)
        {
            Type = type;
            return this;
        }

        /// <inheritdoc />
        public IConstraint HasReferenceTo(string tableName, string columnName)
        {
            Table = tableName;
            Column = columnName;
            return this;
        }

        /// <inheritdoc />
        public IConstraint WithExpression(string expression)
        {
            Expression = expression;
            return this;
        }

        /// <inheritdoc />
        public abstract void Write(StreamWriter writer);
    }
}
