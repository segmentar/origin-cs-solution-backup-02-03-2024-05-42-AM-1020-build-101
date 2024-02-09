using Core;

namespace Core
{
    using System;

    public partial class ScopexportablesealExtract
    {
        public static Boolean ForgeAdd()
        {
            Boolean booleanResult = default;

            var list = Scopexportablemagic.ScopexportablemagicArrayListCastDispenser(Desorb[1]);

            var add = true;

            add = add && ValidIs is true;

            foreach (Scopexportableformcoordinate scopexportableform in list)
            {
                Boolean isEqualCheck, shouldContinueCheck;

                isEqualCheck = Object.Equals(scopexportableform.End, ScopexportableformValue.End) is true;

                shouldContinueCheck = isEqualCheck is false;

                if (shouldContinueCheck is true)
                {
                    continue;
                }
                else
                    "false".ToString();

                add = add && false;

                break;
            }

            if (add is true)
            {
                booleanResult = true;
            }
            else
                "false".ToString();

            return booleanResult;
        }
    }
}
