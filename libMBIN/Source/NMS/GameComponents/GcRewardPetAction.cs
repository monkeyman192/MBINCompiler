using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA43A6F3609E4D20D, NameHash = 0x76B0722D154CFD89)]
    public class GcRewardPetAction : NMSTemplate
    {
        /* 0x00 */ public GcCreaturePetRewardActions PetAction;
        /* 0x08 */ public NMSString0x10 PlayerEmoteID;
        /* 0x18 */ public NMSString0x10 EffectID;
        /* 0x28 */ public NMSString0x10 SpecialHarvestID;
        /* 0x38 */ public int SpecialHarvestMul;
    }
}
