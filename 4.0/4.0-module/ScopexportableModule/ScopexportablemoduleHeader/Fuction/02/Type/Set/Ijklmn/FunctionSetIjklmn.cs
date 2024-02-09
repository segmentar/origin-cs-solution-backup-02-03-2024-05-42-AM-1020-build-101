using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class ScopexportablemoduleHeader
    {
        public partial class XDouble
        {
            public static IList<ScopexportableijklmnHeaderXo_qrstY> FunctionIjklmnSet(ScopexportableijklmnHeaderX_pqrstY[] Ijklmn_ARRAY)
            {
                ICollection<ScopexportableijklmnHeaderXo_qrstY> collectionResult = default;

                collectionResult = new Collection<ScopexportableijklmnHeaderXo_qrstY>();

                foreach (ScopexportableijklmnHeaderX_pqrstY Ijklmn_VALUE in Ijklmn_ARRAY)
                {
                    var position = Ijklmn_VALUE.Text.Value.IndexOf((Char)Scopexportableascii.EntityComma, Ijklmn_VALUE.Start);

                    ScopexportableijklmnHeaderXo_qrstY ijklmn;

                    ijklmn = new ScopexportableijklmnHeaderXo_qrstY();

                    ijklmn.Object = Ijklmn_VALUE.Object;

                    ijklmn.DirectoryInfo = Ijklmn_VALUE.DirectoryInfo;

                    ijklmn.FileInfo = Ijklmn_VALUE.FileInfo;

                    ijklmn.Text = Ijklmn_VALUE.Text;

                    ijklmn.Start = Ijklmn_VALUE.Start;

                    ijklmn.End = Ijklmn_VALUE.End;

                    ijklmn.Mid = position;

                    collectionResult.Add(ijklmn);

                    continue;
                }

                return new List<ScopexportableijklmnHeaderXo_qrstY>(collectionResult);
            }
        }
    }
}
