using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class ScopexportablemoduleBody
    {
        public partial class XSextuple
        {
            public static IList<ScopexportablelevelBodyXopqrs_Y> FunctionLevelSet(ScopexportablelevelBodyXopqr_tY[] Level_ARRAY, Scopexportableformheadersolid[] array_SCOPEXPORTABLEHEADERSOLID)
            {
                ICollection<ScopexportablelevelBodyXopqrs_Y> collectionResult = default;

                collectionResult = new Collection<ScopexportablelevelBodyXopqrs_Y>();

                foreach (ScopexportablelevelBodyXopqr_tY Level_VALUE in Level_ARRAY)
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

                        ScopexportablelevelBodyXopqrs_Y level;

                        level = new ScopexportablelevelBodyXopqrs_Y();

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

                        level.BindArray = Scopexportablestringarraysafe.ForgeDefault(array);

                        collectionResult.Add(level);

                        continue;
                    }

                    continue;
                }

                return new List<ScopexportablelevelBodyXopqrs_Y>(collectionResult);
            }
        }
    }
}
