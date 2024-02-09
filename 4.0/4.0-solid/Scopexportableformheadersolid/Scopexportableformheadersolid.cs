namespace Core
{
    using System;

    public partial struct Scopexportableformheadersolid
    {
        public Object Object;

        public Int32 Mid;

        public Scopexportablestringsafe Header;

        public Scopexportablestringarraysafe HeaderArray;

        public Scopexportablecharactersafe SummerLeft;

        public Scopexportablecharactersafe SummerRight;

        public Scopexportablecharactersafe AutumnLeft;

        public Scopexportablecharactersafe AutumnRight;

        public Scopexportablecharactersafe SpringLeft;

        public Scopexportablecharactersafe SpringRight;

        public Scopexportablecharactersafe WinterLeft;

        public Scopexportablecharactersafe WinterRight;

        public Scopexportablecharacterarraysafe Escape;

        public Scopexportablestringsafe Extension;


        [Scopexportableism]
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] {

                String.Empty + nameof(Scopexportableformheadersolid) + ' ' + "::" + ' ' + '{',
                String.Empty + '.' + "solid",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(Object) + ':' + ' ' + ". . .",
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(Mid) + ':' + ' ' + Mid,
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(Header) + ':' + ' ' + "<hidden>",
                String.Empty + '\t' + '~' + "04" + ' ' + nameof(Header) + ':' + ' ' + Header.ValueSafe,
                String.Empty + '\t' + '~' + "05" + ' ' + nameof(HeaderArray) + ':' + ' ' + ". . ." + ' ' + $"<{HeaderArray.Value.Length}>",
                String.Empty + '\t' + '~' + "06" + ' ' + nameof(SummerLeft) + ':' + ' ' + "<hidden>",
                String.Empty + '\t' + '~' + "07" + ' ' + nameof(SummerLeft) + ':' + ' ' + SummerLeft.ValueSafe,
                String.Empty + '\t' + '~' + "08" + ' ' + nameof(SummerRight) + ':' + ' ' + "<hidden>",
                String.Empty + '\t' + '~' + "09" + ' ' + nameof(SummerRight) + ':' + ' ' + SummerRight.ValueSafe,
                String.Empty + '\t' + '~' + "10" + ' ' + nameof(AutumnLeft) + ':' + ' ' + "<hidden>",
                String.Empty + '\t' + '~' + "11" + ' ' + nameof(AutumnLeft) + ':' + ' ' + AutumnLeft.ValueSafe,
                String.Empty + '\t' + '~' + "12" + ' ' + nameof(AutumnRight) + ':' + ' ' + "<hidden>",
                String.Empty + '\t' + '~' + "13" + ' ' + nameof(AutumnRight) + ':' + ' ' + AutumnRight.ValueSafe,
                String.Empty + '\t' + '~' + "14" + ' ' + nameof(SpringLeft) + ':' + ' ' + "<hidden>",
                String.Empty + '\t' + '~' + "15" + ' ' + nameof(SpringLeft) + ':' + ' ' + SpringLeft.ValueSafe,
                String.Empty + '\t' + '~' + "16" + ' ' + nameof(SpringRight) + ':' + ' ' + "<hidden>",
                String.Empty + '\t' + '~' + "17" + ' ' + nameof(SpringRight) + ':' + ' ' + SpringRight.ValueSafe,
                String.Empty + '\t' + '~' + "18" + ' ' + nameof(WinterLeft) + ':' + ' ' + "<hidden>",
                String.Empty + '\t' + '~' + "19" + ' ' + nameof(WinterLeft) + ':' + ' ' + WinterLeft.ValueSafe,
                String.Empty + '\t' + '~' + "20" + ' ' + nameof(WinterRight) + ':' + ' ' + "<hidden>",
                String.Empty + '\t' + '~' + "21" + ' ' + nameof(WinterRight) + ':' + ' ' + WinterRight.ValueSafe,
                String.Empty + '\t' + '~' + "22" + ' ' + nameof(Escape) + ':' + ' ' + ". . ." + ' ' + $"<{Escape.Value.Length}>",
                String.Empty + '\t' + '~' + "23" + ' ' + nameof(Extension) + ':' + ' ' + "<hidden>",
                String.Empty + '\t' + '~' + "24" + ' ' + nameof(Extension) + ':' + ' ' + Extension.ValueSafe,
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(Object) + ':',
                String.Empty + Object,
                String.Empty,
                String.Empty + '~' + "40" + ' ' + nameof(HeaderArray) + ':',
                String.Empty + $"<safe><<{String.Join('\n'.ToString(), HeaderArray.ValueSafe)}>>",
                String.Empty,
                String.Empty + '~' + "50" + ' ' + nameof(Escape) + ':',
                String.Empty + $"<safe><<{String.Join('\n'.ToString(), Escape.ValueSafe)}>>"
            });
        }
    }
}