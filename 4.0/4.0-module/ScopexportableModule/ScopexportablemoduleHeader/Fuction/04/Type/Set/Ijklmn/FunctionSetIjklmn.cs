using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class ScopexportablemoduleHeader
    {
        public partial class XQuadruple
        {
            public static IList<ScopexportableijklmnHeaderXopq_stY> FunctionIjklmnSet(ScopexportableijklmnHeaderXop_rstY[] Level_ARRAY)
            {
                ICollection<ScopexportableijklmnHeaderXopq_stY> collectionResult = default;

                collectionResult = new Collection<ScopexportableijklmnHeaderXopq_stY>();

                foreach (ScopexportableijklmnHeaderXop_rstY Level_VALUE in Level_ARRAY)
                {
                    var separator = new Char[1];

                    separator[0] = (Char)Scopexportableascii.EntityWhitespace;

                    var split = Level_VALUE.Header.Value.Split(separator, StringSplitOptions.RemoveEmptyEntries);

                    ScopexportableijklmnHeaderXopq_stY level;

                    level = new ScopexportableijklmnHeaderXopq_stY();

                    level.Object = Level_VALUE.Object;

                    level.DirectoryInfo = Level_VALUE.DirectoryInfo;

                    level.FileInfo = Level_VALUE.FileInfo;

                    level.Text = Level_VALUE.Text;

                    level.Start = Level_VALUE.Start;

                    level.End = Level_VALUE.End;

                    level.Mid = Level_VALUE.Mid;

                    level.Header = Level_VALUE.Header;

                    level.HeaderArray = Scopexportablestringarraysafe.ForgeDefault(split);

                    collectionResult.Add(level);

                    continue;
                }

                return new List<ScopexportableijklmnHeaderXopq_stY>(collectionResult);
            }
        }
    }
}
