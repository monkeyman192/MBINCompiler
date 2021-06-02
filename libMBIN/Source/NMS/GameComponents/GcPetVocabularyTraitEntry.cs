using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x48, GUID = 0xFE4D9BAC751D849B, NameHash = 0xD1AA1B644B5DE736)]
    public class GcPetVocabularyTraitEntry : NMSTemplate
    {
        /* 0x00 */ public GcCreaturePetTraits Traits;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x04 */ public byte[] Padding4;
        /* 0x08 */ public NMSString0x20 Positive;
        /* 0x28 */ public NMSString0x20 Negative;
    }
}
