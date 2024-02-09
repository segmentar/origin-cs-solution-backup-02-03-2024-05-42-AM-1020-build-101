using Core;

namespace Core
{
    using System;

    public partial class Scopexportableaccumulate
    {
        public static Scopexportableformbuildsolid[] ForgeDefault(Scopexportableformcoordinate[] array_SCOPEXPORTABLEEXTRACTFORM, Boolean answer_IDENTITY_should, Boolean answer_PERFORM_should)
        {
            Scopexportableformbuildsolid[] arrayResult = default;

            var array = Accumulate(array_SCOPEXPORTABLEEXTRACTFORM, answer_IDENTITY_should, answer_PERFORM_should);

            var reflect = (ScopexportablemoduleUnite)(array[3] as Object);

            var result = reflect.ScopexportableportUnite.ScopexportableaccumulatesolidArray;

            arrayResult = result;

            return arrayResult;
        }
    }
}
