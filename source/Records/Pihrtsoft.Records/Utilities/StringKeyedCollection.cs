﻿using System.Collections.Generic;

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
