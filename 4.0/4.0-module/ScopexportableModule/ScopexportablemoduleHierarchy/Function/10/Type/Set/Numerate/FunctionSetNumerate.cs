using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class ScopexportablemoduleHierarchy
    {
        public partial class XDecuple
        {
            public static IList<Scopexportablehierarchynumeratesolid> FunctionNumerateSet(ScopexportablelevelHierarchyUop_rstV Level_VALUE)
            {
                ICollection<Scopexportablehierarchynumeratesolid> collectionResult = default;

                collectionResult = new Collection<Scopexportablehierarchynumeratesolid>();

                foreach (XNonuple xnonuple in Level_VALUE.XNonupleArray)
                {
                    Scopexportablehierarchynumeratesolid scopexportablehierarchynumeratesolid;

                    scopexportablehierarchynumeratesolid = new Scopexportablehierarchynumeratesolid();

                    scopexportablehierarchynumeratesolid.ObjectValue = xnonuple.ObjectValue;

                    scopexportablehierarchynumeratesolid.PositionLeft = xnonuple.PositionLeft;

                    scopexportablehierarchynumeratesolid.PositionRight = xnonuple.PositionRight;

                    scopexportablehierarchynumeratesolid.CharacterLeft = xnonuple.CharacterLeft;

                    scopexportablehierarchynumeratesolid.CharacterRight = xnonuple.CharacterRight;

                    scopexportablehierarchynumeratesolid.Value = xnonuple.Value;

                    scopexportablehierarchynumeratesolid.ObjectArray = xnonuple.ObjectArray;

                    scopexportablehierarchynumeratesolid.ObjectValueParent = xnonuple.ObjectValueParent;

                    scopexportablehierarchynumeratesolid.Real = xnonuple.Real;

                    scopexportablehierarchynumeratesolid.Identity = xnonuple.Identity;

                    scopexportablehierarchynumeratesolid.Link = xnonuple.Link;

                    scopexportablehierarchynumeratesolid.RequireShould = xnonuple.Scopexportableseasonunwrap.RequireShould;

                    scopexportablehierarchynumeratesolid.OptionShould = xnonuple.Scopexportableseasonunwrap.OptionShould;

                    scopexportablehierarchynumeratesolid.AnyShould = xnonuple.Scopexportableseasonunwrap.AnyShould;

                    scopexportablehierarchynumeratesolid.SomeShould = xnonuple.Scopexportableseasonunwrap.SomeShould;

                    scopexportablehierarchynumeratesolid.DivideShould = xnonuple.Scopexportableseasonunwrap.DivideShould;

                    scopexportablehierarchynumeratesolid.SequenceShould = xnonuple.Scopexportableseasonunwrap.SequenceShould;

                    scopexportablehierarchynumeratesolid.SequenceShould = xnonuple.Scopexportableseasonunwrap.SentenceShould;

                    scopexportablehierarchynumeratesolid.ParagraphShould = xnonuple.Scopexportableseasonunwrap.ParagraphShould;

                    collectionResult.Add(scopexportablehierarchynumeratesolid);

                    continue;
                }

                return new List<Scopexportablehierarchynumeratesolid>(collectionResult);
            }
        }
    }
}
