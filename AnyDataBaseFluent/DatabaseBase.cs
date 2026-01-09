using System;
using System.Collections.Generic;
using System.IO;
using AnyDataBaseFluent.Interfaces;

namespace AnyDataBaseFluent
{
    /// <summary>
    /// Base class for creating a database. Use this instead of implementing <see cref="IDatabase"/> directly.
    /// </summary>
    public abstract class DatabaseBase : IDatabase
    {
        protected string Name { get; set; }
        protected string Schema { get; set; }
        protected List<ITable> Tables { get; }

        protected abstract ITable CreateTable();
        protected abstract void WriteUse(StreamWriter writer);

        protected DatabaseBase()
        {
            Tables = new List<ITable>();
            Schema = "dbo";
        }

        /// <inheritdoc />
        public IDatabase WithName(string name)
        {
            Name = name;
            return this;
        }

        /// <inheritdoc />
        public IDatabase UsingSchema(string schema)
        {
            Schema = schema;
            return this;
        }

        /// <inheritdoc />
        public IDatabase HasTable(Action<ITable> table)
        {
            var newTable = CreateTable();
            table.Invoke(newTable);
            Tables.Add(newTable);
            return this;
        }

        /// <inheritdoc />
        public void Write(StreamWriter writer)
        {
            WriteUse(writer);
            writer.WriteLine();
            
            foreach (var table in Tables)
            {
                table.UsingSchema(Schema);
                table.Write(writer);
                writer.WriteLine();
            }
        }
    }
}
