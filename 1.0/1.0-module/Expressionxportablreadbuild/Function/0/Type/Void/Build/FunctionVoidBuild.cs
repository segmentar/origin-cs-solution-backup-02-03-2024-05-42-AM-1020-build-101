using Core;

namespace Core
{
    using System;

    public partial class ExpressionxportablereadbuildModule
    {
        public partial class XZeroth
        {
            public static void FunctionBuildVoid(ExpressionxportablereadXopq_stY[] Level_ARRAY)
            {
                foreach (ExpressionxportablereadXopq_stY Level_ITEM in Level_ARRAY)
                {
                    foreach (ExpressionxportablereadXopq_stY Level_ENTRY in Level_ARRAY)
                    {
                        Boolean isEqualCheck, shouldContinueCheck;

                        isEqualCheck = Object.Equals(Level_ITEM.Ordinal, Level_ENTRY.Relate) is true;

                        shouldContinueCheck = isEqualCheck is false;

                        if (shouldContinueCheck is true)
                        {
                            continue;
                        }
                        else
                            "false".ToString();

                        var list = Expressionxportablemagic.ExpressionxportablemagicArrayListCastDispenser(Level_ITEM.Expressionxportable.LayerArrayListObject);

                        list.Add(Level_ENTRY.Expressionxportable);

                        continue;
                    }

                    continue;
                }

                return;
            }
        }
    }
}
