using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial struct ScopexportablelevelHierarchyX_pqrstY
    {
        public Object Object;

        public DirectoryInfo DirectoryInfo;

        public FileInfo FileInfo;

        public Scopexportablestringsafe Text;

        public Int32 Start;

        public Int32 End;

        [Scopexportableism]
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] {

                String.Empty + nameof(ScopexportablelevelHierarchyX_pqrstY) + ' ' + "::" + ' ' + '{',
                String.Empty + '.' + "level",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(Object) + ':' + ' ' + ". . .",
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(DirectoryInfo) + ':' + ' ' + ". . .",
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(FileInfo) + ':' + ' ' + ". . .",
                String.Empty + '\t' + '~' + "04" + ' ' + nameof(Text) + ':' + ' ' + "<hidden>",
                String.Empty + '\t' + '~' + "05" + ' ' + nameof(Text) + ':' + ' ' + Text.ValueSafe,
                String.Empty + '\t' + '~' + "06" + ' ' + nameof(Start) + ':' + ' ' + Start,
                String.Empty + '\t' + '~' + "07" + ' ' + nameof(End) + ':' + ' ' + End,
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(Object) + ':',
                String.Empty + Object,
                String.Empty,
                String.Empty + '~' + "20" + ' ' + nameof(DirectoryInfo) + ':',
                String.Empty + DirectoryInfo,
                String.Empty,
                String.Empty + '~' + "30" + ' ' + nameof(FileInfo) + ':',
                String.Empty + FileInfo
            });
        }
    }
}
