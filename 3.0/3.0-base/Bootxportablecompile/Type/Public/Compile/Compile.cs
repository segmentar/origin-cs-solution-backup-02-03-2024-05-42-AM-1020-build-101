using Core;

namespace Core
{
    using System;

    public partial class Bootxportablecompile
    {
        public static Object[] Compile(Boolean answer_SERVER_should)
        {
            Object[] arrayResult = default;

            if (answer_SERVER_should is true)
            {
                Scopexportablemessagein.Message();
            }
            else
                "false".ToString();

            BootxportablebuildModule bootxportablebuildModule = BootxportablebuildModule.Action();

            var inflect = new Object[1];

            inflect[0] = bootxportablebuildModule;

            var result = inflect;

            arrayResult = result;

            return arrayResult;
        }
    }
}
