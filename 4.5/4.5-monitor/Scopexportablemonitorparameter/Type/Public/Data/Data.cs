using Core;

namespace Core
{
    using System;

    public partial struct Scopexportablemonitorparameter
    {
        public static Scopexportablemonitorparameter Data(Scopexportableformbuildsolid[] array_SCOPEXPORTABLEACCUMULATESOLID)
        {
            Scopexportablemonitorparameter scopexportablemonitorparameterResult = default;

            Scopexportablemonitorparameter scopexportablemonitorparameter;

            scopexportablemonitorparameter = new Scopexportablemonitorparameter();

            scopexportablemonitorparameter.ScopexportableaccumulatesolidArrayObject = array_SCOPEXPORTABLEACCUMULATESOLID;

            scopexportablemonitorparameterResult = scopexportablemonitorparameter;

            return scopexportablemonitorparameterResult;
        }
    }
}
