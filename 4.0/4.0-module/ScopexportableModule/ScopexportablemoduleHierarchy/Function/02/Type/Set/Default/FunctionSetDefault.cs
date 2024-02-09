using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.IO;

    public partial class ScopexportablemoduleHierarchy
    {
        public partial struct XDouble
        {
            public static IList<XDouble> FunctionDefaultSet(ScopexportablelevelHierarchyX_pqrstY Level_VALUE, Scopexportableformheadersolid value_SCOPEXPORTABLEHEADERSOLID, Scopexportableformbodysolid value_SCOPEXPORTABLEBODYSOLID)
            {
                ICollection<XDouble> collectionResult = default;

                collectionResult = new Collection<XDouble>();

                var deflect = new IEnumerable[3];

                deflect[0] = new Char[8] {

                    value_SCOPEXPORTABLEHEADERSOLID.SummerLeft.Value,
                    value_SCOPEXPORTABLEHEADERSOLID.AutumnLeft.Value,
                    value_SCOPEXPORTABLEHEADERSOLID.SpringLeft.Value,
                    value_SCOPEXPORTABLEHEADERSOLID.WinterLeft.Value,
                    value_SCOPEXPORTABLEHEADERSOLID.SummerRight.Value,
                    value_SCOPEXPORTABLEHEADERSOLID.AutumnRight.Value,
                    value_SCOPEXPORTABLEHEADERSOLID.SpringRight.Value,
                    value_SCOPEXPORTABLEHEADERSOLID.WinterRight.Value,
                };

                deflect[1] = new Char[4] {

                    value_SCOPEXPORTABLEHEADERSOLID.SummerLeft.Value,
                    value_SCOPEXPORTABLEHEADERSOLID.AutumnLeft.Value,
                    value_SCOPEXPORTABLEHEADERSOLID.SpringLeft.Value,
                    value_SCOPEXPORTABLEHEADERSOLID.WinterLeft.Value
                };

                deflect[2] = new Char[4] {

                    value_SCOPEXPORTABLEHEADERSOLID.SummerRight.Value,
                    value_SCOPEXPORTABLEHEADERSOLID.AutumnRight.Value,
                    value_SCOPEXPORTABLEHEADERSOLID.SpringRight.Value,
                    value_SCOPEXPORTABLEHEADERSOLID.WinterRight.Value
                };

                var indexer = 0;

                foreach (Char character in value_SCOPEXPORTABLEBODYSOLID.Hierarchy.Value)
                {
                    var error = -1;

                    foreach (Char item in deflect[0])
                    {
                        error = error + 1;

                        Boolean isEqualCheck, shouldContinueCheck;

                        isEqualCheck = Object.Equals(character, item) is true;

                        shouldContinueCheck = isEqualCheck is false;

                        if (shouldContinueCheck is true)
                        {
                            continue;
                        }
                        else
                            "false".ToString();

                        var symmetry = 0;

                        symmetry = symmetry + (Int32)character;

                        symmetry = symmetry + (Int32)item;

                        var symmetryf = ((Single)symmetry / 2.00F);

                        var convert = Convert.ToInt32(symmetryf);

                        var value = Scopexportablecharactersafe.ForgeDefault((Char)convert);

                        var opposite = (error >= 4).Equals(true);

                        Scopexportablecharactersafe characterOpposite;

                        if (opposite)
                        {
                            var offset = (error - 4);

                            characterOpposite = Scopexportablecharactersafe.ForgeDefault(((Char[])deflect[1])[offset]);
                        }
                        else
                        {
                            characterOpposite = Scopexportablecharactersafe.ForgeDefault(((Char[])deflect[2])[error]);
                        }

                        XDouble xdouble;

                        xdouble = new XDouble();

                        xdouble.Position = indexer;

                        xdouble.Character = value;

                        xdouble.Opposite = opposite;

                        xdouble.CharacterOpposite = characterOpposite;

                        collectionResult.Add(xdouble);

                        continue;
                    }

                    indexer = indexer + 1;

                    continue;
                }

                return new List<XDouble>(collectionResult);
            }
        }
    }
}
