using Core;

namespace Core
{
    using System;

    public partial struct Scopexportablemonitorvalid
    {
        public static Scopexportablemonitorvalid Data(Scopexportableformbuildsolid[] array_SCOPEXPORTABLEACCUMULATESOLID)
        {
            Scopexportablemonitorvalid scopexportablemonitorvalidResult = default;

            Scopexportablemonitorvalid scopexportablemonitorvalid;

            scopexportablemonitorvalid = new Scopexportablemonitorvalid();

            scopexportablemonitorvalid.IdleObject = true;

            scopexportablemonitorvalid.ScopexportablevalidObject = Scopexportablevalid.ForgeDefault(array_SCOPEXPORTABLEACCUMULATESOLID);

            scopexportablemonitorvalid.ScopexportablevalidfileArrayObject = Scopexportablevalidfile.ScopexportablevalidfileSetDefaultSurface(array_SCOPEXPORTABLEACCUMULATESOLID);

            scopexportablemonitorvalid.ErrorObject = -1;

            scopexportablemonitorvalid.ScopexportablevalidfileObject = default(Scopexportablevalidfile);

            scopexportablemonitorvalid.TextObject = Scopexportablestringsafe.ForgeDefault(String.Empty);

            scopexportablemonitorvalidResult = scopexportablemonitorvalid;

            return scopexportablemonitorvalidResult;
        }
    }
}
