using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using static System.Windows.Forms.VisualStyles.VisualStyleElement;

    public partial class ScopexportablemoduleHeader
    {
        public partial class XDouble
        {
            public static IList<ScopexportablelevelHeaderXo_qrstY> FunctionLevelSet(ScopexportablelevelHeaderX_pqrstY[] Level_ARRAY)
            {
                ICollection<ScopexportablelevelHeaderXo_qrstY> collectionResult = default;

                collectionResult = new Collection<ScopexportablelevelHeaderXo_qrstY>();

                foreach (ScopexportablelevelHeaderX_pqrstY Level_VALUE in Level_ARRAY)
                {
                    var position = Level_VALUE.Text.Value.IndexOf((Char)Scopexportableascii.EntityComma, Level_VALUE.Start);

                    ScopexportablelevelHeaderXo_qrstY level;

                    level = new ScopexportablelevelHeaderXo_qrstY();

                    level.Object = Level_VALUE.Object;

                    level.DirectoryInfo = Level_VALUE.DirectoryInfo;

                    level.FileInfo = Level_VALUE.FileInfo;

                    level.Text = Level_VALUE.Text;

                    level.Start = Level_VALUE.Start;

                    level.End = Level_VALUE.End;

                    level.Mid = position;

                    collectionResult.Add(level);

                    continue;
                }

                return new List<ScopexportablelevelHeaderXo_qrstY>(collectionResult);
            }
        }
    }
}
