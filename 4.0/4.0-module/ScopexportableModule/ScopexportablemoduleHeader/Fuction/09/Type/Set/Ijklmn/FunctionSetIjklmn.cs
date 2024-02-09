using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class ScopexportablemoduleHeader
    {
        public partial class XNonuple
        {
            public static IList<ScopexportableijklmnHeaderUop_rstV> FunctionIjklmnSet(ScopexportableijklmnHeaderUo_qrstV[] Level_ARRAY)
            {
                ICollection<ScopexportableijklmnHeaderUop_rstV> collectionResult = default;

                collectionResult = new Collection<ScopexportableijklmnHeaderUop_rstV>();

                foreach (ScopexportableijklmnHeaderUo_qrstV Level_VALUE in Level_ARRAY)
                {
                    Char[] characterArray;

                    characterArray = new Char[0];

                    foreach (String stringValue in Level_VALUE.HeaderArray.Value)
                    {
                        var trim = stringValue.TrimStart((Char)Scopexportableascii.EntityPeriod);

                        var difference = (stringValue.Length - trim.Length);

                        Boolean isEqualCheck, shouldContinueCheck;

                        isEqualCheck = Object.Equals(difference, Scopexportablestoreheader.EntityEscape) is true;

                        shouldContinueCheck = isEqualCheck is false;

                        if (shouldContinueCheck is true)
                        {
                            continue;
                        }
                        else
                            "false".ToString();

                        var item = characterArray.Length;

                        var entry = trim.Length;

                        var zee = item + trim.Length;

                        Array.Resize<Char>(ref characterArray, zee);

                        trim.CopyTo(0, characterArray, item, entry);

                        continue;
                    }

                    ScopexportableijklmnHeaderUop_rstV level;

                    level = new ScopexportableijklmnHeaderUop_rstV();

                    level.Object = Level_VALUE.Object;

                    level.DirectoryInfo = Level_VALUE.DirectoryInfo;

                    level.FileInfo = Level_VALUE.FileInfo;

                    level.Text = Level_VALUE.Text;

                    level.Start = Level_VALUE.Start;

                    level.End = Level_VALUE.End;

                    level.Header = Level_VALUE.Header;

                    level.Mid = Level_VALUE.Mid;

                    level.HeaderArray = Level_VALUE.HeaderArray;

                    level.SummerLeft = Level_VALUE.SummerLeft;

                    level.SummerRight = Level_VALUE.SummerRight;

                    level.AutumnLeft = Level_VALUE.AutumnLeft;

                    level.AutumnRight = Level_VALUE.AutumnRight;

                    level.SpringLeft = Level_VALUE.SpringLeft;

                    level.SpringRight = Level_VALUE.SpringRight;

                    level.WinterLeft = Level_VALUE.WinterLeft;

                    level.WinterRight = Level_VALUE.WinterRight;

                    level.Escape = Scopexportablecharacterarraysafe.ForgeDefault(characterArray);

                    collectionResult.Add(level);

                    continue;
                }

                return new List<ScopexportableijklmnHeaderUop_rstV>(collectionResult);
            }
        }
    }
}
