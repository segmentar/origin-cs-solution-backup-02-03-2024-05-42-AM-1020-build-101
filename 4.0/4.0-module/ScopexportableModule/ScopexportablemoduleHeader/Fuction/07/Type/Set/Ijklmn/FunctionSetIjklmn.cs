using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class ScopexportablemoduleHeader
    {
        public partial class XSeptuple
        {
            public static IList<ScopexportableijklmnHeaderU_pqrstV> FunctionIjklmnSet(ScopexportableijklmnHeaderXopqrs_Y[] Level_ARRAY)
            {
                ICollection<ScopexportableijklmnHeaderU_pqrstV> collectionResult = default;

                collectionResult = new Collection<ScopexportableijklmnHeaderU_pqrstV>();

                foreach (ScopexportableijklmnHeaderXopqrs_Y Level_VALUE in Level_ARRAY)
                {
                    Char springLeft, springRight;

                    springLeft = '\0';

                    springRight = '\0';

                    foreach (String stringValue in Level_VALUE.HeaderArray.Value)
                    {
                        var trim = stringValue.TrimStart((Char)Scopexportableascii.EntityPeriod);

                        var difference = (stringValue.Length - trim.Length);

                        Boolean isEqualCheck, shouldContinueCheck;

                        isEqualCheck = Object.Equals(difference, Scopexportablestoreheader.EntitySpring) is true;

                        shouldContinueCheck = isEqualCheck is false;

                        if (shouldContinueCheck is true)
                        {
                            continue;
                        }
                        else
                            "false".ToString();

                        var first = trim[0];

                        var second = trim[1];

                        springLeft = first;

                        springRight = second;

                        continue;
                    }

                    ScopexportableijklmnHeaderU_pqrstV level;

                    level = new ScopexportableijklmnHeaderU_pqrstV();

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

                    level.AutumnLeft = Level_VALUE.AutumnLeft;

                    level.AutumnRight = Level_VALUE.AutumnRight;

                    level.SpringLeft = Scopexportablecharactersafe.ForgeDefault(springLeft);

                    level.SpringRight = Scopexportablecharactersafe.ForgeDefault(springRight);

                    collectionResult.Add(level);

                    continue;
                }

                return new List<ScopexportableijklmnHeaderU_pqrstV>(collectionResult);
            }
        }
    }
}
