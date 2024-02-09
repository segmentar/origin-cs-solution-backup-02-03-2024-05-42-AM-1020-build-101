using Core;

namespace Core
{
    using System;

    public partial struct Scopexportablemonitortransaction
    {
        public void Import()
        {
            Scopexportablemonitorexpression = Scopexportablemonitorexpression.Export();

            Scopexportablemonitorparameter = Scopexportablemonitorparameter.Export();

            Scopexportablemonitorstate = Scopexportablemonitorstate.Export();

            Scopexportablemonitorframe = Scopexportablemonitorframe.Export();

            Scopexportablemonitorfilearray = Scopexportablemonitorfilearray.Export();

            Scopexportablemonitorvalid = Scopexportablemonitorvalid.Export();

            Scopexportablemonitortext = Scopexportablemonitortext.Export();

            Scopexportablemonitorquery = Scopexportablemonitorquery.Export();

            Scopexportablemonitortransform = Scopexportablemonitortransform.Export();

            return;
        }
    }
}
