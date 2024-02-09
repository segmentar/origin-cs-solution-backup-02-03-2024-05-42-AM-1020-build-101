using Core;

namespace Core
{
    using System;

    public partial class ExpressionxportableexecuteSeal
    {
        public void Import(ExpressionxportableexecuteUnit Unit_VALUE)
        {
            ExpressionExecute = Unit_VALUE.ExpressionExecute;

            ExpressionExecuteArray = Unit_VALUE.ExpressionExecuteArray;

            ExpressionExecuteExecuting = Unit_VALUE.ExpressionExecuteExecuting;

            Executearray = Unit_VALUE.Executearray;

            Instruction = Unit_VALUE.Instruction;

            InstructionArray = Unit_VALUE.InstructionArray;

            InstructionExecuting = Unit_VALUE.InstructionExecuting;

            SplitArray = Unit_VALUE.SplitArray;

            Value = Unit_VALUE.Value;

            Lower = Unit_VALUE.Lower;

            Argument = Unit_VALUE.Argument;

            ParameterArray = Unit_VALUE.ParameterArray;

            return;
        }
    }
}
