using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class ExpressionxportablereadbuildModule
    {
        public partial class XTriple
        {
            public static IList<ExpressionxportablereadXop_rstY> FunctionLevelSet(ExpressionxportablereadXo_qrstY[] Level_ARRAY)
            {
                ICollection<ExpressionxportablereadXop_rstY> collectionResult = default;

                collectionResult = new List<ExpressionxportablereadXop_rstY>();

                foreach (ExpressionxportablereadXo_qrstY Level_VALUE in Level_ARRAY)
                {
                    var inflect = new Object[2];

                    inflect[0] = Expressionxportableremoteout.RemoteType(Level_VALUE.TypeByteArray);

                    inflect[1] = Expressionxportableremoteout.Remote(Level_VALUE.ObjectByteArray, (Type)inflect[0]);

                    ExpressionxportablereadXop_rstY level;

                    level = new ExpressionxportablereadXop_rstY();

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

                    level.Object = (Object)inflect[1];

                    level.Type = (Type)inflect[0];

                    collectionResult.Add(level);

                    continue;
                }

                return new List<ExpressionxportablereadXop_rstY>(collectionResult);
            }
        }
    }
}
