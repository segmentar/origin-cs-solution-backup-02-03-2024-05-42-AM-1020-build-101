using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class ExpressionxportablewritebuildModule
    {
        public partial class XQuadruple
        {
            public static IList<ExpressionxportablewriteXopq_stY> FunctionLevelSet(ExpressionxportablewriteXop_rstY[] LeveL_ARRAY)
            {
                ICollection<ExpressionxportablewriteXopq_stY> collectionResult = default;

                collectionResult = new Collection<ExpressionxportablewriteXopq_stY>();

                foreach (ExpressionxportablewriteXop_rstY Level_VALUE in LeveL_ARRAY)
                {
                    var reflect = (Expressionxportablestringsafe)(Level_VALUE.Expressionxportable.StringIdentity as Object);
                    
                    ExpressionxportablewriteXopq_stY level;

                    level = new ExpressionxportablewriteXopq_stY();

                    level.Ordinal = Level_VALUE.Ordinal;

                    level.Layer = Level_VALUE.Layer;

                    level.Relate = Level_VALUE.Relate;

                    level.Identity = reflect.Value;

                    level.Type = Level_VALUE.Expressionxportable.Type;

                    level.Expressionxportable = Level_VALUE.Expressionxportable;

                    collectionResult.Add(level);

                    continue;
                }

                return new List<ExpressionxportablewriteXopq_stY>(collectionResult);
            }
        }
    }
}
