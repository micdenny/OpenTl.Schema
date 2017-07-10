﻿// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xf9d27a5a)]
	public class TUpdateInlineBotCallbackQuery : IUpdate
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       public long QueryId {get; set;}

       [SerializationOrder(2)]
       public int UserId {get; set;}

       [SerializationOrder(3)]
       public IInputBotInlineMessageID MsgId {get; set;}

       [SerializationOrder(4)]
       public long ChatInstance {get; set;}

       [SerializationOrder(5)]
       [CanSerialize("Flags", 0)]
       public byte[] Data {get; set;}

       [SerializationOrder(6)]
       [CanSerialize("Flags", 1)]
       public string GameShortName {get; set;}

	}
}