namespace Core
{
    using System;

    [Expressionxportableisc]
    public partial struct ExpressionxportablereadX_pqrstY
    {
        public Int32 Ordinal;

        public Int32 Layer;

        public Int32 Relate;

        public Int32 ObjectStartAddress;

        public Int32 ObjectEndAddress;

        public Int32 TypeStartAddress;

        public Int32 TypeEndAddress;

        public String Identity;

        [Expressionxportableism]
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] { 
            
                String.Empty + nameof(ExpressionxportablereadX_pqrstY) + ' ' + "::" + ' ' + '{',
                String.Empty + '.' + "level",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(Ordinal) + ':' + ' ' + Ordinal,
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(Layer) + ':' + ' ' + Layer,
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(Relate) + ':' + ' ' + Relate,
                String.Empty + '\t' + '~' + "04" + ' ' + nameof(ObjectStartAddress) + ':' + ' ' + ObjectStartAddress,
                String.Empty + '\t' + '~' + "05" + ' ' + nameof(ObjectEndAddress) + ':' + ' ' + ObjectEndAddress,
                String.Empty + '\t' + '~' + "06" + ' ' + nameof(TypeStartAddress) + ':' + ' ' + TypeStartAddress,
                String.Empty + '\t' + '~' + "07" + ' ' + nameof(TypeEndAddress) + ':' + ' ' + TypeEndAddress,
                String.Empty + '\t' + '~' + "08" + ' ' + nameof(Identity) + ':' + ' ' + Identity,
                String.Empty + '}'
            });
        }
    }
}

namespace Core
{
    using System;

    [Expressionxportableisc]
    public partial struct ExpressionxportablereadXo_qrstY
    {
        public Int32 Ordinal;

        public Int32 Layer;

        public Int32 Relate;

        public Int32 ObjectStartAddress;

        public Int32 ObjectEndAddress;

        public Int32 TypeStartAddress;

        public Int32 TypeEndAddress;

        public String Identity;

        public Byte[] ObjectByteArray;

        public Byte[] TypeByteArray;

        [Expressionxportableism]
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] {

                String.Empty + nameof(ExpressionxportablereadXo_qrstY) + ' ' + "::" + ' ' + '{',
                String.Empty + '.' + "level",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(Ordinal) + ':' + ' ' + Ordinal,
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(Layer) + ':' + ' ' + Layer,
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(Relate) + ':' + ' ' + Relate,
                String.Empty + '\t' + '~' + "04" + ' ' + nameof(ObjectStartAddress) + ':' + ' ' + ObjectStartAddress,
                String.Empty + '\t' + '~' + "05" + ' ' + nameof(ObjectEndAddress) + ':' + ' ' + ObjectEndAddress,
                String.Empty + '\t' + '~' + "06" + ' ' + nameof(TypeStartAddress) + ':' + ' ' + TypeStartAddress,
                String.Empty + '\t' + '~' + "07" + ' ' + nameof(TypeEndAddress) + ':' + ' ' + TypeEndAddress,
                String.Empty + '\t' + '~' + "08" + ' ' + nameof(Identity) + ':' + ' ' + Identity,
                String.Empty + '\t' + '~' + "09" + ' ' + nameof(ObjectByteArray) + ':' + ' ' + ". . ." + ' ' + $"<{ObjectByteArray.Length}>",
                String.Empty + '\t' + '~' + "10" + ' ' + nameof(TypeByteArray) + ':' + ' ' + ". . ." + ' ' + $"<{TypeByteArray.Length}>",
                String.Empty + '}',
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

namespace Core
{
    using System;

    [Expressionxportableisc]
    public partial struct ExpressionxportablereadXop_rstY
    {
        public Int32 Ordinal;

        public Int32 Layer;

        public Int32 Relate;

        public Int32 ObjectStartAddress;

        public Int32 ObjectEndAddress;

        public Int32 TypeStartAddress;

        public Int32 TypeEndAddress;

        public String Identity;

        public Byte[] ObjectByteArray;

        public Byte[] TypeByteArray;

        public Object Object;

        public Type Type;

        [Expressionxportableism]
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] {

                String.Empty + nameof(ExpressionxportablereadXop_rstY) + ' ' + "::" + ' ' + '{',
                String.Empty + '.' + "level",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(Ordinal) + ':' + ' ' + Ordinal,
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(Layer) + ':' + ' ' + Layer,
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(Relate) + ':' + ' ' + Relate,
                String.Empty + '\t' + '~' + "04" + ' ' + nameof(ObjectStartAddress) + ':' + ' ' + ObjectStartAddress,
                String.Empty + '\t' + '~' + "05" + ' ' + nameof(ObjectEndAddress) + ':' + ' ' + ObjectEndAddress,
                String.Empty + '\t' + '~' + "06" + ' ' + nameof(TypeStartAddress) + ':' + ' ' + TypeStartAddress,
                String.Empty + '\t' + '~' + "07" + ' ' + nameof(TypeEndAddress) + ':' + ' ' + TypeEndAddress,
                String.Empty + '\t' + '~' + "08" + ' ' + nameof(Identity) + ':' + ' ' + Identity,
                String.Empty + '\t' + '~' + "09" + ' ' + nameof(ObjectByteArray) + ':' + ' ' + ". . ." + ' ' + $"<{ObjectByteArray.Length}>",
                String.Empty + '\t' + '~' + "10" + ' ' + nameof(TypeByteArray) + ':' + ' ' + ". . ." + ' ' + $"<{TypeByteArray.Length}>",
                String.Empty + '\t' + '~' + "11" + ' ' + nameof(Object) + ':' + ' ' + ". . .",
                String.Empty + '\t' + '~' + "12" + ' ' + nameof(Type) + ':' + ' ' + ". . .",
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(ObjectByteArray) + ':',
                String.Empty + String.Join('\n'.ToString(), ObjectByteArray),
                String.Empty,
                String.Empty + '~' + "20" + ' ' + nameof(TypeByteArray) + ':',
                String.Empty + String.Join('\n'.ToString(), TypeByteArray),
                String.Empty,
                String.Empty + '~' + "30" + ' ' + nameof(Object) + ':',
                String.Empty + Object,
                String.Empty,
                String.Empty + '~' + "40" + ' ' + nameof(Type) + ':',
                String.Empty + Type
            });
        }
    }
}

