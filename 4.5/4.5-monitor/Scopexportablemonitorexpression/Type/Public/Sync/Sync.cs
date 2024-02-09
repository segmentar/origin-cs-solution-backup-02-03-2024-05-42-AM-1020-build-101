using Core;

namespace Core
{
    using System;

    public partial struct Scopexportablemonitorexpression
    {
        public static void Sync()
        {
            Expression = Bootxportablemonitor.Monitor();

            return;
        }
    }
}
