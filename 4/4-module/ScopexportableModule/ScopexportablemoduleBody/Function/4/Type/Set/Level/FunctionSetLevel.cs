using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class ScopexportablemoduleBody
    {
        public partial class XQuadruple
        {
            public static IList<ScopexportablelevelBodyXopq_stY> FunctionLevelSet(ScopexportablelevelBodyXop_rstY[] Level_ARRAY)
            {
                ICollection<ScopexportablelevelBodyXopq_stY> collectionResult = default;

                collectionResult = new Collection<ScopexportablelevelBodyXopq_stY>();

                foreach (ScopexportablelevelBodyXop_rstY Level_VALUE in Level_ARRAY)
                {
                    var start = Level_VALUE.Mid + ScopexportableradicalBody.BodyIntegerArray.Length;

                    var difference = (Level_VALUE.End - start);

                    var sub = Level_VALUE.Text.Value.Substring(start, difference);

                    var trim = sub.Trim(ScopexportableradicalNormal.NormalCharacterArray);

                    ScopexportablelevelBodyXopq_stY level;

                    level = new ScopexportablelevelBodyXopq_stY();

                    level.Object = Level_VALUE.Object;

                    level.DirectoryInfo = Level_VALUE.DirectoryInfo;

                    level.FileInfo = Level_VALUE.FileInfo;

                    level.Text = Level_VALUE.Text;

                    level.Start = Level_VALUE.Start;

                    level.End = Level_VALUE.End;

                    level.Mid = Level_VALUE.Mid;

                    level.Form = Level_VALUE.Form;

                    level.Body = Scopexportablestringsafe.ForgeDefault(trim);

                    collectionResult.Add(level);

                    continue;
                }

                return new List<ScopexportablelevelBodyXopq_stY>(collectionResult);
            }
        }
    }
}
