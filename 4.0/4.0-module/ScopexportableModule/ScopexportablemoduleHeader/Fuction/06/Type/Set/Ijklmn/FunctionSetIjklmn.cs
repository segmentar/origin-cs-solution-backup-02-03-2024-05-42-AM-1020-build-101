using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class ScopexportablemoduleHeader
    {
        public partial class XSextuple
        {
            public static IList<ScopexportableijklmnHeaderXopqrs_Y> FunctionIjklmnSet(ScopexportableijklmnHeaderXopqr_tY[] Level_ARRAY)
            {
                ICollection<ScopexportableijklmnHeaderXopqrs_Y> collectionResult = default;

                collectionResult = new Collection<ScopexportableijklmnHeaderXopqrs_Y>();

                foreach (ScopexportableijklmnHeaderXopqr_tY Level_VALUE in Level_ARRAY)
                {
                    Char autumnLeft, autumnRight;

                    autumnLeft = '\0';

                    autumnRight = '\0';

                    foreach (String stringValue in Level_VALUE.HeaderArray.Value)
                    {
                        var trim = stringValue.TrimStart((Char)Scopexportableascii.EntityPeriod);

                        var difference = (stringValue.Length - trim.Length);

                        Boolean isEqualCheck, shouldContinueCheck;

                        isEqualCheck = Object.Equals(difference, Scopexportablestoreheader.EntityAutumn) is true;

                        shouldContinueCheck = isEqualCheck is false;

                        if (shouldContinueCheck is true)
                        {
                            continue;
                        }
                        else
                            "false".ToString();

                        var first = trim[0];

                        var second = trim[1];

                        autumnLeft = first;

                        autumnRight = second;

                        continue;
                    }

                    ScopexportableijklmnHeaderXopqrs_Y level;

                    level = new ScopexportableijklmnHeaderXopqrs_Y();

                    level.Object = Level_VALUE.Object;

                    level.DirectoryInfo = Level_VALUE.DirectoryInfo;

                    level.FileInfo = Level_VALUE.FileInfo;

                    level.Text = Level_VALUE.Text;

                    level.Start = Level_VALUE.Start;

                    level.End = Level_VALUE.End;

                    level.Mid = Level_VALUE.Mid;

                    level.Header = Level_VALUE.Header;

                    level.HeaderArray = Level_VALUE.HeaderArray;

                    level.SummerLeft = Level_VALUE.SummerLeft;

                    level.SummerRight = Level_VALUE.SummerRight;

                    level.AutumnLeft = Scopexportablecharactersafe.ForgeDefault(autumnLeft);

                    level.AutumnRight = Scopexportablecharactersafe.ForgeDefault(autumnRight);

                    collectionResult.Add(level);

                    continue;
                }

                return new List<ScopexportableijklmnHeaderXopqrs_Y>(collectionResult);
            }
        }
    }
}
