using Core;

namespace Core
{
    using System;

    public partial class Scopexportablemessagein
    {
        public static void Message()
        {
            var value = ScopexportableasyncMessagein.GroupDepth(true, false, false, false, false, true);

            Scopexportableasync.ScopexportableasyncTaskStartDispenser(value, 1000);

            return;
        }
    }
}
