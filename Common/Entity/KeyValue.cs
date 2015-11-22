using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Entity
{
    public class KeyValue<TKey, TValue>
    {
        public KeyValue(TKey pKey, TValue pValue)
        {
            Key = pKey;
            Value = pValue;
        }

        public TKey Key;
        public TValue Value;

        public override string ToString()
        {
            return Key.ToString();
        }
    }
}
