#region License
// Copyright 2021 Sergio Triana Escobedo
#endregion
using System;
using System.IO;
using AnyDataBaseFluent.Interfaces;

namespace AnyDataBaseFluent.MySql
{
	public class Database : DatabaseBase
	{
		protected override ITable CreateTable()
		{
			return new Table();
		}

		protected override void WriteUse( StreamWriter writer )
		{
			if( !string.IsNullOrEmpty( Name ) )
			{
				writer.WriteLine( string.Format( "USE [{0}]", Name ) );
			}
		}
	}
}