using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class ScopexportablemoduleBody
    {
        public partial class XDouble
        {
            public static IList<ScopexportablelevelBodyXo_qrstY> FunctionLevelSet(ScopexportablelevelBodyX_pqrstY[] Level_ARRAY)
            {
                ICollection<ScopexportablelevelBodyXo_qrstY> collectionResult = default;

                collectionResult = new Collection<ScopexportablelevelBodyXo_qrstY>();

                foreach (ScopexportablelevelBodyX_pqrstY Level_VALUE in Level_ARRAY)
                {
                    var position = Level_VALUE.Text.Value.IndexOf(ScopexportableradicalBody.BodyCharacterConcatenate, Level_VALUE.Start);

                    ScopexportablelevelBodyXo_qrstY level;

                    level = new ScopexportablelevelBodyXo_qrstY();

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

                return new List<ScopexportablelevelBodyXo_qrstY>(collectionResult);
            }
        }
    }
}
