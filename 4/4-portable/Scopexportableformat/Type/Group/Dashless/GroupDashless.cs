using Core;

namespace Core
{
    using System;

    public partial class Scopexportableformat
    {
        public static String GroupDashless(String value_STRING)
        {
            String stringResult = default;

            var split = value_STRING.Split(ScopexportableradicalFormat.FormatCharacterArray, StringSplitOptions.RemoveEmptyEntries);

            var join = String.Join(((Char)Scopexportableascii.EntityUnderscore).ToString(), split);

            var result = join;

            stringResult = result;

            return stringResult;
        }
    }
}
