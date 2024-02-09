using Core;

namespace Core
{
    using System;

    public partial struct Scopexportablemonitorquery
    {
        public static void Import(Scopexportablemonitorquery value_SCOPEXPORTABLEMONITORQUERY)
        {
            Idle = (Boolean)value_SCOPEXPORTABLEMONITORQUERY.IdleObject;

            LinkedList = Scopexportablemagic.ScopexportablemagicLinkedListCastDispenser<Scopexportablehierarchynumeratesolid>(value_SCOPEXPORTABLEMONITORQUERY.LinkedListObject);

            Error = (Int32)value_SCOPEXPORTABLEMONITORQUERY.ErrorObject;

            Scopexportablehierarchynumeratesolid = (Scopexportablehierarchynumeratesolid)value_SCOPEXPORTABLEMONITORQUERY.ScopexportablehierarchynumeratesolidObject;

            return;
        }
    }
}
