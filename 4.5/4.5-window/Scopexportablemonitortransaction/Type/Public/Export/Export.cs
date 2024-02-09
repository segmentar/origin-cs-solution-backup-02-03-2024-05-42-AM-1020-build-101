using Core;

namespace Core
{
    using System;

    public partial struct Scopexportablemonitortransaction
    {
        public void Export()
        {
            Scopexportablemonitorexpression.Import(Scopexportablemonitorexpression);

            Scopexportablemonitorparameter.Import(Scopexportablemonitorparameter);

            Scopexportablemonitorstate.Import(Scopexportablemonitorstate);

            Scopexportablemonitorframe.Import(Scopexportablemonitorframe);

            Scopexportablemonitorfilearray.Import(Scopexportablemonitorfilearray);

            Scopexportablemonitorvalid.Import(Scopexportablemonitorvalid);

            Scopexportablemonitortext.Import(Scopexportablemonitortext);

            Scopexportablemonitorquery.Import(Scopexportablemonitorquery);

            Scopexportablemonitortransform.Import(Scopexportablemonitortransform);

            return;
        }
    }
}
