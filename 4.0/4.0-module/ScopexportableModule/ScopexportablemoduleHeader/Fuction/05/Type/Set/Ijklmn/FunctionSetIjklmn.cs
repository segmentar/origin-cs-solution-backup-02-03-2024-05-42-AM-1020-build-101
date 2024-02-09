using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class ScopexportablemoduleHeader
    {
        public partial class XQuintuple
        {
            public static IList<ScopexportableijklmnHeaderXopqr_tY> FunctionIjklmnSet(ScopexportableijklmnHeaderXopq_stY[] Level_ARRAY)
            {
                ICollection<ScopexportableijklmnHeaderXopqr_tY> collectionResult = default;

                collectionResult = new Collection<ScopexportableijklmnHeaderXopqr_tY>();
                
                foreach (ScopexportableijklmnHeaderXopq_stY Level_VALUE in Level_ARRAY)
                {
                    Char summerLeft, summerRight;

                    summerLeft = '\0';

                    summerRight = '\0';

                    foreach (String stringValue in Level_VALUE.HeaderArray.Value)
                    {
                        var trim = stringValue.TrimStart((Char)Scopexportableascii.EntityPeriod);

                        var difference = (stringValue.Length - trim.Length);

                        Boolean isEqualCheck, shouldContinueCheck;

                        isEqualCheck = Object.Equals(difference, Scopexportablestoreheader.EntitySummer) is true;

                        shouldContinueCheck = isEqualCheck is false;

                        if (shouldContinueCheck is true)
                        {
                            continue;
                        }
                        else
                            "false".ToString();

                        var first = trim[0];

                        var second = trim[1];

                        summerLeft = first;

                        summerRight = second;

                        continue;
                    }

                    ScopexportableijklmnHeaderXopqr_tY level;

                    level = new ScopexportableijklmnHeaderXopqr_tY();

                    level.Object = Level_VALUE.Object;

                    level.DirectoryInfo = Level_VALUE.DirectoryInfo;

                    level.FileInfo = Level_VALUE.FileInfo;

                    level.Text = Level_VALUE.Text;

                    level.Start = Level_VALUE.Start;

                    level.End = Level_VALUE.End;

                    level.Mid = Level_VALUE.Mid;

                    level.Header = Level_VALUE.Header;

                    level.HeaderArray = Level_VALUE.HeaderArray;

                    level.SummerLeft = Scopexportablecharactersafe.ForgeDefault(summerLeft);

                    level.SummerRight = Scopexportablecharactersafe.ForgeDefault(summerRight);

                    collectionResult.Add(level);

                    continue;
                }

                return new List<ScopexportableijklmnHeaderXopqr_tY>(collectionResult);
            }
        }
    }
}
