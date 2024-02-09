using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class Scopexportabledictionary
    {
        public static Dictionary<L, R> ScopexportabledictionaryDictionaryEmptyDispenser<L, R>()
        {
            Dictionary<L, R> dictionaryResult = default;
       
            Dictionary<L, R> dictionary;

            dictionary = new Dictionary<L, R>();

            dictionaryResult = dictionary;

            return dictionaryResult;
        }
    }
}
