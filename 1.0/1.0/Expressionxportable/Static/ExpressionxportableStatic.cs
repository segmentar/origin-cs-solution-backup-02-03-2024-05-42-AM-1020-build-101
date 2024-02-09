using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Expressionxportable
    {
        static Expressionxportable()
        {
            return;
        }

        public static void Procedure()
        {
            ExpressionxportablePolicy.ExpressionxportableDebugPolicy = true;

            ExpressionxportablePolicy.ExpressionxportableInfoPolicy = true;

            return;
        }

        public static void Manual()
        {
            Expressionxportableconfigure.Import(Expressionxportableconfigure.Data());

            if (File.Exists(@"C:\Users\todor\OneDrive\Desktop\Isolated\program-boot\bin\Debug\Expression\System.expression1999") is false)
            {
                var result = ExpressionxportableRootVariation();

                Expressionxportablesave.GroupSaveToExpressionSystemFull(result);
            }
            else
                "false".ToString();

            return;
        }

        public static void Raise()
        {
            if (ExpressionxportablePolicy.ExpressionxportableInfoPolicy is true)
            {
                Expressionxportablerender.Render($"{ExpressionxportableCode.RenderPath.Core_Expressionxportable_Info}-{nameof(Expressionxportable)}Info", Expressionxportablemagic.ExpressionxportablemagicArrayListCastDispenser(ExpressionxportablePolicy.ExpressionxportableArrayListObject).ToArray());
            }
            else
                "false".ToString();

            return;
        }

        public static void Bundle()
        {
            Procedure();

            Manual();

            Raise();

            return;
        }
    }
}
