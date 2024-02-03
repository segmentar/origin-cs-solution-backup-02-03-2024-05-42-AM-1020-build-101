using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class ExpressionxportablewritebuildModule
    {
        public partial class XSeptuple
        {
            public static IList<ExpressionxportablewriteU_pqrstV> FunctionLevelSet(ExpressionxportablewriteXopqrs_Y[] Level_ARRAY)
            {
                ICollection<ExpressionxportablewriteU_pqrstV> collectionResult = default;

                collectionResult = new Collection<ExpressionxportablewriteU_pqrstV>();

                foreach (ExpressionxportablewriteXopqrs_Y Level_VALUE in Level_ARRAY)
                {
                    ExpressionxportablewriteU_pqrstV level;

                    level = new ExpressionxportablewriteU_pqrstV();

                    level.Ordinal = Level_VALUE.Ordinal;

                    level.Layer = Level_VALUE.Layer;

                    level.Relate = Level_VALUE.Relate;

                    level.Identity = Level_VALUE.Identity;

                    level.Type = Level_VALUE.Type;

                    level.ObjectByteArray = Level_VALUE.ObjectByteArray;

                    level.TypeByteArray = Level_VALUE.TypeByteArray;

                    level.ObjectStartAddress = Level_VALUE.ObjectStartAddress;

                    level.ObjectEndAddress = Level_VALUE.ObjectEndAddress;

                    level.TypeStartAddress = Level_VALUE.TypeStartAddress;

                    level.TypeEndAddress = Level_VALUE.TypeEndAddress;

                    collectionResult.Add(level);

                    continue;
                }

                return new List<ExpressionxportablewriteU_pqrstV>(collectionResult);
            }
        }
    }
}
