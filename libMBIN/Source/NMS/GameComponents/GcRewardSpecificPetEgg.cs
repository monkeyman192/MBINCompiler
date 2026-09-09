using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2F8A34F29B2667D9, NameHash = 0x3165E96F)]
    public class GcRewardSpecificPetEgg : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x000 */ public GcPetData EggData;
        [NMS(Index = 3)]
        /* 0x2F8 */ public NMSString0x10 SpecialMessageProdID;
        [NMS(Index = 2)]
        /* 0x308 */ public bool ForceSpecialMessage;
        [NMS(Index = 0)]
        /* 0x309 */ public bool ImmediatelyHatchable;
    }
}
