﻿using System;

namespace TwentyTwenty.IdentityServer4.EntityFramework7.Entities
{
    public class ClientScope<TKey>
        where TKey : IEquatable<TKey>
    {
        public virtual TKey Id { get; set; }

        public virtual string Scope { get; set; }

        public virtual Client<TKey> Client { get; set; }
    }
}