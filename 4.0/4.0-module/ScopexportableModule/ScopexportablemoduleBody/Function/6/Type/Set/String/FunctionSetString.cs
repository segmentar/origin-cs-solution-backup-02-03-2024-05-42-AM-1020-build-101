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
            public static IList<String> FunctionStringSet(ScopexportablelevelBodyXopqr_tY Level_VALUE, Scopexportableformheadersolid value_SCOPEXPORTABLEHEADERSOLID)
            {
                ICollection<String> collectionResult = default;

                collectionResult = new Collection<String>();

                var error = -1;

                do
                {
                    error = error + 1;

                    Boolean isEqualCheck, shouldBreakCheck;

                    isEqualCheck = Object.Equals(value_SCOPEXPORTABLEHEADERSOLID.Escape.Value.Length, error) is true;

                    shouldBreakCheck = isEqualCheck is true;

                    if (shouldBreakCheck is true)
                    {
                        break;
                    }
                    else
                        "false".ToString();

                    var value = value_SCOPEXPORTABLEHEADERSOLID.Escape.Value[error];

                    var result = new String(value, 2);

                    var inflect = new Object[2];

                    inflect[0] = Level_VALUE.Form.Value.IndexOf(result);

                    Boolean isEqualAnotherCheck, shouldContinueAnotherCheck;

                    isEqualAnotherCheck = Object.Equals((Int32)inflect[0], -1) is true;

                    shouldContinueAnotherCheck = isEqualAnotherCheck is true;

                    if (shouldContinueAnotherCheck is true)
                    {
                        continue;
                    }
                    else
                        "false".ToString();

                    inflect[1] = Level_VALUE.Form.Value.IndexOf((Char)Scopexportableascii.EntitySemicolon, (Int32)inflect[0]);

                    Boolean isEqualAnotherAnotherCheck, shouldContinueAnotherAnotherCheck;

                    isEqualAnotherAnotherCheck = Object.Equals((Int32)inflect[1], -1) is true;

                    shouldContinueAnotherAnotherCheck = isEqualAnotherCheck is true;

                    if (shouldContinueAnotherAnotherCheck is true)
                    {
                        continue;
                    }
                    else
                        "false".ToString();

                    var difference = ((Int32)inflect[1] - (Int32)inflect[0]);

                    var sub = Level_VALUE.Form.Value.Substring((Int32)inflect[0], difference);

                    collectionResult.Add(sub);

                } while (true);

                return new List<String>(collectionResult);
            }
        }
    }
}