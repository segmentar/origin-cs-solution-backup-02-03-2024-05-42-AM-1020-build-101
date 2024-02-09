using Core;

namespace Core
{
    using System;

    public partial class Materialxportable
    {
        public static void Log(Materialxportable materialxportable)
        {
            var array = Materialxportableargument.MaterialxportableargumentArgumentSetSurface(materialxportable);

            var first = array[0];

            Materialxportablelog.Log(first);

            return;
        }
    }
}
