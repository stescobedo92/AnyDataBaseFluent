#region License
// Copyright 2021 Sergio Triana Escobedo
#endregion
using System;
using System.IO;

namespace AnyDatabase.Access
{
	public class Column : ColumnBase
	{
		protected override void WriteColumn( StreamWriter writer )
		{
		}

		protected override IConstraint CreateConstraint()
		{
			return new Constraint();
		}
	}
}