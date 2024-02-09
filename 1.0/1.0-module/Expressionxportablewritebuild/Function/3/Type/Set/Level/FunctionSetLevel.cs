using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class ExpressionxportablewritebuildModule
    {
        public partial class XTriple
        {
            public static IList<ExpressionxportablewriteXop_rstY> FunctionLevelSet(ExpressionxportablewriteXo_qrstY[] Level_ARRAY, Expressionxportable[] array_EXPRESSIONXPORTABLE)
            {
                ICollection<ExpressionxportablewriteXop_rstY> collectionResult = default;

                collectionResult = new List<ExpressionxportablewriteXop_rstY>();

                foreach (ExpressionxportablewriteXo_qrstY Level_ITEM in Level_ARRAY)
                {
                    var relate = 0;

                    foreach (ExpressionxportablewriteXo_qrstY Level_ENTRY in Level_ARRAY)
                    {
                        var list = Expressionxportablemagic.ExpressionxportablemagicArrayListCastDispenser(Level_ENTRY.Expressionxportable.LayerArrayListObject);

                        Boolean isEqualCheck, shouldContinueCheck;

                        isEqualCheck = list.Contains(Level_ITEM.Expressionxportable) is true;

                        shouldContinueCheck = isEqualCheck is false;

                        if (shouldContinueCheck is true)
                        {
                            continue;
                        }
                        else
                            "false".ToString();

                        relate = Level_ENTRY.Ordinal;

                        break;
                    }

                    ExpressionxportablewriteXop_rstY level;

                    level = new ExpressionxportablewriteXop_rstY();

                    level.Ordinal = Level_ITEM.Ordinal;

                    level.Layer = Level_ITEM.Layer;

                    level.Relate = relate;

                    level.Expressionxportable = Level_ITEM.Expressionxportable;

                    collectionResult.Add(level);

                    continue;
                }

                return new List<ExpressionxportablewriteXop_rstY>(collectionResult);
            }
        }
    }
}
