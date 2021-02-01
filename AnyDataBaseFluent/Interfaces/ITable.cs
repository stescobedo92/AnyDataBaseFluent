﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnyDataBaseFluent.Interfaces
{
    /// <summary>
    /// Template for creating a table.
    /// </summary>
    public interface ITable
    {
		/// <summary>
		/// Set the name of the table.
		/// </summary>
		/// <param name="name">The name of the table.</param>
		ITable WithName(string name);

		/// <summary>
		/// Sets the name of the schema.
		/// </summary>
		/// <param name="schema">The name of the schema.</param>
		ITable UsingSchema(string schema);

		/// <summary>
		/// Sets the name of the schema. When <see cref="IDatabase.Write"/>
		/// is called, the schema is passed down. Set isFinal to true override this behavior.
		/// </summary>
		/// <param name="schema">The schema to create the table with.</param>
		/// <param name="isFinal">True to make the the schema immutable.</param>
		ITable UsingSchema(string schema, bool isFinal);

		/// <summary>
		/// Add a column to the table.
		/// </summary>
		/// <param name="column">The added column.</param>
		ITable HasColumn(Action<IColumn> column);

		/// <summary>
		/// Writes the table and all subsequent children to writer.
		/// </summary>
		/// <param name="writer">The writer.</param>
		void Write(StreamWriter writer);
	}
}
