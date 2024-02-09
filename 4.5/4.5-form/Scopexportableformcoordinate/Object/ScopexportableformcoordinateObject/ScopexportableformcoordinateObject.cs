using Core;

namespace Core
{
    using System;

    public partial struct Scopexportableformcoordinate
    {
        [Scopexportableism]
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] {
            
                String.Empty + nameof(Scopexportableformcoordinate) + ' ' + "::" + ' ' + '{',
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(FileInfo) + ':' + ' ' + ". . .",
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(DirectoryInfo) + ':' + ' ' + ". . .",
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(Text) + ':' + ' ' + "<hidden>",
                String.Empty + '\t' + '~' + "04" + ' ' + nameof(Text) + ':' + ' ' + Text.ValueSafe,
                String.Empty + '\t' + '~' + "05" + ' ' + nameof(Start) + ':' + ' ' + Start,
                String.Empty + '\t' + '~' + "06" + ' ' + nameof(End) + ':' + ' ' + End,
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(FileInfo) + ':',
                String.Empty + FileInfo,
                String.Empty,
                String.Empty + '~' + "20" + ' ' + nameof(DirectoryInfo) + ':',
                String.Empty + DirectoryInfo,
            });
        }
    }
}
