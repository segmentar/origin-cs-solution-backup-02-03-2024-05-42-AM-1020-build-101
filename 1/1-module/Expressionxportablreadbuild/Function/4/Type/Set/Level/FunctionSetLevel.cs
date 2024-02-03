using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class ExpressionxportablereadbuildModule
    {
        public static IList<ExpressionxportablereadXopq_stY> FunctionLevelSet(ExpressionxportablereadXop_rstY[] Level_ARRAY)
        {
            ICollection<ExpressionxportablereadXopq_stY> collectionResult = default;

            collectionResult = new Collection<ExpressionxportablereadXopq_stY>();

            foreach (ExpressionxportablereadXop_rstY Level_VALUE in Level_ARRAY)
            {
                Expressionxportable expressionxportable;

                expressionxportable = new ExpressionxportableSimple(Level_VALUE.Identity, Level_VALUE.Object).Result;

                ExpressionxportablereadXopq_stY level;

                level = new ExpressionxportablereadXopq_stY();

                level.Ordinal = Level_VALUE.Ordinal;

                level.Layer = Level_VALUE.Layer;

                level.Relate = Level_VALUE.Relate;

                level.ObjectStartAddress = Level_VALUE.ObjectStartAddress;

                level.ObjectEndAddress = Level_VALUE.ObjectEndAddress;

                level.TypeStartAddress = Level_VALUE.TypeStartAddress;

                level.TypeEndAddress = Level_VALUE.TypeEndAddress;

                level.Identity = Level_VALUE.Identity;

                level.ObjectByteArray = Level_VALUE.ObjectByteArray;

                level.TypeByteArray = Level_VALUE.TypeByteArray;

                level.Object = Level_VALUE.Object;

                level.Type = Level_VALUE.Type;

                level.Expressionxportable = expressionxportable;
                
                collectionResult.Add(level);

                continue;
            }

            return new List<ExpressionxportablereadXopq_stY>(collectionResult);
        }
    }
}
