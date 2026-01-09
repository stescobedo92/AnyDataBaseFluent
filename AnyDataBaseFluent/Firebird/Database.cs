#region License
// Copyright 2021 Sergio Triana Escobedo
#endregion

using System.IO;
using AnyDataBaseFluent.Interfaces;

namespace AnyDataBaseFluent.Firebird
{
	public class Database : DatabaseBase
	{
		protected override ITable CreateTable() => new Table();

		protected override void WriteUse(StreamWriter writer)
		{
			// Firebird typically connects to a specific database file, USE is not common in script
			if (!string.IsNullOrEmpty(Name))
			{
				writer.WriteLine($"CONNECT '{Name}';");
			}
		}
	}
}