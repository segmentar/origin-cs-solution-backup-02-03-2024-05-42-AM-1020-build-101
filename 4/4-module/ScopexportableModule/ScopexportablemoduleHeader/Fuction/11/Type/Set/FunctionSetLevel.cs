﻿using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class ScopexportablemoduleHeader
    {
        public static IList<Scopexportableheadersolid> FunctionLevelSet(ScopexportablelevelHeaderUopq_stV[] Level_ARRAY)
        {
            ICollection<Scopexportableheadersolid> collectionResult = default;

            collectionResult = new Collection<Scopexportableheadersolid>();

            foreach (ScopexportablelevelHeaderUopq_stV Level_VALUE in Level_ARRAY)
            {
                Scopexportableheadersolid scopexportableheadersolid;

                scopexportableheadersolid = new Scopexportableheadersolid();

                scopexportableheadersolid.Object = Level_VALUE.Object;

                scopexportableheadersolid.Mid = Level_VALUE.Mid;

                scopexportableheadersolid.Header = Level_VALUE.Header;

                scopexportableheadersolid.HeaderArray = Level_VALUE.HeaderArray;

                scopexportableheadersolid.SummerLeft = Level_VALUE.SummerLeft;

                scopexportableheadersolid.SummerRight = Level_VALUE.SummerRight;

                scopexportableheadersolid.AutumnLeft = Level_VALUE.AutumnLeft;

                scopexportableheadersolid.AutumnRight = Level_VALUE.AutumnRight;

                scopexportableheadersolid.SpringLeft = Level_VALUE.SpringLeft;

                scopexportableheadersolid.SpringRight = Level_VALUE.SpringRight;

                scopexportableheadersolid.WinterLeft = Level_VALUE.WinterLeft;

                scopexportableheadersolid.WinterRight = Level_VALUE.WinterRight;

                scopexportableheadersolid.Escape = Level_VALUE.Escape;

                scopexportableheadersolid.Extension = Level_VALUE.Extension;

                collectionResult.Add(scopexportableheadersolid);

                continue;
            }

            return new List<Scopexportableheadersolid>(collectionResult);
        }
    }
}
