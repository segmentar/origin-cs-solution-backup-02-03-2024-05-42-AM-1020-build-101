using Core;

namespace Core
{
    using System;

    public partial struct Scopexportablemonitortransform
    {
        public static Scopexportablemonitortransform Export()
        {
            Scopexportablemonitortransform scopexportablemonitortransformResult = default;

            Scopexportablemonitortransform scopexportablemonitortransform;

            scopexportablemonitortransform = new Scopexportablemonitortransform();

            scopexportablemonitortransform.IdleObject = Idle;

            scopexportablemonitortransformResult = scopexportablemonitortransform;

            return scopexportablemonitortransformResult;
        }
    }
}
