using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class ScopexportablemoduleHeader
    {
        public partial class XTriple
        {
            public static IList<ScopexportablelevelHeaderXop_rstY> FunctionLevelSet(ScopexportablelevelHeaderXo_qrstY[] Level_ARRAY)
            {
                ICollection<ScopexportablelevelHeaderXop_rstY> collectionResult = default;

                collectionResult = new Collection<ScopexportablelevelHeaderXop_rstY>();

                foreach (ScopexportablelevelHeaderXo_qrstY Level_VALUE in Level_ARRAY)
                {
                    Boolean isEqualContagentCheck;

                    isEqualContagentCheck = Object.Equals(Level_VALUE.Mid, -1) is true;

                    String stringValue;

                    if (isEqualContagentCheck)
                    {
                        stringValue = String.Empty;
                    }
                    else
                    {
                        var difference = (Level_VALUE.Mid - Level_VALUE.Start);

                        var sub = Level_VALUE.Text.Value.Substring(Level_VALUE.Start, difference);

                        stringValue = sub;
                    }

                    ScopexportablelevelHeaderXop_rstY level;

                    level = new ScopexportablelevelHeaderXop_rstY();

                    level.Object = Level_VALUE.Object;

                    level.DirectoryInfo = Level_VALUE.DirectoryInfo;

                    level.FileInfo = Level_VALUE.FileInfo;

                    level.Text = Level_VALUE.Text;

                    level.Start = Level_VALUE.Start;

                    level.End = Level_VALUE.End;

                    level.Mid = Level_VALUE.Mid;

                    level.Header = Scopexportablestringsafe.ForgeDefault(stringValue);

                    collectionResult.Add(level);

                    continue;
                }

                return new List<ScopexportablelevelHeaderXop_rstY>(collectionResult);
            }
        }
    }
}
