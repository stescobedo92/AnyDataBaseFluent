#region License
// Copyright 2021 Sergio Triana Escobedo
#endregion
using System;
using System.IO;

namespace AnyDataBaseFluent.Firebird
{
	public class Database : DatabaseBase
	{
		protected override ITable CreateTable()
		{
			return new Table();
		}

		protected override void WriteUse( StreamWriter writer )
		{
		}
	}
}