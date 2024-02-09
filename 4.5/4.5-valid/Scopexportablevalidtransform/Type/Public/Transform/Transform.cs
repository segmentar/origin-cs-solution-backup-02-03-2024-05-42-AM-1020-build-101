using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class Scopexportablevalidtransform
    {
        public static void Transform()
        {
            var list = Scopexportablemagic.ScopexportablemagicArrayListDispenser(Scopexportablemonitorvalid.Scopexportablevalid.Scopexportablevalidenum.Valid);

            foreach (KeyValuePair<Scopexportableformbuildsolid, Boolean> keyValuePair in list)
            {
                Boolean isEqualCheck, shouldContinueCheck;

                isEqualCheck = keyValuePair.Value is true;

                shouldContinueCheck = isEqualCheck is false;

                if (shouldContinueCheck is true)
                {
                    continue;
                }
                else
                    "false".ToString();

                Bootxportablemain.Main(keyValuePair.Key, true, false);

                continue;
            }

            return;
        }
    }
}
