using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x75590F128E7A6C9, NameHash = 0x43438226)]
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
