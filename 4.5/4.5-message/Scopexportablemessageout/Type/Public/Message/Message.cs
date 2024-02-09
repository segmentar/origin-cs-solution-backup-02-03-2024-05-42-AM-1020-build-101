using Core;

namespace Core
{
    using System;

    public partial class Scopexportablemessageout
    {
        public static void Message(String Message_VALUE)
        {
            //Console.Out.WriteLine($"out msg -> {Message_VALUE}");

            var value = ScopexportableasyncMessageout.GroupDepth(true, false, false, false, false, true, Message_VALUE);

            Scopexportableasync.ScopexportableasyncThreadStartDispenser(value, 100);

            return;
        }
    }
}
