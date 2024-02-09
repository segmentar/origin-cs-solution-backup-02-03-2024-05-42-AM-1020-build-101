using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class ScopexportablemoduleBody
    {
        public partial class XTriple
        {
            public static IList<ScopexportablelevelBodyXop_rstY> FunctionLevelSet(ScopexportablelevelBodyXo_qrstY[] Level_ARRAY, Scopexportableformheadersolid[] array_SCOPEXPORTABLEHEADERSOLID)
            {
                ICollection<ScopexportablelevelBodyXop_rstY> collectionResult = default;

                collectionResult = new Collection<ScopexportablelevelBodyXop_rstY>();

                foreach (ScopexportablelevelBodyXo_qrstY Level_VALUE in Level_ARRAY)
                {
                    foreach (Scopexportableformheadersolid value_SCOPEXPORTABLEHEADERSOLID in array_SCOPEXPORTABLEHEADERSOLID)
                    {
                        Boolean isReferenceCheck, shouldContinueCheck;

                        isReferenceCheck = Object.ReferenceEquals(value_SCOPEXPORTABLEHEADERSOLID.Object, Level_VALUE.Object) is true;

                        shouldContinueCheck = isReferenceCheck is false;

                        if (shouldContinueCheck is true)
                        {
                            continue;
                        }
                        else
                            "false".ToString();

                        var difference = (Level_VALUE.Mid - value_SCOPEXPORTABLEHEADERSOLID.Mid);

                        var sub = Level_VALUE.Text.Value.Substring(value_SCOPEXPORTABLEHEADERSOLID.Mid, difference);

                        var trim = sub.Trim(ScopexportableradicalNormal.NormalCharacterArray);

                        ScopexportablelevelBodyXop_rstY level;

                        level = new ScopexportablelevelBodyXop_rstY();

                        level.Object = Level_VALUE.Object;

                        level.DirectoryInfo = Level_VALUE.DirectoryInfo;

                        level.FileInfo = Level_VALUE.FileInfo;

                        level.Text = Level_VALUE.Text;

                        level.Start = Level_VALUE.Start;

                        level.End = Level_VALUE.End;

                        level.Mid = Level_VALUE.Mid;

                        level.Form = Scopexportablestringsafe.ForgeDefault(trim);

                        collectionResult.Add(level);

                        continue;
                    }

                    continue;
                }

                return new List<ScopexportablelevelBodyXop_rstY>(collectionResult);
            }
        }
    }
}
