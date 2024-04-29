namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9DE421EC46BFBE40, NameHash = 0xF34AADF7CA91192B)]
    public class GcMissionSequenceCompleteMission : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Mission;
        [NMS(Index = 2)]
        /* 0x10 */ public NMSString0x80 DebugText;
        [NMS(Index = 1)]
        /* 0x90 */ public bool UseSeed;
    }
}
