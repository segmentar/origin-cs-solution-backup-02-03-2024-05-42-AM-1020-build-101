using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class ScopexportablemoduleHeader
    {
        public partial class XDecuple
        {
            public static IList<ScopexportableijklmnHeaderUopq_stV> FunctionIjklmnSet(ScopexportableijklmnHeaderUop_rstV[] Level_ARRAY)
            {
                ICollection<ScopexportableijklmnHeaderUopq_stV> collectionResult = default;

                collectionResult = new Collection<ScopexportableijklmnHeaderUopq_stV>();

                foreach (ScopexportableijklmnHeaderUop_rstV Level_VALUE in Level_ARRAY)
                {
                    var aoth = Level_VALUE.HeaderArray.Value.Length;

                    var roth = (aoth - 1);

                    var value = Level_VALUE.HeaderArray.Value[roth];

                    ScopexportableijklmnHeaderUopq_stV level;

                    level = new ScopexportableijklmnHeaderUopq_stV();

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

                    level.WinterLeft = Level_VALUE.WinterLeft;

                    level.WinterRight = Level_VALUE.WinterRight;

                    level.Escape = Level_VALUE.Escape;

                    level.Extension = Scopexportablestringsafe.ForgeDefault(value);

                    collectionResult.Add(level);

                    continue;
                }

                return new List<ScopexportableijklmnHeaderUopq_stV>(collectionResult);
            }
        }
    }
}
