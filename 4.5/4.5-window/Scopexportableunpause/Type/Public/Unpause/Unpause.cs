using Core;

namespace Core
{
    using System;

    public partial class Scopexportableunpause
    {
        public static void Unpause()
        {
            Scopexportablemonitorvalid.GroupSync();

            Scopexportablemonitortext.GroupSync();

            Scopexportablemonitorquery.GroupSync();

            Scopexportablemonitortransform.GroupSync();

            return;
        }
    }
}
