using Core;

namespace Core
{
    using System;

    [Expressionxportableisc]
    public partial struct ExpressionxportablewriteX_pqrstY
    {
        public Int32 Ordinal;

        public Expressionxportable Expressionxportable;

        [Expressionxportableisc]
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] {

                String.Empty + nameof(ExpressionxportablewriteX_pqrstY) + ' ' + "::" + ' ' + '{',
                String.Empty + '.' + "level",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(Ordinal) + ':' + ' ' + Ordinal,
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(Expressionxportable) + ':' + ' ' + ". . .",
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(Expressionxportable) + ':',
                String.Empty + Expressionxportable
            });
        }
    }
}

namespace Core
{
    using System;

    [Expressionxportableisc]
    public partial struct ExpressionxportablewriteXo_qrstY
    {
        public Int32 Ordinal;

        public Int32 Layer;

        public Expressionxportable Expressionxportable;

        [Expressionxportableisc]
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] {

                String.Empty + nameof(ExpressionxportablewriteXo_qrstY) + ' ' + "::" + ' ' + '{',
                String.Empty + '.' + "level",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(Ordinal) + ':' + ' ' + Ordinal,
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(Layer) + ':' + ' ' + Layer,
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(Expressionxportable) + ':' + ' ' + ". . .",
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(Expressionxportable) + ':',
                String.Empty + Expressionxportable
            });
        }
    }
}

namespace Core
{
    using System;

    [Expressionxportableisc]
    public partial struct ExpressionxportablewriteXop_rstY
    {
        public Int32 Ordinal;

        public Int32 Layer;

        public Int32 Relate;

        public Expressionxportable Expressionxportable;

        [Expressionxportableisc]
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] {

                String.Empty + nameof(ExpressionxportablewriteXop_rstY) + ' ' + "::" + ' ' + '{',
                String.Empty + '.' + "level",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(Ordinal) + ':' + ' ' + Ordinal,
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(Layer) + ':' + ' ' + Layer,
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(Relate) + ':' + ' ' + Relate,
                String.Empty + '\t' + '~' + "04" + ' ' + nameof(Expressionxportable) + ':' + ' ' + ". . .",
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(Expressionxportable) + ':',
                String.Empty + Expressionxportable
            });
        }
    }
}

namespace Core
{
    using System;

    [Expressionxportableisc]
    public partial struct ExpressionxportablewriteXopq_stY
    {
        public Int32 Ordinal;

        public Int32 Layer;

        public Int32 Relate;

        public String Identity;

        public Type Type;

        public Expressionxportable Expressionxportable;

        [Expressionxportableisc]
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] {

                String.Empty + nameof(ExpressionxportablewriteXopq_stY) + ' ' + "::" + ' ' + '{',
                String.Empty + '.' + "level",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(Ordinal) + ':' + ' ' + Ordinal,
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(Layer) + ':' + ' ' + Layer,
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(Relate) + ':' + ' ' + Relate,
                String.Empty + '\t' + '~' + "04" + ' ' + nameof(Identity) + ':' + ' ' + Identity,
                String.Empty + '\t' + '~' + "05" + ' ' + nameof(Type) + ':' + ' ' + ". . .",
                String.Empty + '\t' + '~' + "06" + ' ' + nameof(Expressionxportable) + ':' + ' ' + ". . .",
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(Type) + ':',
                String.Empty + Type,
                String.Empty,
                String.Empty + '~' + "20" + ' ' + nameof(Expressionxportable) + ':',
                String.Empty + Expressionxportable
            });
        }
    }
}

namespace Core
{
    using System;

    [Expressionxportableisc]
    public partial struct ExpressionxportablewriteXopqr_tY
    {
        public Int32 Ordinal;

        public Int32 Layer;

        public Int32 Relate;

        public String Identity;

        public Type Type;

        public Byte[] ObjectByteArray;

        public Byte[] TypeByteArray;

        public Expressionxportable Expressionxportable;

        [Expressionxportableisc]
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] {

                String.Empty + nameof(ExpressionxportablewriteXopqr_tY) + ' ' + "::" + ' ' + '{',
                String.Empty + '.' + "level",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(Ordinal) + ':' + ' ' + Ordinal,
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(Layer) + ':' + ' ' + Layer,
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(Relate) + ':' + ' ' + Relate,
                String.Empty + '\t' + '~' + "04" + ' ' + nameof(Identity) + ':' + ' ' + Identity,
                String.Empty + '\t' + '~' + "05" + ' ' + nameof(Type) + ':' + ' ' + ". . .",
                String.Empty + '\t' + '~' + "06" + ' ' + nameof(ObjectByteArray) + ':' + ' ' + ". . ." + ' ' + $"<{ObjectByteArray.Length}>",
                String.Empty + '\t' + '~' + "07" + ' ' + nameof(TypeByteArray) + ':' + ' ' + ". . ." + ' ' + $"<{TypeByteArray.Length}>",
                String.Empty + '\t' + '~' + "08" + ' ' + nameof(Expressionxportable) + ':' + ' ' + ". . .",
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(Type) + ':',
                String.Empty + Type,
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(ObjectByteArray) + ':',
                String.Empty + String.Join('\n'.ToString(), ObjectByteArray),
                String.Empty,
                String.Empty + '~' + "20" + ' ' + nameof(TypeByteArray) + ':',
                String.Empty + String.Join('\n'.ToString(), TypeByteArray),
                String.Empty,
                String.Empty + '~' + "30" + ' ' + nameof(Expressionxportable) + ':',
                String.Empty + Expressionxportable,
            });
        }
    }
}

