using Core;

namespace Core
{
    using System;

    using System.IO;
    using System.IO.Pipes;

    public partial class ScopexportableasyncMessageout
    {
        public static void GroupTarget(Scopexportablemessageoutasync value_SCOPEXPORTABLEMESSAGEOUTASYNC)
        {
            NamedPipeClientStream namedPipeClientStream;

            namedPipeClientStream = new NamedPipeClientStream(Scopexportablename.EntityPipe);

            namedPipeClientStream.Connect();

            StreamWriter streamWriter;

            streamWriter = new StreamWriter(namedPipeClientStream);

            streamWriter.Write(value_SCOPEXPORTABLEMESSAGEOUTASYNC.Message);

            streamWriter.Flush();

            streamWriter.Close();

            streamWriter.Dispose();            

            return;
        }
    }
}
