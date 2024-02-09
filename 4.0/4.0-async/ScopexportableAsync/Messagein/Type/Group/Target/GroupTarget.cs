using Core;

namespace Core
{
    using System;

    using System.IO;
    using System.IO.Pipes;

    public partial class ScopexportableasyncMessagein
    {
        public static void GroupTarget()
        {
            NamedPipeServerStream namedPipeServerStream;

            namedPipeServerStream = new NamedPipeServerStream(Scopexportablestorepipe.EntityPipe);

            Scopexportablemessageloop.Switch();

            while (true)
            {
                Boolean isEqualCheck, shouldBreakCheck;

                isEqualCheck = Scopexportablemessageloop.MessageLoopShould is true;

                shouldBreakCheck = isEqualCheck is false;

                if (shouldBreakCheck is true)
                {
                    break;
                }
                else
                    "false".ToString();

                namedPipeServerStream.WaitForConnection();

                StreamReader streamReader;

                streamReader = new StreamReader(namedPipeServerStream);

                var result = streamReader.ReadToEnd();

                Scopexportablemessageio.IO(result);

                namedPipeServerStream.Disconnect();

                continue;
            }

            using (namedPipeServerStream)
            {
                namedPipeServerStream.Close();

                namedPipeServerStream.Dispose();
            }

            return;
        }
    }
}
