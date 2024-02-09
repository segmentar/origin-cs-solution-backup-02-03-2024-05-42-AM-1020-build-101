using Core;

namespace Core
{
    using System;

    public partial struct Scopexportablemonitorvalid
    {
        public static void GroupSync()
        {
            Boolean isEqualCheck, shouldReturnCheck;

            isEqualCheck = Idle is true;

            shouldReturnCheck = isEqualCheck is true;

            if (shouldReturnCheck is true)
            {
                return;
            }
            else
                "false".ToString();

            CategorySync();

            return;
        }
    }
}
