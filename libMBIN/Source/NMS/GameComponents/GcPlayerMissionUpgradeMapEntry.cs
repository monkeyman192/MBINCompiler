using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x18837F6683177204, NameHash = 0x783F7F56522EAFC6)]
    public class GcPlayerMissionUpgradeMapEntry : NMSTemplate
    {
        /* 0x00 */ public List<NMSString0x10> CompletedMissions;
        /* 0x10 */ public NMSString0x10 Mission;
        /* 0x20 */ public NMSString0x10 NewMission;
        /* 0x30 */ public int CompletePoint;
        /* 0x34 */ public int MinProgress;
    }
}
