using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x20, GUID = 0xBCEED4B98D1D023B, NameHash = 0x2A779E46D946F774)]
    public class GcCreatureRidingAnimation : NMSTemplate
    {
        public NMSString0x10 MovementAnim;
        public NMSString0x10 RidingAnim;
    }
}
