using System;
using System.Collections.Generic;
using System.IO;
using AnyDataBaseFluent.Interfaces;

namespace AnyDataBaseFluent
{
    /// <summary>
    /// Base class for creating a table. Use this instead of implementing <see cref="ITable"/> directly.
    /// </summary>
    public abstract class TableBase : ITable
    {
        private bool _isSchemaFinal;

        protected string Schema { get; set; }
        protected string Name { get; set; }
        protected List<IColumn> Columns { get; }

        protected abstract void WriteTableBegin(StreamWriter writer);
        protected abstract void WriteTableEnd(StreamWriter writer);
        protected abstract IColumn CreateColumn();

        protected TableBase()
        {
            Columns = new List<IColumn>();
        }

        /// <inheritdoc />
        public ITable WithName(string name)
        {
            Name = name;
            return this;
        }

        /// <inheritdoc />
        public ITable UsingSchema(string schema)
        {
            if (!_isSchemaFinal)
            {
                Schema = schema;
            }
            return this;
        }

        /// <inheritdoc />
        public ITable UsingSchema(string schema, bool isFinal)
        {
            _isSchemaFinal = isFinal;
            Schema = schema;
            return this;
        }

        /// <inheritdoc />
        public ITable HasColumn(Action<IColumn> column)
        {
            var newColumn = CreateColumn();
            column.Invoke(newColumn);
            Columns.Add(newColumn);
            return this;
        }

        /// <inheritdoc />
        public void Write(StreamWriter writer)
        {
            WriteTableBegin(writer);
            
            for (var i = 0; i < Columns.Count; i++)
            {
                var column = Columns[i];
                column.UsingSchema(Schema);
                column.Write(writer);
                
                writer.WriteLine(i + 1 < Columns.Count ? "," : string.Empty);
            }
            
            WriteTableEnd(writer);
        }
    }
}
