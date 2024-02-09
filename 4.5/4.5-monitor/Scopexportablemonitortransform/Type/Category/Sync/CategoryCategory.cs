using Core;

namespace Core
{
    using System;

    public partial struct Scopexportablemonitortransform
    {
        public static void CategorySync()
        {
            Scopexportablequeryvalid.Valid();

            Scopexportablevalidtransform.Transform();

            Idle = true;

            return;
        }
    }
}
