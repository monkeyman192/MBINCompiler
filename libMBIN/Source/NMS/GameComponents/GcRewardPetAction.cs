using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x28, GUID = 0xD5DC7D27BDEF54F1, NameHash = 0x76B0722D154CFD89)]
    public class GcRewardPetAction : NMSTemplate
    {
        /* 0x00 */ public GcCreaturePetRewardActions PetAction;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x04 */ public byte[] Padding4;
        /* 0x08 */ public NMSString0x10 PlayerEmoteID;
        /* 0x18 */ public NMSString0x10 EffectID;
    }
}
