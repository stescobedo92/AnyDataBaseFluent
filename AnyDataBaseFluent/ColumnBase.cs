using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using AnyDataBaseFluent.Interfaces;

namespace AnyDataBaseFluent
{
    /// <summary>
    /// Base class for creating a column. Use this instead of implementing <see cref="IColumn"/> directly.
    /// </summary>
    public abstract class ColumnBase : IColumn
    {
        protected string Schema { get; set; }
        protected string Name { get; set; }
        protected SqlDbType Type { get; set; }
        protected int Size { get; set; }
        protected bool AutoIncrementing { get; set; }
        protected List<IConstraint> Constraints { get; }

        protected abstract void WriteColumn(StreamWriter writer);
        protected abstract IConstraint CreateConstraint();

        protected ColumnBase()
        {
            Constraints = new List<IConstraint>();
        }

        /// <inheritdoc />
        public IColumn WithName(string name)
        {
            Name = name;
            return this;
        }

        /// <inheritdoc />
        public IColumn UsingSchema(string schema)
        {
            Schema = schema;
            return this;
        }

        /// <inheritdoc />
        public IColumn OfType(SqlDbType type)
        {
            Type = type;
            return this;
        }

        /// <inheritdoc />
        public IColumn OfType(SqlDbType type, int size)
        {
            Type = type;
            Size = size;
            return this;
        }

        /// <inheritdoc />
        public IColumn IsAutoIncrementing()
        {
            AutoIncrementing = true;
            return this;
        }

        /// <inheritdoc />
        public IColumn HasConstraint(Action<IConstraint> constraint)
        {
            var newConstraint = CreateConstraint();
            constraint.Invoke(newConstraint);
            Constraints.Add(newConstraint);
            return this;
        }

        /// <inheritdoc />
        public void Write(StreamWriter writer)
        {
            WriteColumn(writer);
            
            foreach (var constraint in Constraints)
            {
                constraint.UsingSchema(Schema);
                constraint.Write(writer);
            }
        }
    }
}
