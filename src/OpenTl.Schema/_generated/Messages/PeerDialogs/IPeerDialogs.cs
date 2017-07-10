﻿// ReSharper disable All

namespace OpenTl.Schema.Messages
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IPeerDialogs : IObject
    {
        TVector<IDialog> Dialogs {get; set;}

        TVector<IMessage> Messages {get; set;}

        TVector<IChat> Chats {get; set;}

        TVector<IUser> Users {get; set;}

        Updates.IState State {get; set;}

    }
}