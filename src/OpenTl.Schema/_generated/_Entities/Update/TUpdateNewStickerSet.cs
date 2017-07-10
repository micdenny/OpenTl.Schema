﻿// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x688a30aa)]
	public class TUpdateNewStickerSet : IUpdate
	{
       [SerializationOrder(0)]
       public Messages.IStickerSet Stickerset {get; set;}

	}
}