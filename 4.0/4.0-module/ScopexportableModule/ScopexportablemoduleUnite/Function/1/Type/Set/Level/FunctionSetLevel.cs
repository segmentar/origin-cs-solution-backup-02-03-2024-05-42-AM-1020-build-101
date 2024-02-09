using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class ScopexportablemoduleUnite
    {
        public partial class XSingle
        {
            public static IList<Scopexportableformbuildsolid> FunctionLevelSet(Object[] array_OBJECT, Scopexportableformcoordinate[] array_SCOPEXPORTABLEEXTRACTFORM, Scopexportableformheadersolid[] array_SCOPEXPORTABLEHEADERSOLID, Scopexportableformbodysolid[] array_SCOPEXPORTABLEBODYSOLID, Scopexportablehierarchysolid[] array_SCOPEXPORTABLEHIERARCHYSOLID)
            {
                ICollection<Scopexportableformbuildsolid> collectionResult = default;

                collectionResult = new Collection<Scopexportableformbuildsolid>();

                foreach (Object value_OBJECT in array_OBJECT)
                {
                    foreach (Scopexportableformheadersolid value_SCOPEXPORTABLEHEADERSOLID in array_SCOPEXPORTABLEHEADERSOLID)
                    {
                        foreach (Scopexportableformbodysolid value_SCOPEXPORTABLEBODYSOLID in array_SCOPEXPORTABLEBODYSOLID)
                        {
                            foreach (Scopexportablehierarchysolid value_SCOPEXPORTABLEHIERARCHYSOLID in array_SCOPEXPORTABLEHIERARCHYSOLID)
                            {
                                var boolean = true;

                                boolean = boolean && Object.ReferenceEquals(value_SCOPEXPORTABLEHEADERSOLID.Object, value_OBJECT) is true;

                                boolean = boolean && Object.ReferenceEquals(value_SCOPEXPORTABLEBODYSOLID.Object, value_OBJECT) is true;

                                boolean = boolean && Object.ReferenceEquals(value_SCOPEXPORTABLEHIERARCHYSOLID.Object, value_OBJECT) is true;
                                
                                Boolean isEqualCheck, shouldContinueCheck;

                                isEqualCheck = boolean is true;

                                shouldContinueCheck = isEqualCheck is false;

                                if (shouldContinueCheck is true)
                                {
                                    continue;
                                }
                                else
                                    "false".ToString();

                                Scopexportableformbuildsolid scopexportableaccumulatesolid;

                                scopexportableaccumulatesolid = new Scopexportableformbuildsolid();

                                scopexportableaccumulatesolid.Scopexportableheadersolid = value_SCOPEXPORTABLEHEADERSOLID;

                                scopexportableaccumulatesolid.Scopexportablebodysolid = value_SCOPEXPORTABLEBODYSOLID;

                                scopexportableaccumulatesolid.ScopexportablehierarchynumeratesolidArray = value_SCOPEXPORTABLEHIERARCHYSOLID.ScopexportablehierarchynumeratesolidArray;

                                collectionResult.Add(scopexportableaccumulatesolid);

                                continue;
                            }

                            continue;
                        }

                        continue;
                    }

                    continue;
                }

                return new List<Scopexportableformbuildsolid>(collectionResult);
            }
        }
    }
}
