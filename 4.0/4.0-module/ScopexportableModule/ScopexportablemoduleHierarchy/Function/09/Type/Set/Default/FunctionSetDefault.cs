using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class ScopexportablemoduleHierarchy
    {
        public partial struct XNonuple
        {
            public static IList<XNonuple> FunctionDefaultSet(ScopexportablelevelHierarchyUo_qrstV Level_VALUE)
            {
                ICollection<XNonuple> collectionResult = default;

                collectionResult = new Collection<XNonuple>();

                foreach (XOctuple xoctuple in Level_VALUE.XOctupleArray)
                {
                    var value = new String((Char)Scopexportableascii.EntityColon, 2);

                    var separator = new String[1];

                    separator[0] = value;

                    var split = xoctuple.Real.Value.Split(separator, StringSplitOptions.None);

                    String[] stringArray;

                    stringArray = new String[2];

                    stringArray[0] = String.Empty;

                    stringArray[1] = String.Empty;

                    Boolean isEqualCheck;

                    isEqualCheck = Object.Equals(split.Length, 2) is true;

                    if (isEqualCheck is true)
                    {
                        var first = split[0];

                        var second = split[1];

                        stringArray[0] = first;

                        stringArray[1] = second;
                    }
                    else
                        "false".ToString();

                    XNonuple xnonuple;

                    xnonuple = new XNonuple();

                    xnonuple.ObjectValue = xoctuple.ObjectValue;

                    xnonuple.PositionLeft = xoctuple.PositionLeft;

                    xnonuple.PositionRight = xoctuple.PositionRight;

                    xnonuple.CharacterLeft = xoctuple.CharacterLeft;

                    xnonuple.CharacterRight = xoctuple.CharacterRight;

                    xnonuple.Value = xoctuple.Value;

                    xnonuple.ObjectArray = xoctuple.ObjectArray;

                    xnonuple.ObjectValueParent = xoctuple.ObjectValueParent;

                    xnonuple.Scopexportableseasonwrap = xoctuple.Scopexportableseasonwrap;

                    xnonuple.Scopexportableseasonunwrap = xoctuple.Scopexportableseasonunwrap;

                    xnonuple.Real = xoctuple.Real;

                    xnonuple.Identity = Scopexportablestringsafe.ForgeDefault(stringArray[0]);

                    xnonuple.Link = Scopexportablestringsafe.ForgeDefault(stringArray[1]);                    

                    collectionResult.Add(xnonuple);

                    continue;
                }


                return new List<XNonuple>(collectionResult);
            }
        }
    }
}
