using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5951970140BE6541, NameHash = 0x3165E96F)]
    public class GcRewardSpecificPetEgg : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x000 */ public GcPetData EggData;
        [NMS(Index = 0)]
        /* 0x208 */ public bool ImmediatelyHatchable;
    }
}
