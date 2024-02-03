using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Scopexportableaccumulate
    {
        public static Object[] Accumulate(Boolean answer_IDENTITY_should, Boolean answer_PERFORM_should)
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
            }
            else
                "false".ToString();

            var array = Scopexportableextract.Extract();

            var Unique_ARRAY = Scopexportableunique.ScopexportableUniqueSetSurface(array.Length);

            ScopexportablemoduleHeader scopexportablemoduleHeader = ScopexportablemoduleHeader.Action(array, Unique_ARRAY);

            ScopexportablemoduleBody scopexportablemoduleBody = ScopexportablemoduleBody.Action(array, Unique_ARRAY, scopexportablemoduleHeader.ScopexportableportHeader.ScopexportableheadersolidArray);

            ScopexportablemoduleHierarchy scopexportablemoduleHierarchy = ScopexportablemoduleHierarchy.Action(array, Unique_ARRAY, scopexportablemoduleHeader.ScopexportableportHeader.ScopexportableheadersolidArray, scopexportablemoduleBody.ScopexportableportBody.ScopexportablebodysolidArray);

            var inflect = new Object[3];

            inflect[0] = scopexportablemoduleHeader;

            inflect[1] = scopexportablemoduleBody;

            inflect[2] = scopexportablemoduleHierarchy;

            var result = inflect;

            arrayResult = result;
        
            return arrayResult;
        }
    }
}
