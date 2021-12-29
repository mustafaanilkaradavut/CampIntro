using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsDictionaryWorkshop
{
    internal class MyDictionary<TKey, TValue>
    {
        TKey[] _tkey;
        TValue[] _tvalue;

        public MyDictionary()
        {
            _tkey = new TKey[0];
            _tvalue = new TValue[0];
        }

        public void Add(TKey tKey, TValue tValue)
        {
            TKey[] tempArrayKeys = _tkey;
            TValue[] tempArrayValue = _tvalue;

            _tkey = new TKey[_tkey.Length + 1];
            _tvalue = new TValue[_tvalue.Length + 1];

            for (int i = 0; i < tempArrayKeys.Length; i++)
            {
                _tkey[i] = tempArrayKeys[i];
            }

            for (int i = 0; i < tempArrayValue.Length; i++)
            {
                _tvalue[i] = tempArrayValue[i];
            }

            _tkey[_tkey.Length-1] = tKey;
            _tvalue[_tkey.Length-1] = tValue;

            Console.WriteLine("Age : " + tKey + " Name : " + tValue);
        }
    }
}
