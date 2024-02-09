using Core;

namespace Core
{
    using System;

    public partial struct Scopexportablevalidfile
    {
        public static Scopexportablevalidfile[] ScopexportablevalidfileSetDefaultSurface(Scopexportableformbuildsolid[] array_SCOPEXPORTABLEACCUMULATESOLID)
        {
            Scopexportablevalidfile[] arrayResult = default;

            var list = ScopexportablevalidfileSetDefault(array_SCOPEXPORTABLEACCUMULATESOLID);

            var array = new Scopexportablevalidfile[list.Count];

            list.CopyTo(array, ScopexportablePolicy.ScopexportableIndexPolicy);

            arrayResult = array;

            return arrayResult;
        }
    }
}
