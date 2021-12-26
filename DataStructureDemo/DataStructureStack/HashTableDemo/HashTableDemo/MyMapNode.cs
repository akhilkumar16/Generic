using System;
using System.Collections.Generic;
using System.Text;

namespace HashTableDemo
{
    public class MyMapNode<K, V>
    {
        private readonly int size;
        private readonly LinkedList<KeyValue<K, V>>[] items;

        public MyMapNode(int size)
        {
            this.size = size;
            this.items = new LinkedList<KeyValue<K, V>>[size];
        }
        protected int GetArrayPosition(K key)
        {
            int position = key.GetHashCode() % size;
            return Math.Abs(position);
        }
        public V Get(K key)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValuePair<K, V>> linkedList = GetLinkedlist(position);
            foreach (KeyValue < K , V ) item in linkedList)
                {
                if (items.key.Equals(key))
                {
                    return item.value;
                }

                public void Add(K key, V value)
                {
                    int position = GetArrayPosition(key);
                    LinkedList<KeyValue<K, V>> linkedList = GetLinkedList(position);
                    keyValue<K, v> item = new KeyValue<K, V>() { key = key, value = value };
                    linkedList.AddLast(item);
                }
                public void Remove(K key)
                {
                    int position = GetArrayPosition(key);
                    linkedList<keyvalue<K, v>> linkedlist = Getlinkedlist(position);
                    bool itemFound = false;
                    KeyValue<K, v> item in linkedList();
                    foreach (KeyValue<K, v> item in linkedList)
                    {
                        if (item.key.Equals(key))
                        {
                            itemFound = true;
                            foundItem = item;
                        }
                        if (itemFound)
                        {
                            LinkedList.Remove(foundItem);
                        }
                    }
                }
            }
        }
    }
}

