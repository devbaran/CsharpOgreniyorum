using System;
using System.Collections.Generic;

namespace DictMaking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> sozluk = new Dictionary<string, string>();
            sozluk.Add("Warrior36","mustafa");
            sozluk.Add("dawbmuS","Memduh");

            MyDict<int, string> sozluk2 = new MyDict<int, string>();
            sozluk2.Add(2005, "Bitmedi");

        }

    }

    
    class MyDict<K,V>
    {
        K[] keys;
        K[] tempKey;
        V[] values;
        V[] tempValue;

        public MyDict()
        {
            keys = new K[0];
            values = new V[0];
        }
        

        public void Add(K key, V value)
        {
            tempValue = values;
            tempKey = keys;

            keys = new K[keys.Length + 1]; // yeni key ekleniyor
            for (int i = 0; i < keys.Length; i++)
            {
                keys[i] = tempKey[i]; // bu for döngüsüyle, önceki keylerimizi aldık
            }
            keys[keys.Length - 1] = key;

            values = new V[values.Length + 1]; // yeni value ekleniyor
            for (int i = 0; i < values.Length; i++)
            {
                values[i] = tempValue[i];

            }
            values[values.Length - 1] = value;

        }


    }
}
