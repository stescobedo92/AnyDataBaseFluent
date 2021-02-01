using AnyDataBaseFluent.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnyDataBaseFluent
{
    public abstract class ConstraintBase : IConstraint
    {
		protected string Name { get; set; }
		protected ConstraintType Type { get; set; }
		protected string Schema { get; set; }
		protected string Table { get; set; }
		protected string Column { get; set; }
		protected string Expression { get; set; }

		public IConstraint WithName(string name)
		{
			Name = name;
			return this;
		}

		public IConstraint UsingSchema(string schema)
		{
			Schema = schema;
			return this;
		}

		public IConstraint OfType(ConstraintType type)
		{
			Type = type;
			return this;
		}

		public IConstraint HasReferenceTo(string tableName, string columnName)
		{
			Table = tableName;
			Column = columnName;
			return this;
		}

		public IConstraint WithExpression(string expression)
		{
			Expression = expression;
			return this;
		}

		public abstract void Write(StreamWriter writer);
	}
}
