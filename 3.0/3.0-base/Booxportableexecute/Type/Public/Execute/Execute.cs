using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Bootxportableexecute
    {
        public static void Execute()
        {
            Scopexportablemessagein.Message();

            while (true)
            {
                Boolean isEqualCheck, shouldBreakCheck;

                isEqualCheck = Scopexportablemessageloop.Running() is true;

                shouldBreakCheck = isEqualCheck is true;

                if (shouldBreakCheck is true)
                {
                    break;
                }
                else
                    "false".ToString();

                continue;
            }

            var value = Bootxportablefolder.Folder(true);

            foreach (FileInfo fileInfo in Bootxportableio.BootxportableioFileSetSurface(value, true))
            {
                var result = File.ReadAllText(fileInfo.FullName);

                Expressionxportable expressionxportable;

                expressionxportable = Expressionxportableapi.Root();

                Expressionxportableapi.ScheduleText(expressionxportable, result);

                Expressionxportableapi.ReloadInExpressionFull(expressionxportable, Path.GetRandomFileName());

                continue;
            }

            return;
        }
    }
}
