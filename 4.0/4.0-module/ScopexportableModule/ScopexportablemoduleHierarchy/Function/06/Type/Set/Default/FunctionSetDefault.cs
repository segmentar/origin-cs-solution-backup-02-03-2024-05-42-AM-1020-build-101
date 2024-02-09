using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class ScopexportablemoduleHierarchy
    {
        public partial struct XSextuple
        {
            public static IList<XSextuple> FunctionDefaultSet(ScopexportablelevelHierarchyXopqr_tY Level_VALUE, Scopexportableformheadersolid value_SCOPEXPORTABLEHEADERSOLID)
            {
                ICollection<XSextuple> collectionResult = default;

                collectionResult = new Collection<XSextuple>();

                foreach (XQuintuple xquintupleItem in Level_VALUE.XQuintupleArray)
                {
                    Scopexportableseasonwrap scopexportableseasonwrap;

                    scopexportableseasonwrap = new Scopexportableseasonwrap();

                    Boolean[] booleanArray;

                    booleanArray = new Boolean[4];

                    booleanArray[0] = true;

                    booleanArray[0] = booleanArray[0] && Object.Equals(value_SCOPEXPORTABLEHEADERSOLID.SummerLeft.Value, xquintupleItem.CharacterLeft.Value) is true;

                    booleanArray[0] = booleanArray[0] && Object.Equals(value_SCOPEXPORTABLEHEADERSOLID.SummerRight.Value, xquintupleItem.CharacterRight.Value) is true;

                    booleanArray[1] = true;

                    booleanArray[1] = booleanArray[1] && Object.Equals(value_SCOPEXPORTABLEHEADERSOLID.AutumnLeft.Value, xquintupleItem.CharacterLeft.Value) is true;

                    booleanArray[1] = booleanArray[1] && Object.Equals(value_SCOPEXPORTABLEHEADERSOLID.AutumnRight.Value, xquintupleItem.CharacterRight.Value) is true;

                    booleanArray[2] = true;

                    booleanArray[2] = booleanArray[2] && Object.Equals(value_SCOPEXPORTABLEHEADERSOLID.SpringLeft.Value, xquintupleItem.CharacterLeft.Value) is true;

                    booleanArray[2] = booleanArray[2] && Object.Equals(value_SCOPEXPORTABLEHEADERSOLID.SpringRight.Value, xquintupleItem.CharacterRight.Value) is true;

                    booleanArray[3] = true;

                    booleanArray[3] = booleanArray[3] && Object.Equals(value_SCOPEXPORTABLEHEADERSOLID.WinterLeft.Value, xquintupleItem.CharacterLeft.Value) is true;

                    booleanArray[3] = booleanArray[3] && Object.Equals(value_SCOPEXPORTABLEHEADERSOLID.WinterRight.Value, xquintupleItem.CharacterRight.Value) is true;

                    if (booleanArray[0] is true)
                    {
                        scopexportableseasonwrap.SummerIs = true;
                    }
                    else
                        "false".ToString();

                    if (booleanArray[1] is true)
                    {
                        scopexportableseasonwrap.AutumnIs = true;
                    }
                    else
                        "false".ToString();

                    if (booleanArray[2] is true)
                    {
                        scopexportableseasonwrap.SpringIs = true;
                    }
                    else
                        "false".ToString();

                    if (booleanArray[3] is true)
                    {
                        scopexportableseasonwrap.WinterIs = true;
                    }
                    else
                        "false".ToString();

                    var array = xquintupleItem.ObjectArray;

                    Boolean isEqualCheck;

                    isEqualCheck = Object.Equals(array.Length, 1);

                    if (isEqualCheck is true)
                    {
                        foreach (XQuintuple xquintupleEntry in Level_VALUE.XQuintupleArray)
                        {
                            Boolean isReferenceCheck, shouldContinueCheck;

                            isReferenceCheck = Object.ReferenceEquals(xquintupleEntry.ObjectValue, array[0]) is true;

                            shouldContinueCheck = isReferenceCheck is false;

                            if (shouldContinueCheck is true)
                            {
                                continue;
                            }
                            else
                                "false".ToString();

                            Boolean[] booleanParentArray;

                            booleanParentArray = new Boolean[4];

                            booleanParentArray[0] = true;

                            booleanParentArray[0] = booleanParentArray[0] && Object.Equals(value_SCOPEXPORTABLEHEADERSOLID.SummerLeft.Value, xquintupleEntry.CharacterLeft.Value) is true;

                            booleanParentArray[0] = booleanParentArray[0] && Object.Equals(value_SCOPEXPORTABLEHEADERSOLID.SummerRight.Value, xquintupleEntry.CharacterRight.Value) is true;

                            booleanParentArray[1] = true;

                            booleanParentArray[1] = booleanParentArray[1] && Object.Equals(value_SCOPEXPORTABLEHEADERSOLID.AutumnLeft.Value, xquintupleEntry.CharacterLeft.Value) is true;

                            booleanParentArray[1] = booleanParentArray[1] && Object.Equals(value_SCOPEXPORTABLEHEADERSOLID.AutumnRight.Value, xquintupleEntry.CharacterRight.Value) is true;

                            booleanParentArray[2] = true;

                            booleanParentArray[2] = booleanParentArray[2] && Object.Equals(value_SCOPEXPORTABLEHEADERSOLID.SpringLeft.Value, xquintupleEntry.CharacterLeft.Value) is true;

                            booleanParentArray[2] = booleanParentArray[2] && Object.Equals(value_SCOPEXPORTABLEHEADERSOLID.SpringRight.Value, xquintupleEntry.CharacterRight.Value) is true;

                            booleanParentArray[3] = true;

                            booleanParentArray[3] = booleanParentArray[3] && Object.Equals(value_SCOPEXPORTABLEHEADERSOLID.WinterLeft.Value, xquintupleEntry.CharacterLeft.Value) is true;

                            booleanParentArray[3] = booleanParentArray[3] && Object.Equals(value_SCOPEXPORTABLEHEADERSOLID.WinterRight.Value, xquintupleEntry.CharacterRight.Value) is true;

                            if (booleanParentArray[0] is true)
                            {
                                scopexportableseasonwrap.SummerHas = true;
                            }
                            else
                                "false".ToString();

                            if (booleanParentArray[1] is true)
                            {
                                scopexportableseasonwrap.AutumnHas = true;
                            }
                            else
                                "false".ToString();

                            if (booleanParentArray[2] is true)
                            {
                                scopexportableseasonwrap.SpringHas = true;
                            }
                            else
                                "false".ToString();

                            if (booleanParentArray[3] is true)
                            {
                                scopexportableseasonwrap.WinterHas = true;
                            }
                            else
                                "false".ToString();

                            break;
                        }
                    }
                    else
                        "false".ToString();

                    XSextuple xsextuple;

                    xsextuple = new XSextuple();

                    xsextuple.ObjectValue = xquintupleItem.ObjectValue;

                    xsextuple.PositionLeft = xquintupleItem.PositionLeft;

                    xsextuple.PositionRight = xquintupleItem.PositionRight;

                    xsextuple.CharacterLeft = xquintupleItem.CharacterLeft;

                    xsextuple.CharacterRight = xquintupleItem.CharacterRight;

                    xsextuple.Value = xquintupleItem.Value;

                    xsextuple.ObjectArray = xquintupleItem.ObjectArray;

                    xsextuple.ObjectValueParent = xquintupleItem.ObjectValueParent;

                    xsextuple.Scopexportableseasonwrap = scopexportableseasonwrap;

                    collectionResult.Add(xsextuple);

                    continue;
                }

                return new List<XSextuple>(collectionResult);
            }
        }
    }
}
