using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class ScopexportablemoduleHeader
    {
        public partial class XOctuple
        {
            public static IList<ScopexportableijklmnHeaderUo_qrstV> FunctionIjklmnSet(ScopexportableijklmnHeaderU_pqrstV[] Level_ARRAY)
            {
                ICollection<ScopexportableijklmnHeaderUo_qrstV> collectionResult = default;

                collectionResult = new Collection<ScopexportableijklmnHeaderUo_qrstV>();

                foreach (ScopexportableijklmnHeaderU_pqrstV Level_VALUE in Level_ARRAY)
                {
                    Char winterLeft, winterRight;

                    winterLeft = '\0';

                    winterRight = '\0';

                    foreach (String stringValue in Level_VALUE.HeaderArray.Value)
                    {
                        var trim = stringValue.TrimStart((Char)Scopexportableascii.EntityPeriod);

                        var difference = (stringValue.Length - trim.Length);

                        Boolean isEqualCheck, shouldContinueCheck;

                        isEqualCheck = Object.Equals(difference, Scopexportablestoreheader.EntityWinter) is true;

                        shouldContinueCheck = isEqualCheck is false;

                        if (shouldContinueCheck is true)
                        {
                            continue;
                        }
                        else
                            "false".ToString();

                        var first = trim[0];

                        var second = trim[1];

                        winterLeft = first;

                        winterRight = second;

                        continue;
                    }

                    ScopexportableijklmnHeaderUo_qrstV level;

                    level = new ScopexportableijklmnHeaderUo_qrstV();

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

                    level.SpringLeft = Level_VALUE.SpringLeft;

                    level.SpringRight = Level_VALUE.SpringRight;

                    level.WinterLeft = Scopexportablecharactersafe.ForgeDefault(winterLeft);

                    level.WinterRight = Scopexportablecharactersafe.ForgeDefault(winterRight);

                    collectionResult.Add(level);

                    continue;
                }

                return new List<ScopexportableijklmnHeaderUo_qrstV>(collectionResult);
            }
        }
    }
}
