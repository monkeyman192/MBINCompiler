using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x340F85D004D3C5C8, NameHash = 0x647190B1)]
    public class GcPlayerMissionUpgradeMapEntry : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x00 */ public List<NMSString0x10> CompletedMissions;
        [NMS(Index = 0)]
        /* 0x10 */ public NMSString0x10 Mission;
        [NMS(Index = 3)]
        /* 0x20 */ public NMSString0x10 NewMission;
        [NMS(Index = 2)]
        /* 0x30 */ public int CompletePoint;
        [NMS(Index = 1)]
        /* 0x34 */ public int MinProgress;
    }
}
