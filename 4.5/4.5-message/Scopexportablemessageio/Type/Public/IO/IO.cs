using Core;

namespace Core
{
    using System;

    public partial class Scopexportablemessageio
    {
        public static void IO(String Message_VALUE)
        {
            var separator = new Char[1];

            separator[0] = (Char)Scopexportableascii.EntityWhitespace;

            var split = Message_VALUE.Split(separator, StringSplitOptions.RemoveEmptyEntries);

            var index = 0;

            foreach (String stringValue in split)
            {
                var value = Scopexportableformat.GroupDashless(stringValue);

                split[index] = value;

                index = index + 1;

                continue;
            }

            Group8101(split);

            Group8181(split);

            return;
        }
    }
}
