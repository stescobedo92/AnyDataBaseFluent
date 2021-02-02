#region License
// Copyright 2021 Sergio Triana Escobedo
#endregion
using System;
using System.IO;
using AnyDataBaseFluent.Firebird;
using AnyDataBaseFluent.Interfaces;
using AnyDataBaseFluent.Resources;

namespace AnyDataBaseFluent.PostgreSql
{
	public class Table : TableBase
	{
		protected override void WriteTableBegin( StreamWriter writer )
		{
			if( string.IsNullOrEmpty( Name ) )
			{
				throw new AnyDataBaseFluentPostgreSqlException( Resource_Designer.TableNameEmptyErrorMessage );
			}

			writer.WriteLine( string.Format( "CREATE TABLE [{0}].[{1}]", Schema, Name ) );
			writer.WriteLine( "(" );
		}

		protected override void WriteTableEnd( StreamWriter writer )
		{
			writer.WriteLine( ")" );
		}

		protected override IColumn CreateColumn()
		{
			return new Column();
		}
	}
}