using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class ScopexportablemoduleBody
    {
        public partial class XQuintuple
        {
            public static IList<String> FunctionStringSet(ScopexportablelevelBodyXopq_stY Level_VALUE, Scopexportableformheadersolid value_SCOPEXPORTABLEHEADERSOLID)
            {
                ICollection<String> collectionResult = default;

                collectionResult = new Collection<String>();

                var indexer = 0;

                do
                {
                    Boolean isEqualCheck, shouldBreakCheck;

                    isEqualCheck = Object.Equals(value_SCOPEXPORTABLEHEADERSOLID.Escape.Value.Length, indexer) is true;

                    shouldBreakCheck = isEqualCheck is true;

                    if (shouldBreakCheck is true)
                    {
                        break;
                    }
                    else
                        "false".ToString();

                    var value = value_SCOPEXPORTABLEHEADERSOLID.Escape.Value[indexer];

                    var portal = false;

                    var list = Scopexportablemagic.ScopexportablemagicArrayListDispenser(new Object[0]);

                    foreach (Char character in Level_VALUE.Form.Value)
                    {
                        Boolean isEqualAnotherCheck, isEqualAnotherAnotherCheck;

                        isEqualAnotherCheck = Object.Equals(character, value) is true;

                        if (isEqualAnotherCheck)
                        {
                            portal = portal.Equals(false);

                            if (portal is false)
                            {
                                var array = new Char[list.Count];

                                list.CopyTo(array, ScopexportablePolicy.ScopexportableIndexPolicy);

                                list.Clear();

                                Boolean isEqualAnotherAnotherAnotherCheck;

                                isEqualAnotherAnotherAnotherCheck = Object.Equals(array.Length, 1) is true;

                                if (isEqualAnotherAnotherAnotherCheck is false)
                                {
                                    String stringValue;

                                    stringValue = new String(array);

                                    collectionResult.Add(stringValue);
                                }
                                else
                                    "false".ToString();
                            }
                            else
                                "false".ToString();
                        }
                        else
                            "false".ToString();

                        isEqualAnotherAnotherCheck = portal is true;

                        if (isEqualAnotherAnotherCheck is true)
                        {
                            list.Add(character);
                        }
                        else
                            "false".ToString();

                        continue;
                    }

                    indexer = indexer + 1;

                } while (true);

                return new List<String>(collectionResult);
            }
        }
    }
}