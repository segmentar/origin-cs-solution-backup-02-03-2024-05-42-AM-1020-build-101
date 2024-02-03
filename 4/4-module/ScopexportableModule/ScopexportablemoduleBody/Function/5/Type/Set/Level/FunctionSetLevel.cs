using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class ScopexportablemoduleBody
    {
        public partial class XQuintuple
        {
            public static IList<ScopexportablelevelBodyXopqr_tY> FunctionLevelSet(ScopexportablelevelBodyXopq_stY[] Level_ARRAY)
            {
                ICollection<ScopexportablelevelBodyXopqr_tY> collectionResult = default;

                collectionResult = new Collection<ScopexportablelevelBodyXopqr_tY>();

                foreach (ScopexportablelevelBodyXopq_stY Level_VALUE in Level_ARRAY)
                {
                    var split = Level_VALUE.Body.Value.Split(ScopexportableradicalNewLine.NewLineStringArray, StringSplitOptions.None);

                    ScopexportablelevelBodyXopqr_tY level;

                    level = new ScopexportablelevelBodyXopqr_tY();

                    level.Object = Level_VALUE.Object;

                    level.DirectoryInfo = Level_VALUE.DirectoryInfo;

                    level.FileInfo = Level_VALUE.FileInfo;

                    level.Text = Level_VALUE.Text;

                    level.Start = Level_VALUE.Start;

                    level.End = Level_VALUE.End;

                    level.Mid = Level_VALUE.Mid;

                    level.Form = Level_VALUE.Form;

                    level.Body = Level_VALUE.Body;

                    level.BodyArray = Scopexportablestringarraysafe.ForgeDefault(split);

                    collectionResult.Add(level);

                    continue;
                }

                return new List<ScopexportablelevelBodyXopqr_tY>(collectionResult);
            }
        }
    }
}
