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

        private int GetHash(int key)
        {
            return key % size;
        }

        public void Insert(int key, T value)
        {
            int index = GetHash(key);
            buckets[index].Add(new KeyValuePair<int, T>(key, value));
        }

        public T Get(int key)
        {
            int index = GetHash(key);
            foreach (var kvp in buckets[index])
            {
                if (kvp.Key == key)
                    return kvp.Value;
            }
            return default; // Not found
        }

        public void Remove(int key)
        {
            int index = GetHash(key);
            buckets[index].RemoveAll(kvp => kvp.Key == key);
        }

        public List<T> GetAll()
        {
            List<T> allItems = new List<T>();
            foreach (var bucket in buckets)
            {
                foreach (var kvp in bucket)
                {
                    allItems.Add(kvp.Value);
                }
            }
            return allItems;
        }
    }
}
