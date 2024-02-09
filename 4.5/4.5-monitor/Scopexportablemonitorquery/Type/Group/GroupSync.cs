using Core;

namespace Core
{
    using System;

    public partial struct Scopexportablemonitorquery
    {
        public static void CategorySync()
        {
            Error = Error + 1;

            Boolean isEqualCheck, shouldReturnCheck;

            isEqualCheck = Object.Equals(LinkedList.Count, Error) is true;

            shouldReturnCheck = isEqualCheck is true;

            if (shouldReturnCheck is true)
            {
                Idle = true;

                Scopexportablemonitortransform.Idle = false;

                return;
            }
            else
                "false".ToString();
            
            Scopexportablequeryrequire.Require();

            return;
        }
    }
}
