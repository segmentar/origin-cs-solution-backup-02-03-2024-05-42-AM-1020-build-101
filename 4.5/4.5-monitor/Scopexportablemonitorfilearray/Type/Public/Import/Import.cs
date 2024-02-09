using Core;

namespace Core
{
    using System;

    using System.IO;

    using System.Collections;

    public partial struct Scopexportablemonitorfilearray
    {
        public static void Import(Scopexportablemonitorfilearray value_SCOPEXPORTABLEMONITORFILEARRAY)
        {
            ScopexportableaccumulatesolidStack = Scopexportablemagic.ScopexportablemagicStackCastDispenser(value_SCOPEXPORTABLEMONITORFILEARRAY.ScopexportableaccumulatesolidStackObject);

            FileInfoArray = (FileInfo[])value_SCOPEXPORTABLEMONITORFILEARRAY.FileInfoArrayObject;

            FileInfoStack = (Stack)value_SCOPEXPORTABLEMONITORFILEARRAY.StackObject;

            Text = (String)value_SCOPEXPORTABLEMONITORFILEARRAY.TextObject;

            return;
        }
    }
}
