﻿// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x78d4dec1)]
	public class TUpdateShort : IUpdates
	{
       [SerializationOrder(0)]
       public IUpdate Update {get; set;}

       [SerializationOrder(1)]
       public int Date {get; set;}

	}
}