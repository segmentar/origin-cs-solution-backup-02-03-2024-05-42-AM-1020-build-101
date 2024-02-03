using Core;

namespace Core
{
    using System;

    public partial class ExpressionxportableexecuteSeal
    {
        public ExpressionxportableexecuteUnit Export()
        {
            ExpressionxportableexecuteUnit portResult = default;

            ExpressionxportableexecuteUnit unit;

            unit = new ExpressionxportableexecuteUnit();

            unit.ExpressionExecute = ExpressionExecute;

            unit.ExpressionExecuteArray = ExpressionExecuteArray;

            unit.ExpressionExecuteExecuting = ExpressionExecuteExecuting;

            unit.Executearray = Executearray;

            unit.Instruction = Instruction;

            unit.InstructionArray = InstructionArray;

            unit.InstructionExecuting = InstructionExecuting;

            unit.SplitArray = SplitArray;

            unit.Value =  Value;

            unit.Lower = Lower;

            unit.Argument = Argument;

            unit.ParameterArray = ParameterArray;

            portResult = unit;

            return portResult;
        }
    }
}
