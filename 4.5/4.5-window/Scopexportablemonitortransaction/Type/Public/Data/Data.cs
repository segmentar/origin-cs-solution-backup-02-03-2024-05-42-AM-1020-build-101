using Core;

namespace Core
{
    using System;

    public partial struct Scopexportablemonitortransaction
    {
        public static Scopexportablemonitortransaction Data()
        {
            Scopexportablemonitortransaction ScopexportablemonitortransactionResult = default;

            Scopexportablemonitortransaction Scopexportablemonitortransaction;

            Scopexportablemonitortransaction = new Scopexportablemonitortransaction();

            Scopexportablemonitortransaction.Import();

            Scopexportablemonitortransaction.Export();

            ScopexportablemonitortransactionResult = Scopexportablemonitortransaction;

            return ScopexportablemonitortransactionResult;
        }
    }
}
