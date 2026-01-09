#region License
// Copyright 2021 Sergio Triana Escobedo
#endregion

using System.IO;
using AnyDataBaseFluent.Exception;
using AnyDataBaseFluent.Interfaces;
using AnyDataBaseFluent.Resources;

namespace AnyDataBaseFluent.MySql
{
	public class Table : TableBase
	{
		protected override void WriteTableBegin(StreamWriter writer)
		{
			if (string.IsNullOrEmpty(Name))
			{
				throw new AnyDataBaseFluentMySqlException(Resource_Designer.TableNameEmptyErrorMessage);
			}

			writer.WriteLine($"CREATE TABLE `{Schema}`.`{Name}`");
			writer.WriteLine("(");
		}

		protected override void WriteTableEnd(StreamWriter writer) => writer.WriteLine(")");

		protected override IColumn CreateColumn() => new Column();
	}
}