using System;
using System.Collections.Generic;

namespace PostalCW.DataStructures
{
    public class HashTable<T>
    {
        private readonly int size = 100;
        private List<KeyValuePair<int, T>>[] buckets;

        public HashTable()
        {
            buckets = new List<KeyValuePair<int, T>>[size];
            for (int i = 0; i < size; i++)
            {
                buckets[i] = new List<KeyValuePair<int, T>>();
            }
        }

    }
}
