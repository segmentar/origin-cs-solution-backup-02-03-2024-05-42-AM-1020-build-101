using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class ScopexportablemoduleBody
    {
        public partial class XNonuple
        {
            public static IList<Scopexportableformbodysolid> FunctionLevelSet(ScopexportablelevelBodyUo_qrstV[] Level_ARRAY)
            {
                ICollection<Scopexportableformbodysolid> collectionResult = default;

                collectionResult = new Collection<Scopexportableformbodysolid>();

                foreach (ScopexportablelevelBodyUo_qrstV Level_VALUE in Level_ARRAY)
                {
                    Scopexportableformbodysolid scopexportablebodysolid;

                    scopexportablebodysolid = new Scopexportableformbodysolid();

                    scopexportablebodysolid.Object = Level_VALUE.Object;

                    scopexportablebodysolid.Mid = Level_VALUE.Mid;

                    scopexportablebodysolid.Form = Level_VALUE.Form;

                    scopexportablebodysolid.Hierarchy = Level_VALUE.Hierarchy;

                    scopexportablebodysolid.PortalArray = Level_VALUE.PortalArray;

                    scopexportablebodysolid.BindArray = Level_VALUE.BindArray;

                    scopexportablebodysolid.Body = Level_VALUE.Body;

                    scopexportablebodysolid.BodyArray = Level_VALUE.BodyArray;

                    collectionResult.Add(scopexportablebodysolid);

                    continue;
                }

                return new List<Scopexportableformbodysolid>(collectionResult);
            }
        }
    }
}
