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
            public static IList<ScopexportablelevelBodyXopqr_tY> FunctionLevelSet(ScopexportablelevelBodyXopq_stY[] Level_ARRAY, Scopexportableformheadersolid[] array_SCOPEXPORTABLEHEADERSOLID)
            {
                ICollection<ScopexportablelevelBodyXopqr_tY> collectionResult = default;

                collectionResult = new Collection<ScopexportablelevelBodyXopqr_tY>();

                foreach (ScopexportablelevelBodyXopq_stY Level_VALUE in Level_ARRAY)
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

                        var array = FunctionStringSetSurface(Level_VALUE, value_SCOPEXPORTABLEHEADERSOLID);

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

                        level.Hierarchy = Level_VALUE.Hierarchy;

                        level.PortalArray = Scopexportablestringarraysafe.ForgeDefault(array);

                        collectionResult.Add(level);

                        continue;
                    }

                    continue;
                }

                return new List<ScopexportablelevelBodyXopqr_tY>(collectionResult);
            }
        }
    }
}
