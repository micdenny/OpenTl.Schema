﻿// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xca4c79d8)]
    public class RequestEditChatPhoto : IRequest<IUpdates>
    {
       [SerializationOrder(0)]
       public int ChatId {get; set;}

       [SerializationOrder(1)]
       public IInputChatPhoto Photo {get; set;}

    }
}