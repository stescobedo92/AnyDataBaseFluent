﻿#region License
// Copyright 2021 Sergio Triana Escobedo
#endregion
using System;
using System.IO;

namespace AnyDataBaseFluent.Access
{
	public class Table : TableBase
	{
		protected override void WriteTableBegin( StreamWriter writer )
		{
		}

		protected override void WriteTableEnd( StreamWriter writer )
		{
		}

		protected override IColumn CreateColumn()
		{
			return new Column();
		}
	}
}