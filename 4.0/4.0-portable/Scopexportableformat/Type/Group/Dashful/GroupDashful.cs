using Core;

namespace Core
{
    using System;

    public partial class Scopexportableformat
    {
        public static String GroupDashful(String value_STRING)
        {
            String stringResult = default;

            var split = value_STRING.Split(ScopexportableradicalFormat.FormatCharacterArray, StringSplitOptions.RemoveEmptyEntries);

            var join = String.Join(((Char)Scopexportableascii.EntityDash).ToString(), split);

            var result = join;

            stringResult = result;

            return stringResult;
        }
    }
}
