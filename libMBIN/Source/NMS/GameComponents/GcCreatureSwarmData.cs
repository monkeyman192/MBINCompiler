using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE43A0B1A399B5BA, NameHash = 0xD4C11879)]
    public class GcCreatureSwarmData : NMSTemplate
    {
        [NMS(Index = 5)]
        /* 0x00 */ public List<GcCreatureSwarmDataParams> Params;
        [NMS(Index = 1)]
        /* 0x10 */ public int MaxCount;
        [NMS(Index = 0)]
        /* 0x14 */ public int MinCount;
        [NMS(Index = 3)]
        /* 0x18 */ public float SwarmMovementRadius;
        [NMS(Index = 2)]
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
        [NMS(Index = 4)]
        /* 0x20 */ public SwarmMovementTypeEnum SwarmMovementType;
    }
}
