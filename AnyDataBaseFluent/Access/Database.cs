#region License
// Copyright 2021 Sergio Triana Escobedo
#endregion

using System.IO;
using AnyDataBaseFluent.Interfaces;

namespace AnyDataBaseFluent.Access
{
	public class Database : DatabaseBase
	{
		protected override ITable CreateTable() => new Table();

		protected override void WriteUse(StreamWriter writer)
		{
			// Access does not support USE
		}
	}
}