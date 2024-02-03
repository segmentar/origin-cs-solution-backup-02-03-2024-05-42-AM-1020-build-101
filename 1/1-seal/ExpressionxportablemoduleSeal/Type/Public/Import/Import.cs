using Core;

namespace Core
{
    using System;

    public partial class ExpressionxportablemoduleSeal
    {
        public void Import(ExpressionxportablemoduleUnit Unit_VALUE)
        {
            ModuleArray = ModuleArray = Unit_VALUE.ModuleArray;

            DirectoryInfoArray = Unit_VALUE.DirectoryInfoArray;

            FileInfoArray = Unit_VALUE.FileInfoArray;

            return;
        }
    }
}
