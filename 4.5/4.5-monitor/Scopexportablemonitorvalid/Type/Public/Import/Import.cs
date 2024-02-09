using Core;

namespace Core
{
    using System;

    public partial struct Scopexportablemonitorvalid
    {
        public static void Import(Scopexportablemonitorvalid value_SCOPEXPORTABLEMONITORVALID)
        {
            Idle = (Boolean)value_SCOPEXPORTABLEMONITORVALID.IdleObject;

            Scopexportablevalid = (Scopexportablevalid)value_SCOPEXPORTABLEMONITORVALID.ScopexportablevalidObject;

            ScopexportablevalidfileArray = (Scopexportablevalidfile[])value_SCOPEXPORTABLEMONITORVALID.ScopexportablevalidfileArrayObject;

            Error = (Int32)value_SCOPEXPORTABLEMONITORVALID.ErrorObject;

            Scopexportablevalidfile = (Scopexportablevalidfile)value_SCOPEXPORTABLEMONITORVALID.ScopexportablevalidfileObject;

            Text = (Scopexportablestringsafe)value_SCOPEXPORTABLEMONITORVALID.TextObject;

            return;
        }
    }
}
