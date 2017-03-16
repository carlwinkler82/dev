﻿// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;

namespace Pihrtsoft.Records.Utilities
{
    internal abstract class StringKeyedCollection<TValue> : ExtendedKeyedCollection<string, TValue> where TValue : IKey<string>
    {
        protected StringKeyedCollection()
        {
        }

        protected StringKeyedCollection(IList<TValue> list)
            : base(list)
        {
        }

        protected StringKeyedCollection(IEqualityComparer<string> comparer)
            : base(comparer)
        {
        }

        protected StringKeyedCollection(IList<TValue> list, IEqualityComparer<string> comparer)
            : base(list, comparer)
        {
        }
    }
}
