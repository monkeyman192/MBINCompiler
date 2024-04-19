using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE26D7BAEE3C6CDBD, NameHash = 0x227F6003863B9E93)]
    public class GcRewardSpecificPetEgg : NMSTemplate
    {
        /* 0x000 */ public GcPetData EggData;
        /* 0x208 */ public bool ImmediatelyHatchable;
    }
}
