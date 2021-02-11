﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using CoreWCF.Channels;

namespace CoreWCF.Dispatcher
{
    internal interface IInstanceContextInitializer
    {
        // message=null for singleton
        void Initialize(InstanceContext instanceContext, Message message);
    }
}