using Core;

namespace Core
{
    using System;

    public partial class Scopexportablesafe
    {
        public static Char GroupCharacter(Char Character_VALUE)
        {
            Char characterResult = default;

            Char character;

            if (Char.IsControl(Character_VALUE))
            {
                character = (Char)Scopexportableascii.EntityWhitespace;
            }
            else
            {
                character = Character_VALUE;
            }

            characterResult = character;

            return characterResult;
        }
    }
}
