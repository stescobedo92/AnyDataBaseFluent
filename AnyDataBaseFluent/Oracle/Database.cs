#region License
// Copyright 2021 Sergio Triana Escobedo
#endregion

using System.IO;
using AnyDataBaseFluent.Interfaces;

namespace AnyDataBaseFluent.Oracle
{
	public class Database : DatabaseBase
	{
		protected override ITable CreateTable() => new Table();

		protected override void WriteUse(StreamWriter writer)
		{
			if (!string.IsNullOrEmpty(Name))
			{
				writer.WriteLine($"ALTER SESSION SET CURRENT_SCHEMA = {Name};");
			}
		}
	}
}