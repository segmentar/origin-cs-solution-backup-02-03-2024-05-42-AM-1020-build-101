using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class ScopexportablemoduleBody
    {
        public partial class XSextuple
        {
            public static IList<String> FunctionStringSet(ScopexportablelevelBodyXopqr_tY Level_VALUE, Scopexportableheadersolid value_SCOPEXPORTABLEHEADERSOLID)
            {
                ICollection<String> collectionResult = default;

                collectionResult = new Collection<String>();

                var index = 0;

                do
                {
                    Boolean isEqualCheck, shouldBreakCheck;

                    isEqualCheck = Object.Equals(value_SCOPEXPORTABLEHEADERSOLID.Escape.Value.Length, index) is true;

                    shouldBreakCheck = isEqualCheck is true;

                    if (shouldBreakCheck is true)
                    {
                        break;
                    }
                    else
                        "false".ToString();

                    var value = value_SCOPEXPORTABLEHEADERSOLID.Escape.Value[index];

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

                    index = index + 1;

                } while (true);

                return new List<String>(collectionResult);
            }
        }
    }
}