using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD680504826EC9DEF, NameHash = 0x64518D36439612AC)]
    public class GcRewardForgetSpecificTechRecipe : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<NMSString0x10> TechList;
    }
}
