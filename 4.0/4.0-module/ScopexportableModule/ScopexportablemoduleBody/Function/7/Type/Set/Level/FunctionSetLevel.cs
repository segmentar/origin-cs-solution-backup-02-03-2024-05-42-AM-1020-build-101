using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class ScopexportablemoduleBody
    {
        public partial class XSeptuple
        {
            public static IList<ScopexportablelevelBodyU_pqrstV> FunctionLevelSet(ScopexportablelevelBodyXopqrs_Y[] Level_ARRAY)
            {
                ICollection<ScopexportablelevelBodyU_pqrstV> collectionResult = default;

                collectionResult = new Collection<ScopexportablelevelBodyU_pqrstV>();

                foreach (ScopexportablelevelBodyXopqrs_Y Level_VALUE in Level_ARRAY)
                {
                    var start = Level_VALUE.Mid + ScopexportableradicalBody.BodyIntegerArray.Length;

                    var difference = (Level_VALUE.End - start);

                    var sub = Level_VALUE.Text.Value.Substring(start, difference);

                    var trim = sub.Trim(ScopexportableradicalNormal.NormalCharacterArray);

                    ScopexportablelevelBodyU_pqrstV level;

                    level = new ScopexportablelevelBodyU_pqrstV();

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

                    level.Body = Scopexportablestringsafe.ForgeDefault(trim);

                    collectionResult.Add(level);

                    continue;
                }

                return new List<ScopexportablelevelBodyU_pqrstV>(collectionResult);
            }
        }
    }
}
