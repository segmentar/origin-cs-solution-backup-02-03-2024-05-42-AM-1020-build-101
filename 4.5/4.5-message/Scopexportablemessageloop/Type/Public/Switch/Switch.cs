using Core;

namespace Core
{
    using System;

    public partial class Scopexportablemessageloop
    {
        public static void Switch()
        {
            MessageLoopShould = MessageLoopShould.Equals(false);

            return;
        }
    }
}
