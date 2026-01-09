#region License
// Copyright 2021 Sergio Triana Escobedo
#endregion

using System.IO;
using AnyDataBaseFluent.Exception;
using AnyDataBaseFluent.Interfaces;
using AnyDataBaseFluent.Resources;

namespace AnyDataBaseFluent.Sqlite
{
	public class Table : TableBase
	{
		protected override void WriteTableBegin(StreamWriter writer)
		{
			if (string.IsNullOrEmpty(Name))
			{
				throw new AnyDataBaseFluentSqliteException(Resource_Designer.TableNameEmptyErrorMessage);
			}

			// SQLite usually just uses table name, schema is attached to connection
			writer.WriteLine($"CREATE TABLE \"{Name}\"");
			writer.WriteLine("(");
		}

		protected override void WriteTableEnd(StreamWriter writer) => writer.WriteLine(")");

		protected override IColumn CreateColumn() => new Column();
	}
}