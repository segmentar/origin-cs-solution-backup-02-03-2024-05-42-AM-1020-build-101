using Core;

namespace Core
{
    using System;

    public partial class Scopexportablemonitor
    {
        public static Object[] Monitor()
        {
            Object[] arrayResult = default;

            var inflect = new Object[2];

            inflect[0] = ScopexportableasyncMonitor.GroupDepth(false, true, true, false, false, false);

            inflect[1] = Scopexportableasync.ScopexportableasyncThreadStartDispenser(inflect[0], 1000);

            var result = inflect;

            arrayResult = result;
            
            return arrayResult;
        }
    }
}
