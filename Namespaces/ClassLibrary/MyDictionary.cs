using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNamespace
{
    public class MyDictionary<TKey, TValue> : IEnumerable
    {
        TKey[] keys;
        TValue[] values;

        public int Count { get { return keys.Length; } }

        public string this[int index]
        {
            get { return $"Key : {keys[index]} | Value : {values[index]}"; }
        }

        public MyDictionary()
        {
            keys = new TKey[0];
            values = new TValue[0];
        }

        public void Add(TKey key, TValue value)
        {
            var tempKeys = keys;
            var tempValues = values;

            keys = new TKey[tempKeys.Length + 1];
            values = new TValue[tempValues.Length + 1];

            for (int i = 0; i < keys.Length - 1; i++)
            {
                keys[i] = tempKeys[i];
                values[i] = tempValues[i];
            }

            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;

        }

        /// <summary>
        /// Adding new items to dictionary
        /// </summary>
        /// <param name="keys">Names</param>
        /// <param name="values">Surenames</param>
        public void Add(TKey[] keys, TValue[] values)
        {
            var tempKeys = this.keys;
            var tempValues = this.values;

            this.keys = new TKey[tempKeys.Length + keys.Length];
            this.values = new TValue[tempValues.Length + values.Length];

            for (int i = 0; i < this.keys.Length; i++)
            {
                if (i < tempKeys.Length)
                {
                    this.keys[i] = tempKeys[i];
                    this.values[i] = tempValues[i];
                }

                if (i >= tempKeys.Length)
                {
                    this.keys[i] = keys[i - tempKeys.Length];
                    this.values[i] = values[i - tempValues.Length];
                }
            }
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < keys.Length; i++)
            {
                yield return keys[i];
                yield return values[i];
            }
        }

    }
}