namespace Core
{
    using System;

    [Expressionxportableisc]
    public partial struct ExpressionxportablereadXopq_stY
    {
        public Int32 Ordinal;

        public Int32 Layer;

        public Int32 Relate;

        public Int32 ObjectStartAddress;

        public Int32 ObjectEndAddress;

        public Int32 TypeStartAddress;

        public Int32 TypeEndAddress;

        public String Identity;

        public Byte[] ObjectByteArray;

        public Byte[] TypeByteArray;

        public Object Object;

        public Type Type;

        public Expressionxportable Expressionxportable;

        [Expressionxportableism]
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] {

                String.Empty + nameof(ExpressionxportablereadXopq_stY) + ' ' + "::" + ' ' + '{',
                String.Empty + '.' + "level",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(Ordinal) + ':' + ' ' + Ordinal,
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(Layer) + ':' + ' ' + Layer,
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(Relate) + ':' + ' ' + Relate,
                String.Empty + '\t' + '~' + "04" + ' ' + nameof(ObjectStartAddress) + ':' + ' ' + ObjectStartAddress,
                String.Empty + '\t' + '~' + "05" + ' ' + nameof(ObjectEndAddress) + ':' + ' ' + ObjectEndAddress,
                String.Empty + '\t' + '~' + "06" + ' ' + nameof(TypeStartAddress) + ':' + ' ' + TypeStartAddress,
                String.Empty + '\t' + '~' + "07" + ' ' + nameof(TypeEndAddress) + ':' + ' ' + TypeEndAddress,
                String.Empty + '\t' + '~' + "08" + ' ' + nameof(Identity) + ':' + ' ' + Identity,
                String.Empty + '\t' + '~' + "09" + ' ' + nameof(ObjectByteArray) + ':' + ' ' + ". . ." + ' ' + $"<{ObjectByteArray.Length}>",
                String.Empty + '\t' + '~' + "10" + ' ' + nameof(TypeByteArray) + ':' + ' ' + ". . ." + ' ' + $"<{TypeByteArray.Length}>",
                String.Empty + '\t' + '~' + "11" + ' ' + nameof(Object) + ':' + ' ' + ". . .",
                String.Empty + '\t' + '~' + "12" + ' ' + nameof(Type) + ':' + ' ' + ". . .",
                String.Empty + '\t' + '~' + "13" + ' ' + nameof(Expressionxportable) + ':' + ' ' + ". . .",
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(ObjectByteArray) + ':',
                String.Empty + String.Join('\n'.ToString(), ObjectByteArray),
                String.Empty,
                String.Empty + '~' + "20" + ' ' + nameof(TypeByteArray) + ':',
                String.Empty + String.Join('\n'.ToString(), TypeByteArray),
                String.Empty,
                String.Empty + '~' + "30" + ' ' + nameof(Object) + ':',
                String.Empty + Object,
                String.Empty,
                String.Empty + '~' + "40" + ' ' + nameof(Type) + ':',
                String.Empty + Type,
                String.Empty,
                String.Empty + '~' + "50" + ' ' + nameof(Expressionxportable) + ':',
                String.Empty + Expressionxportable
            });
        }
    }
}