using Core;

namespace Core
{
    using System;

    public partial class Materialxportableargument
    {
        public static Object[] MaterialxportableargumentArgumentSetSurface(Materialxportable materialxportable)
        {
            Object[] arrayResult = default;

            var list = MaterialxportableargumentArgumentSet(materialxportable);

            var array = new Object[list.Count];

            list.CopyTo(array, MaterialxportablePolicy.MaterialxportableIndexPolicy);

            arrayResult = array;   

            return arrayResult;
        }
    }
}
