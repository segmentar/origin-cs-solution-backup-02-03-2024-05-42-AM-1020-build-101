using Core;

namespace Core
{
    using System;

    public partial class ExpressionxportablemoduleSeal
    {
        public ExpressionxportablemoduleUnit Export()
        {
            ExpressionxportablemoduleUnit unitResult = default;

            ExpressionxportablemoduleUnit unit;

            unit = new ExpressionxportablemoduleUnit();

            unit.ModuleArray = ModuleArray;

            unit.DirectoryInfoArray = DirectoryInfoArray;

            unit.FileInfoArray = FileInfoArray;

            unitResult = unit;

            return unitResult;
        }
    }
}
