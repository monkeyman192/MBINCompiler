namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE8962209776E3A6D, NameHash = 0x48508806BFEC4731)]
    public class GcMissionSequenceSetCurrentMission : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 MissionID;
        [NMS(Index = 3)]
        /* 0x10 */ public NMSString0x80 DebugText;
        [NMS(Index = 1)]
        /* 0x90 */ public bool FirstIncompleteMilestone;
        [NMS(Index = 2)]
        /* 0x91 */ public bool Silent;
    }
}
