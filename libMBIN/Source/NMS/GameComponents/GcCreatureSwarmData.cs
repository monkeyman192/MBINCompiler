using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB3AED157D9B5E63, NameHash = 0x87C83AD7D0C1D117)]
    public class GcCreatureSwarmData : NMSTemplate
    {
        /* 0x00 */ public List<GcCreatureSwarmDataParams> Params;
        /* 0x10 */ public int MaxCount;
        /* 0x14 */ public int MinCount;
        /* 0x18 */ public float SwarmMovementRadius;
        /* 0x1C */ public float SwarmMovementSpeed;
        // size: 0x6
        public enum SwarmMovementTypeEnum : uint {
            None,
            Circle,
            Random,
            Search,
            FollowPlayer,
            FollowPlayerLimited,
        }
        /* 0x20 */ public SwarmMovementTypeEnum SwarmMovementType;
    }
}
