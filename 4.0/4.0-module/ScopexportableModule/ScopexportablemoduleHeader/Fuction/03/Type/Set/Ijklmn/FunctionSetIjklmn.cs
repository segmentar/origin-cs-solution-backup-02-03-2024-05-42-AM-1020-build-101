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
            public static IList<ScopexportableijklmnHeaderXop_rstY> FunctionIjklmnSet(ScopexportableijklmnHeaderXo_qrstY[] Ijklmn_ARRAY)
            {
                ICollection<ScopexportableijklmnHeaderXop_rstY> collectionResult = default;

                collectionResult = new Collection<ScopexportableijklmnHeaderXop_rstY>();

                foreach (ScopexportableijklmnHeaderXo_qrstY Ijklmn_VALUE in Ijklmn_ARRAY)
                {
                    Boolean isEqualContagentCheck;

                    isEqualContagentCheck = Object.Equals(Ijklmn_VALUE.Mid, -1) is true;

                    String stringValue;

                    if (isEqualContagentCheck)
                    {
                        stringValue = String.Empty;
                    }
                    else
                    {
                        var difference = (Ijklmn_VALUE.Mid - Ijklmn_VALUE.Start);

                        var sub = Ijklmn_VALUE.Text.Value.Substring(Ijklmn_VALUE.Start, difference);

                        stringValue = sub;
                    }

                    ScopexportableijklmnHeaderXop_rstY level;

                    level = new ScopexportableijklmnHeaderXop_rstY();

                    level.Object = Ijklmn_VALUE.Object;

                    level.DirectoryInfo = Ijklmn_VALUE.DirectoryInfo;

                    level.FileInfo = Ijklmn_VALUE.FileInfo;

                    level.Text = Ijklmn_VALUE.Text;

                    level.Start = Ijklmn_VALUE.Start;

                    level.End = Ijklmn_VALUE.End;

                    level.Mid = Ijklmn_VALUE.Mid;

                    level.Header = Scopexportablestringsafe.ForgeDefault(stringValue);

                    collectionResult.Add(level);

                    continue;
                }

                return new List<ScopexportableijklmnHeaderXop_rstY>(collectionResult);
            }
        }
    }
}
