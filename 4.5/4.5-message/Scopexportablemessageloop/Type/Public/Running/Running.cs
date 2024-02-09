using Core;

namespace Core
{
    using System;

    public partial class Scopexportablemessageloop
    {
        public static Boolean Running()
        {
            Boolean booleanResult = false;

            if (MessageLoopShould is true)
            {
                booleanResult = true;
            }
            else
                "false".ToString();
            
            return booleanResult;
        }
    }
}
