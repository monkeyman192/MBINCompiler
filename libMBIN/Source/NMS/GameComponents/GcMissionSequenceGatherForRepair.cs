using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x237B038B99D005B9, NameHash = 0x535215E1DEB68BB2)]
    public class GcMissionSequenceGatherForRepair : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 GatherResource;
        /* 0x10 */ public GcStatsTypes TargetStat;
        /* 0x14 */ public NMSString0x80 DebugText;
        /* 0x94 */ public NMSString0x80 Message;
    }
}
