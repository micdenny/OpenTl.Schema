﻿// ReSharper disable All

namespace OpenTl.Schema.Updates
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x2064674e)]
	public class TChannelDifference : IChannelDifference
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool Final {get; set;}

       [SerializationOrder(2)]
       public int Pts {get; set;}

       [SerializationOrder(3)]
       [CanSerialize("Flags", 1)]
       public int Timeout {get; set;}

       [SerializationOrder(4)]
       public TVector<IMessage> NewMessages {get; set;}

       [SerializationOrder(5)]
       public TVector<IUpdate> OtherUpdates {get; set;}

       [SerializationOrder(6)]
       public TVector<IChat> Chats {get; set;}

       [SerializationOrder(7)]
       public TVector<IUser> Users {get; set;}

	}
}