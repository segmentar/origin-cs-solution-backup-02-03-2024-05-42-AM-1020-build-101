using Core;

namespace Core
{
    using System;

    public partial class Scopexportablemonitorkey
    {
        public static void Key(Object reflect_OBJECT, Char value_CHARACTER)
        {
            var convert = Convert.ToInt32(value_CHARACTER);

            if (Object.Equals(convert, Scopexportableascii.EntityOne))
            {
                Scopexportablefontdown.Fontdown();
            }
            else if (Object.Equals(convert, Scopexportableascii.EntityTwo))
            {
                Scopexportablefontup.Fontup();
            }
            else if (Object.Equals(convert, Scopexportableascii.EntityThree))
            {
                Scopexportableclip.Clip(reflect_OBJECT);
            }
            else if (Object.Equals(convert, Scopexportableascii.EntityFour))
            {
                Scopexportablespeed.Speed(reflect_OBJECT);
            }
            else if (Object.Equals(convert, Scopexportableascii.EntityFive))
            {
                Scopexportablepause.Pause();
            }
            else if (Object.Equals(convert, Scopexportableascii.EntitySix))
            {
                Scopexportableskip.Skip();
            }
            else if (Object.Equals(convert, Scopexportableascii.EntitySeven))
            {
                Scopexportablebackward.Backward();
            }
            else if (Object.Equals(convert, Scopexportableascii.EntityEight))
            {
                Scopexportableforward.Forward();
            }
            else if (Object.Equals(convert, Scopexportableascii.EntityNine))
            {
                Scopexportablerestart.Restart();
            }

            return;
        }
    }
}
