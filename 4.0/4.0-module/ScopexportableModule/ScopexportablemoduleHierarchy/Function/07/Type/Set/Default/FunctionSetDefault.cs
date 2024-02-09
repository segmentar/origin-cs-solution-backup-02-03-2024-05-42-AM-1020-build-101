using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class ScopexportablemoduleHierarchy
    {
        public partial struct XSeptuple
        {
            public static IList<XSeptuple> FunctionDefaultSet(ScopexportablelevelHierarchyXopqrs_Y Level_VALUE)
            {
                ICollection<XSeptuple> collectionResult = default;

                collectionResult = new Collection<XSeptuple>();

                foreach (XSextuple xsextuple in Level_VALUE.XSextupleArray)
                {
                    Scopexportableseasonunwrap scopexportableseasonunwrap;

                    scopexportableseasonunwrap = new Scopexportableseasonunwrap();

                    Boolean[] booleanArray;

                    booleanArray = new Boolean[8];

                    booleanArray[0] = true;

                    booleanArray[0] = booleanArray[0] && xsextuple.Scopexportableseasonwrap.SummerIs is true;

                    if (booleanArray[0] is true)
                    {
                        scopexportableseasonunwrap.RequireShould = true;
                    }
                    else
                        "false".ToString();

                    XSeptuple xseptuple;

                    xseptuple = new XSeptuple();

                    xseptuple.ObjectValue = xsextuple.ObjectValue;

                    xseptuple.PositionLeft = xsextuple.PositionLeft;

                    xseptuple.PositionRight = xsextuple.PositionRight;

                    xseptuple.CharacterLeft = xsextuple.CharacterLeft;

                    xseptuple.CharacterRight = xsextuple.CharacterRight;

                    xseptuple.Value = xsextuple.Value;

                    xseptuple.ObjectArray = xsextuple.ObjectArray;

                    xseptuple.ObjectValueParent = xsextuple.ObjectValueParent;

                    xseptuple.Scopexportableseasonwrap = xsextuple.Scopexportableseasonwrap;

                    xseptuple.Scopexportableseasonunwrap = scopexportableseasonunwrap;

                    collectionResult.Add(xseptuple);

                    continue;
                }

                return new List<XSeptuple>(collectionResult);
            }
        }
    }
}
