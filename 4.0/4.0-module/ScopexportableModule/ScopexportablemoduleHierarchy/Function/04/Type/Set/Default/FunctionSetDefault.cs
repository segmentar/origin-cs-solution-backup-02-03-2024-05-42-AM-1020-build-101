using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class ScopexportablemoduleHierarchy
    {
        public partial struct XQuadruple
        {
            public static IList<XQuadruple> FunctionDefaultSet(ScopexportablelevelHierarchyXop_rstY Level_VALUE)
            {
                ICollection<XQuadruple> collectionResult = default;

                collectionResult = new Collection<XQuadruple>();

                foreach (XTriple xtripleItem in Level_VALUE.XTripleArray)
                {
                    var list = Scopexportablemagic.ScopexportablemagicArrayListDispenser(new Object[0]);

                    foreach (XTriple xtripleEntry in Level_VALUE.XTripleArray)
                    {
                        var boolean = true;

                        boolean = boolean && (xtripleItem.PositionLeft < xtripleEntry.PositionLeft).Equals(true);

                        boolean = boolean && (xtripleItem.PositionRight > xtripleEntry.PositionRight).Equals(true);

                        Boolean isEqualCheck, shouldContinueCheck;

                        isEqualCheck = boolean is true;

                        shouldContinueCheck = isEqualCheck is false;

                        if (shouldContinueCheck is true)
                        {
                            continue;
                        }
                        else
                            "false".ToString();

                        list.Add(xtripleEntry.ObjectValue);

                        continue;
                    }

                    var array = new Object[list.Count];

                    list.CopyTo(array, ScopexportablePolicy.ScopexportableIndexPolicy);

                    XQuadruple xquadruple;

                    xquadruple = new XQuadruple();

                    xquadruple.ObjectValue = xtripleItem.ObjectValue;

                    xquadruple.PositionLeft = xtripleItem.PositionLeft;

                    xquadruple.PositionRight = xtripleItem.PositionRight;

                    xquadruple.CharacterLeft = xtripleItem.CharacterLeft;

                    xquadruple.CharacterRight = xtripleItem.CharacterRight;

                    xquadruple.Value = xtripleItem.Value;

                    xquadruple.ObjectArray = array;

                    collectionResult.Add(xquadruple);

                    continue;
                }

                return new List<XQuadruple>(collectionResult);
            }
        }
    }
}
