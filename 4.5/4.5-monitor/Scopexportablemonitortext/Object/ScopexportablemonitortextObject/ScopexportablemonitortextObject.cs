using Core;

namespace Core
{
    using System;

    public partial struct Scopexportablemonitortext
    {
        [Scopexportableism]
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] { 
            
                String.Empty + nameof(Scopexportablemonitortext) + ' ' + "::" + ' ' + '{',
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(IdleObject) + ':' + ' ' + (Boolean)IdleObject,
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(CharacterArrayObject) + ':' + ' ' + ". . ." + ' ' + $"<{((Scopexportablecharacterarraysafe)CharacterArrayObject).Value.Length}>",
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(ErrorObject) + ':' + ' ' + (Int32)ErrorObject,
                String.Empty + '\t' + '~' + "04" + ' ' + nameof(CharacterObject) + ':' + ' ' + "<hidden>",
                String.Empty + '\t' + '~' + "05" + ' ' + nameof(CharacterObject) + ':' + ' ' + ((Scopexportablecharactersafe)CharacterObject).ValueSafe,
                String.Empty + '\t' + '~' + "06" + ' ' + nameof(StartOfLineObject) + ':' + ' ' + (Int32)StartOfLineObject,
                String.Empty + '\t' + '~' + "07" + ' ' + nameof(EndOfLineObject) + ':' + ' ' + (Int32)EndOfLineObject,
                String.Empty + '\t' + '~' + "08" + ' ' + nameof(VirtualOffset) + ':' + ' ' + (Int32)VirtualOffsetObject,
                String.Empty + '\t' + '~' + "09" + ' ' + nameof(LineNumberObject) + ':' + ' ' + (Int32)LineNumberObject,
                String.Empty + '\t' + '~' + "10" + ' ' + nameof(LineObject) + ':' + ' ' + "<hidden>",
                String.Empty + '\t' + '~' + "11" + ' ' + nameof(LineObject) + ':' + ' ' + ((Scopexportablestringsafe)LineObject).ValueSafe,
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(CharacterArrayObject) + ':',
                String.Empty + $"<safe><<{String.Join('\n'.ToString(), ((Scopexportablecharacterarraysafe)CharacterArrayObject).Value)}>>"
            });
        }
    }
}