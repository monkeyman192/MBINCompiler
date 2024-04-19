using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x97E00A3D2E34A338, NameHash = 0xAD73013CE22251D2)]
    public class GcRewardTechRecipe : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 RewardGroup;
        /* 0x10 */ public GcTechnologyCategory Category;
    }
}
