namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9A118799183ED21A, NameHash = 0x48508806BFEC4731)]
    public class GcMissionSequenceSetCurrentMission : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 MissionID;
        /* 0x10 */ public NMSString0x80 DebugText;
        /* 0x90 */ public bool FirstIncompleteMilestone;
        /* 0x91 */ public bool Silent;
    }
}
