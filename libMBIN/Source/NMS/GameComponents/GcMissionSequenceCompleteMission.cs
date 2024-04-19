namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD7A66E523D362B0B, NameHash = 0xF34AADF7CA91192B)]
    public class GcMissionSequenceCompleteMission : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Mission;
        /* 0x10 */ public NMSString0x80 DebugText;
        /* 0x90 */ public bool UseSeed;
    }
}
