using Core;

namespace Core
{
    using System;

    public partial class Bootxportableapi
    {
        public static Object[] Compile(Boolean server)
        {
            Object[] arrayResult = default;

            arrayResult = Bootxportablecompile.Compile(server);

            return arrayResult;
        }
    }
}
