using Core;

namespace Core
{
    using System;

    public partial struct Scopexportablemonitorframe
    {
        public static Scopexportablemonitorframe Export()
        {
            Scopexportablemonitorframe scopexportablemframeResult;

            Scopexportablemonitorframe scopexportablemframe;

            scopexportablemframe = new Scopexportablemonitorframe();

            scopexportablemframe.LinkedListObject = LinkedList;

            scopexportablemframe.PointerObject = Pointer;

            scopexportablemframeResult = scopexportablemframe;

            return scopexportablemframeResult;
        }
    }
}
