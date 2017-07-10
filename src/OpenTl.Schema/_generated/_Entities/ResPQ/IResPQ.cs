﻿// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IResPQ : IObject
    {
        byte[] Nonce {get; set;}

        byte[] ServerNonce {get; set;}

        string Pq {get; set;}

        TVector<long> ServerPublicKeyFingerprints {get; set;}

    }
}