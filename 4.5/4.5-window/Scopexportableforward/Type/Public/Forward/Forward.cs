using Core;

namespace Core
{
    using System;

    public partial class Scopexportableforward
    {
        public static void Forward()
        {
            Scopexportablemonitorframe.Pointer = Scopexportablemonitorframe.Pointer + 1;

            return;
        }
    }
}
