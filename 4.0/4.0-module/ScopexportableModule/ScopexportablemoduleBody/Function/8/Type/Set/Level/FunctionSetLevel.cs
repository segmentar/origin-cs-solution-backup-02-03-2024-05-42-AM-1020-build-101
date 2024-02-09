using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class ScopexportablemoduleBody
    {
        public partial class XOctuple
        {
            public static IList<ScopexportablelevelBodyUo_qrstV> FunctionLevelSet(ScopexportablelevelBodyU_pqrstV[] Level_ARRAY)
            {
                ICollection<ScopexportablelevelBodyUo_qrstV> collectionResult = default;

                collectionResult = new Collection<ScopexportablelevelBodyUo_qrstV>();

                foreach (ScopexportablelevelBodyU_pqrstV Level_VALUE in Level_ARRAY)
                {
                    var split = Level_VALUE.Body.Value.Split(ScopexportableradicalNewLine.NewLineStringArray, StringSplitOptions.None);

                    ScopexportablelevelBodyUo_qrstV level;

                    level = new ScopexportablelevelBodyUo_qrstV();

                    level.Object = Level_VALUE.Object;

                    level.DirectoryInfo = Level_VALUE.DirectoryInfo;

                    level.FileInfo = Level_VALUE.FileInfo;

                    level.Text = Level_VALUE.Text;

                    level.Start = Level_VALUE.Start;

                    level.End = Level_VALUE.End;

                    level.Mid = Level_VALUE.Mid;

                    level.Form = Level_VALUE.Form;

                    level.Hierarchy = Level_VALUE.Hierarchy;

                    level.PortalArray = Level_VALUE.PortalArray;

                    level.BindArray = Level_VALUE.BindArray;

                    level.Body = Level_VALUE.Body;

                    level.BodyArray = Scopexportablestringarraysafe.ForgeDefault(split);

                    collectionResult.Add(level);

                    continue;
                }

                return new List<ScopexportablelevelBodyUo_qrstV>(collectionResult);
            }
        }
    }
}
