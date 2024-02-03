using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class ExpressionxportablewritebuildModule
    {
        public partial class XDouble
        {
            public static IList<ExpressionxportablewriteXo_qrstY> FunctionLevelSet(ExpressionxportablewriteX_pqrstY[] Level_ARRAY)
            {
                ICollection<ExpressionxportablewriteXo_qrstY> collectionResult = default;

                collectionResult = new Collection<ExpressionxportablewriteXo_qrstY>();

                foreach (ExpressionxportablewriteX_pqrstY Item_VALUE in Level_ARRAY)
                {
                    var layer = 1;

                    foreach (ExpressionxportablewriteX_pqrstY Entry_VALUE in Level_ARRAY)
                    {
                        var array = Expressionxportableset.ExpressionxportableAllSetSurface(Entry_VALUE.Expressionxportable, true);

                        foreach (Expressionxportable expressionxportable in array)
                        {
                            var list = Expressionxportablemagic.ExpressionxportablemagicArrayListCastDispenser(expressionxportable.LayerArrayListObject);

                            Boolean isEqualCheck, shouldContinueCheck;

                            isEqualCheck = list.Contains(Item_VALUE.Expressionxportable) is true;

                            shouldContinueCheck = isEqualCheck is false;

                            if (shouldContinueCheck is true)
                            {
                                continue;
                            }
                            else
                                "false".ToString();

                            layer = layer + 1;

                            break;
                        }

                        continue;
                    }

                    ExpressionxportablewriteXo_qrstY level;

                    level = new ExpressionxportablewriteXo_qrstY();

                    level.Ordinal = Item_VALUE.Ordinal;

                    level.Layer = layer;

                    level.Expressionxportable = Item_VALUE.Expressionxportable;

                    collectionResult.Add(level);

                    continue;
                }

                return new List<ExpressionxportablewriteXo_qrstY>(collectionResult);
            }
        }
    }
}
