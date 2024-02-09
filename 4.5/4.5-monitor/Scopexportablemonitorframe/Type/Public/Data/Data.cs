using Core;

namespace Core
{
    using System;

    public partial struct Scopexportablemonitorframe
    {
        public static Scopexportablemonitorframe Data()
        {
            Scopexportablemonitorframe scopexportablemframeResult;

            Scopexportablemonitorframe scopexportablemframe;

            scopexportablemframe = new Scopexportablemonitorframe();

            scopexportablemframe.LinkedListObject = Scopexportablemagic.ScopexportablemagicLinkedListDispenser<Scopexportablemonitortransaction>(new Scopexportablemonitortransaction[0]);

            scopexportablemframe.PointerObject = 0;

            scopexportablemframeResult = scopexportablemframe;

            return scopexportablemframeResult;
        }
    }
}
