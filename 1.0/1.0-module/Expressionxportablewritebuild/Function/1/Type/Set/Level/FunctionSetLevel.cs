using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class ExpressionxportablewritebuildModule
    {
        public partial class XSingle
        {
            public static IList<ExpressionxportablewriteX_pqrstY> FunctionLevelSet(Expressionxportable[] array_EXPRESSIONXPORTABLE)
            {
                ICollection<ExpressionxportablewriteX_pqrstY> collectionResult = default;

                collectionResult = new List<ExpressionxportablewriteX_pqrstY>();

                var ordinal = 1;

                foreach (Expressionxportable value_EXPRESSIONXPORTABLE in array_EXPRESSIONXPORTABLE)
                {
                    ExpressionxportablewriteX_pqrstY level;

                    level = new ExpressionxportablewriteX_pqrstY();

                    level.Ordinal = ordinal;

                    level.Expressionxportable = value_EXPRESSIONXPORTABLE;

                    collectionResult.Add(level);

                    ordinal = ordinal + 1;

                    continue;
                }

                return new List<ExpressionxportablewriteX_pqrstY>(collectionResult);
            }
        }
    }
}
