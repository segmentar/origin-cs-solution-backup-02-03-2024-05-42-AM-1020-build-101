using Core;

namespace Core
{
    using System;

    public partial class Scopexportablebackward
    {
        public static void Backward()
        {
            Scopexportablemonitorframe.Pointer = Scopexportablemonitorframe.Pointer - 1;
            
            return;
        }
    }
}
