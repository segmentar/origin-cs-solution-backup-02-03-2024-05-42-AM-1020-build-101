using Core;

namespace Core
{
    using System;

    public partial struct Scopexportablemonitorparameter
    {
        public static Scopexportablemonitorparameter Export()
        {
            Scopexportablemonitorparameter scopexportablemonitorparameterResult = default;

            Scopexportablemonitorparameter scopexportablemonitorparameter;

            scopexportablemonitorparameter = new Scopexportablemonitorparameter();

            scopexportablemonitorparameter.ScopexportableaccumulatesolidArrayObject = ScopexportableaccumulatesolidArray;

            scopexportablemonitorparameterResult = scopexportablemonitorparameter;

            return scopexportablemonitorparameterResult;
        }
    }
}
