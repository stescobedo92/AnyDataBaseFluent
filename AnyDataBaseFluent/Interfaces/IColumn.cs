﻿using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnyDataBaseFluent.Interfaces
{
    /// <summary>
	/// Template for creating a column.
	/// </summary>
    public interface IColumn
    {
		/// <summary>
		/// Set the name of the column.
		/// </summary>
		/// <param name="name">The name.</param>
		IColumn WithName(string name);

		/// <summary>
		/// Sets the name of the schema.
		/// </summary>
		/// <param name="schema">The schema.</param>
		IColumn UsingSchema(string schema);

		/// <summary>
		/// Sets the type of the column.
		/// </summary>
		/// <param name="type">The type.</param>
		IColumn OfType(SqlDbType type);

		/// <summary>
		/// Sets the type and size of the column.
		/// </summary>
		/// <param name="type">The type.</param>
		/// <param name="size">The size.</param>
		IColumn OfType(SqlDbType type, int size);

		/// <summary>
		/// Sets the column to be auto incrementing.
		/// </summary>
		IColumn IsAutoIncrementing();

		/// <summary>
		/// Adds a constraint to the column.
		/// </summary>
		/// <param name="constraint">The added constraint.</param>
		IColumn HasConstraint(Action<IConstraint> constraint);

		/// <summary>
		/// Writes the column and all subsequent children to writer.
		/// </summary>
		/// <param name="writer"></param>
		void Write(StreamWriter writer);
	}
}
