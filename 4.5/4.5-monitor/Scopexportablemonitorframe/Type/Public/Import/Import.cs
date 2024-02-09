using Core;

namespace Core
{
    using System;

    public partial struct Scopexportablemonitorframe
    {
        public static void Import(Scopexportablemonitorframe value_SCOPEXPORTABLEMFRAME)
        {
            LinkedList = Scopexportablemagic.ScopexportablemagicLinkedListCastDispenser<Scopexportablemonitortransaction>(value_SCOPEXPORTABLEMFRAME.LinkedListObject);

            Pointer = (Int32)value_SCOPEXPORTABLEMFRAME.PointerObject;
            
            return;
        }
    }
}
