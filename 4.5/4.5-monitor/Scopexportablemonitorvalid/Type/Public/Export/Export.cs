using Core;

namespace Core
{
    using System;

    public partial struct Scopexportablemonitorvalid
    {
        public static Scopexportablemonitorvalid Export()
        {
            Scopexportablemonitorvalid scopexportablemonitorvalidResult = default;

            Scopexportablemonitorvalid scopexportablemonitorvalid;

            scopexportablemonitorvalid = new Scopexportablemonitorvalid();

            scopexportablemonitorvalid.IdleObject = Idle;

            scopexportablemonitorvalid.ScopexportablevalidObject = Scopexportablevalid;

            scopexportablemonitorvalid.ScopexportablevalidfileArrayObject = ScopexportablevalidfileArray;

            scopexportablemonitorvalid.ErrorObject = Error;

            scopexportablemonitorvalid.ScopexportablevalidfileObject = Scopexportablevalidfile;

            scopexportablemonitorvalid.TextObject = Text;

            scopexportablemonitorvalidResult = scopexportablemonitorvalid;

            return scopexportablemonitorvalidResult;
        }
    }
}
