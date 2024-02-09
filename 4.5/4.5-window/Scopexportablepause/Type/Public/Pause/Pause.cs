using Core;

namespace Core
{
    using System;

    public partial class Scopexportablepause
    {
        public static void Pause()
        {
            Scopexportablemonitorstate.IsPause = Scopexportablemonitorstate.IsPause.Equals(false);

            return;
        }
    }
}
