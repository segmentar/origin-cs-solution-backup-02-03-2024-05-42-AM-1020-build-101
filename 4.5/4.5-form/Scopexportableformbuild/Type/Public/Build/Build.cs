using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Scopexportableaccumulate
    {
        public static Object[] Accumulate(Scopexportableformcoordinate[] array_SCOPEXPORTABLEEXTRACTFORM, Boolean answer_IDENTITY_should, Boolean answer_PERFORM_should)
        {
            Object[] arrayResult = default;

            if (answer_IDENTITY_should is true)
            {
                ScopexportableIdentity.ScopexportableNameIdentity = Path.GetRandomFileName();

                ScopexportableIdentity.ScopexprotableOrdinalIdentity = ScopexportableIdentity.ScopexprotableOrdinalIdentity + 1;
            }
            else
                "false".ToString();

            if (answer_PERFORM_should is true)
            {
                ScopexportableModule.ScopexportablemoduleHeader = false;

                ScopexportableModule.ScopexportablemoduleBody = false;

                ScopexportableModule.ScopexportablemoduleHierarchy = false;

                ScopexportableModule.ScopexportablemoduleUnite = false;
            }
            else
                "false".ToString();

            var array = Scopexportableunique.ScopexportableUniqueSetSurface(array_SCOPEXPORTABLEEXTRACTFORM.Length);

            ScopexportablemoduleHeader scopexportablemoduleHeader = ScopexportablemoduleHeader.Action(array_SCOPEXPORTABLEEXTRACTFORM, array);

            ScopexportablemoduleBody scopexportablemoduleBody = ScopexportablemoduleBody.Action(array_SCOPEXPORTABLEEXTRACTFORM, array, scopexportablemoduleHeader.ScopexportableportHeader.ScopexportableheadersolidArray);

            ScopexportablemoduleHierarchy scopexportablemoduleHierarchy = ScopexportablemoduleHierarchy.Action(array_SCOPEXPORTABLEEXTRACTFORM, array, scopexportablemoduleHeader.ScopexportableportHeader.ScopexportableheadersolidArray, scopexportablemoduleBody.ScopexportableportBody.ScopexportablebodysolidArray);

            ScopexportablemoduleUnite scopexportablemoduleUnite = ScopexportablemoduleUnite.Action(array_SCOPEXPORTABLEEXTRACTFORM, array, scopexportablemoduleHeader.ScopexportableportHeader.ScopexportableheadersolidArray, scopexportablemoduleBody.ScopexportableportBody.ScopexportablebodysolidArray, scopexportablemoduleHierarchy.ScopexportableportHierarchy.ScopexportablehierarchysolidArray);

            var inflect = new Object[4];

            inflect[0] = scopexportablemoduleHeader;

            inflect[1] = scopexportablemoduleBody;

            inflect[2] = scopexportablemoduleHierarchy;

            inflect[3] = scopexportablemoduleUnite;

            var result = inflect;

            arrayResult = result;
        
            return arrayResult;
        }
    }
}
