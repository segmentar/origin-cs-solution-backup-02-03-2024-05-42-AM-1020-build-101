using Core;

namespace Core
{
    using System;

    public partial class Scopexportablemessageout
    {
        public static void Message(String Message_VALUE)
        {
            var value = ScopexportableasyncMessageout.GroupDepth(false, true, Message_VALUE);

            Scopexportableasync.ScopexportableasyncThreadStartDispenser(value, 100);

            return;
        }
    }
}
