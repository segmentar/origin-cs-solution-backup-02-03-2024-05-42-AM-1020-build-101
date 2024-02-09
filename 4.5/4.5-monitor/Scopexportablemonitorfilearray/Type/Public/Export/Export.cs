using Core;

namespace Core
{
    using System;

    public partial struct Scopexportablemonitorfilearray
    {
        public static Scopexportablemonitorfilearray Export()
        {
            Scopexportablemonitorfilearray scopexportablemonitorfilearrayResult = default;

            Scopexportablemonitorfilearray scopexportablemonitorfilearray;

            scopexportablemonitorfilearray = new Scopexportablemonitorfilearray();

            scopexportablemonitorfilearray.ScopexportableaccumulatesolidStackObject = ScopexportableaccumulatesolidStack;

            scopexportablemonitorfilearray.FileInfoArrayObject = FileInfoArray;

            scopexportablemonitorfilearray.StackObject = FileInfoStack;

            scopexportablemonitorfilearray.TextObject = Text;

            scopexportablemonitorfilearrayResult = scopexportablemonitorfilearray;

            return scopexportablemonitorfilearrayResult;
        }
    }
}