namespace Core
{
    using System;

    [Expressionxportableisc]
    public partial struct ExpressionxportablewriteXopqrs_Y
    {
        public Int32 Ordinal;

        public Int32 Layer;

        public Int32 Relate;

        public String Identity;

        public Type Type;

        public Byte[] ObjectByteArray;

        public Byte[] TypeByteArray;

        public Int32 ObjectStartAddress;

        public Int32 ObjectEndAddress;

        public Int32 TypeStartAddress;

        public Int32 TypeEndAddress;

        public Expressionxportable Expressionxportable;

        [Expressionxportableisc]
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] {

                String.Empty + nameof(ExpressionxportablewriteXopqrs_Y) + ' ' + "::" + ' ' + '{',
                String.Empty + '.' + "level",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(Ordinal) + ':' + ' ' + Ordinal,
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(Layer) + ':' + ' ' + Layer,
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(Relate) + ':' + ' ' + Relate,
                String.Empty + '\t' + '~' + "04" + ' ' + nameof(Identity) + ':' + ' ' + Identity,
                String.Empty + '\t' + '~' + "05" + ' ' + nameof(Type) + ':' + ' ' + ". . .",
                String.Empty + '\t' + '~' + "06" + ' ' + nameof(ObjectByteArray) + ':' + ' ' + ". . ." + ' ' + $"<{ObjectByteArray.Length}>",
                String.Empty + '\t' + '~' + "07" + ' ' + nameof(TypeByteArray) + ':' + ' ' + ". . ." + ' ' + $"<{TypeByteArray.Length}>",
                String.Empty + '\t' + '~' + "08" + ' ' + nameof(ObjectStartAddress) + ':' + ' ' + ObjectStartAddress,
                String.Empty + '\t' + '~' + "09" + ' ' + nameof(ObjectEndAddress) + ':' + ' ' + ObjectEndAddress,
                String.Empty + '\t' + '~' + "10" + ' ' + nameof(TypeStartAddress) + ':' + ' ' + TypeStartAddress,
                String.Empty + '\t' + '~' + "11" + ' ' + nameof(TypeEndAddress) + ':' + ' ' + TypeEndAddress,
                String.Empty + '\t' + '~' + "12" + ' ' + nameof(Expressionxportable) + ':' + ' ' + ". . .",
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + nameof(Type) + ':',
                String.Empty + Type,
                String.Empty,
                String.Empty + '~' + "20" + ' ' + nameof(ObjectByteArray) + ':',
                String.Empty + String.Join('\n'.ToString(), ObjectByteArray),
                String.Empty,
                String.Empty + '~' + "30" + ' ' + nameof(TypeByteArray) + ':',
                String.Empty + String.Join('\n'.ToString(), TypeByteArray),
                String.Empty,
                String.Empty + '~' + "40" + ' ' + nameof(Expressionxportable) + ':',
                String.Empty + Expressionxportable,
            });
        }
    }
}

namespace Core
{
    using System;

    [Expressionxportableisc]
    public partial struct ExpressionxportablewriteU_pqrstV
    {
        public Int32 Ordinal;

        public Int32 Layer;

        public Int32 Relate;

        public String Identity;

        public Type Type;

        public Byte[] ObjectByteArray;

        public Byte[] TypeByteArray;

        public Int32 ObjectStartAddress;

        public Int32 ObjectEndAddress;

        public Int32 TypeStartAddress;

        public Int32 TypeEndAddress;

        [Expressionxportableisc]
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] {

                String.Empty + nameof(ExpressionxportablewriteU_pqrstV) + ' ' + "::" + ' ' + '{',
                String.Empty + '.' + "level",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(Ordinal) + ':' + ' ' + Ordinal,
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(Layer) + ':' + ' ' + Layer,
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(Relate) + ':' + ' ' + Relate,
                String.Empty + '\t' + '~' + "04" + ' ' + nameof(Identity) + ':' + ' ' + Identity,
                String.Empty + '\t' + '~' + "05" + ' ' + nameof(Type) + ':' + ' ' + ". . .",
                String.Empty + '\t' + '~' + "06" + ' ' + nameof(ObjectByteArray) + ':' + ' ' + ". . ." + ' ' + $"<{ObjectByteArray.Length}>",
                String.Empty + '\t' + '~' + "07" + ' ' + nameof(TypeByteArray) + ':' + ' ' + ". . ." + ' ' + $"<{TypeByteArray.Length}>",
                String.Empty + '\t' + '~' + "08" + ' ' + nameof(ObjectStartAddress) + ':' + ' ' + ObjectStartAddress,
                String.Empty + '\t' + '~' + "09" + ' ' + nameof(ObjectEndAddress) + ':' + ' ' + ObjectEndAddress,
                String.Empty + '\t' + '~' + "10" + ' ' + nameof(TypeStartAddress) + ':' + ' ' + TypeStartAddress,
                String.Empty + '\t' + '~' + "11" + ' ' + nameof(TypeEndAddress) + ':' + ' ' + TypeEndAddress,
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(Type) + ':',
                String.Empty + Type,
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(ObjectByteArray) + ':',
                String.Empty + String.Join('\n'.ToString(), ObjectByteArray),
                String.Empty,
                String.Empty + '~' + "20" + ' ' + nameof(TypeByteArray) + ':',
                String.Empty + String.Join('\n'.ToString(), TypeByteArray)
            });
        }
    }
}