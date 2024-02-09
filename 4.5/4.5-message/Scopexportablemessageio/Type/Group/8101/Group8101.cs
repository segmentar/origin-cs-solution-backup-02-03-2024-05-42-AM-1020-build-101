using Core;

namespace Core
{
    using System;

    public partial class Scopexportablemessageio
    {
        public static void Group8101(String[] array_STRING)
        {           
            foreach (String item_STRING in array_STRING)
            {
                foreach (String stringEntry in Scopexportablestoremessage.Entity8101)
                {
                    Boolean isEqualCheck, shouldContinueCheck;

                    isEqualCheck = Object.Equals(item_STRING, stringEntry) is true;

                    shouldContinueCheck = isEqualCheck is false;

                    if (shouldContinueCheck is true)
                    {
                        continue;
                    }
                    else
                        "false".ToString();

                    Scopexportableform.Form(true);

                    continue;
                }
            }

            return;
        }
    }
}
