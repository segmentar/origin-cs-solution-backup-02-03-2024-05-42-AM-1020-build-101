using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class Scopexportabledictionary
    {
        public static Dictionary<L, R> ScopexportabledictionaryDictionaryDispenser<L, R>(IDictionary<L, R> value_DICTIONARY)
        {
            Dictionary<L, R> dictionaryResult = default;
       
            Dictionary<L, R> dictionary;

            dictionary = new Dictionary<L, R>(value_DICTIONARY);

            dictionaryResult = dictionary;

            return dictionaryResult;
        }
    }
}
