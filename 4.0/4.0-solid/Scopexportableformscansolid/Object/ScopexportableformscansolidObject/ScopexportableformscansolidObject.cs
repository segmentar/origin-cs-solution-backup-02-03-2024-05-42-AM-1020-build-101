namespace Core
{
    using System;

    public partial struct Scopexportableformscansolid
    {
        [Scopexportableism]
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] {

                String.Empty + nameof(Scopexportableformscansolid) + ' ' + "::" + ' ' + '{',
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(DirectoryInfo) + ':' + ' ' + ". . .",
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(FileInfo) + ':' + ' ' + ". . .",
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(Text) + ':' + ' ' + "<hidden>",
                String.Empty + '\t' + '~' + "04" + ' ' + nameof(Text) + ':' + ' ' + Text.ValueSafe,
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(DirectoryInfo) + ':',
                String.Empty + DirectoryInfo,
                String.Empty,
                String.Empty + '~' + "20" + ' ' + nameof(FileInfo) + ':',
                String.Empty + FileInfo
            });
        }
    }
}