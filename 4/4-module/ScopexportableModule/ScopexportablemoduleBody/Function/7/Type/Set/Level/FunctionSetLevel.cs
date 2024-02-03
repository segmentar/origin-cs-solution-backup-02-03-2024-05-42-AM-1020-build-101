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
            public static IList<ScopexportablelevelBodyU_pqrstV> FunctionLevelSet(ScopexportablelevelBodyXopqrs_Y[] Level_ARRAY, Scopexportableheadersolid[] array_SCOPEXPORTABLEHEADERSOLID)
            {
                ICollection<ScopexportablelevelBodyU_pqrstV> collectionResult = default;

                collectionResult = new Collection<ScopexportablelevelBodyU_pqrstV>();

                foreach (ScopexportablelevelBodyXopqrs_Y Level_VALUE in Level_ARRAY)
                {
                    foreach (Scopexportableheadersolid value_SCOPEXPORTABLEHEADERSOLID in array_SCOPEXPORTABLEHEADERSOLID)
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

                        level.Body = Level_VALUE.Body;

                        level.BodyArray = Level_VALUE.BodyArray;

                        level.PortalArray = Level_VALUE.PortalArray;

                        level.BindArray = Scopexportablestringarraysafe.ForgeDefault(array);

                        collectionResult.Add(level);

                        continue;
                    }

                    continue;
                }

                return new List<ScopexportablelevelBodyU_pqrstV>(collectionResult);
            }
        }
    }
}
