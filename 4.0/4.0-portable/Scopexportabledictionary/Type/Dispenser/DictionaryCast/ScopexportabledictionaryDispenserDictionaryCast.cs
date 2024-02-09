using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class Scopexportabledictionary
    {
        public static Dictionary<L, R> ScopexportabledictionaryDictionaryCastDispenser<L, R>(Object reflect_OBJECT)
        {
            Dictionary<L, R> dictionaryResult = default;

            var result = (Dictionary<L, R>)(reflect_OBJECT as Object);

            dictionaryResult = result;

            return dictionaryResult;
        }
    }
}
