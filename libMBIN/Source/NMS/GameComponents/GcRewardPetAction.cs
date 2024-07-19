using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA01148B86EF12B53, NameHash = 0xCCAC9651)]
    public class GcRewardPetAction : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public NMSString0x10 EffectID;
        [NMS(Index = 1)]
        /* 0x10 */ public NMSString0x10 PlayerEmoteID;
        [NMS(Index = 3)]
        /* 0x20 */ public NMSString0x10 SpecialHarvestID;
        [NMS(Index = 0)]
        /* 0x30 */ public GcCreaturePetRewardActions PetAction;
        [NMS(Index = 4)]
        /* 0x34 */ public int SpecialHarvestMul;
    }
}
