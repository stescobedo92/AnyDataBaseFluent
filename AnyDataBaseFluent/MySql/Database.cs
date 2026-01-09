#region License
// Copyright 2021 Sergio Triana Escobedo
#endregion

using System.IO;
using AnyDataBaseFluent.Interfaces;

namespace AnyDataBaseFluent.MySql
{
	public class Database : DatabaseBase
	{
		protected override ITable CreateTable() => new Table();

		protected override void WriteUse(StreamWriter writer)
		{
			if (!string.IsNullOrEmpty(Name))
			{
				writer.WriteLine($"USE `{Name}`");
			}
		}
	}
}