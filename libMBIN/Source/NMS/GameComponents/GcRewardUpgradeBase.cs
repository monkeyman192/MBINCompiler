using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB2392A45A5ED6AD4, NameHash = 0xE60E16C73CCFBAC0)]
    public class GcRewardUpgradeBase : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public List<GcPersistentBaseTypes> MatchingBaseTypes;
        // size: 0x2
        public enum UpgradeBaseTypeEnum : uint {
            AllMatching,
            NearestMatching,
        }
        [NMS(Index = 0)]
        /* 0x10 */ public UpgradeBaseTypeEnum UpgradeBaseType;
    }
}
