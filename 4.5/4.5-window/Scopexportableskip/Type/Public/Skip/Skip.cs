using Core;

namespace Core
{
    using System;

    public partial class Scopexportableskip
    {
        public static void Skip()
        {
            Scopexportablemonitorstate.SkipShould = Scopexportablemonitorstate.SkipShould.Equals(false);

            return;
        }
    }
}
