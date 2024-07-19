namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x69C85DD8B3710C2, NameHash = 0x64EB01F9)]
    public class GcMissionSequenceLeaveNexusMP : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public VariableSizeString DebugText;
        [NMS(Index = 0)]
        /* 0x10 */ public VariableSizeString Message;
        [NMS(Index = 1)]
        /* 0x20 */ public VariableSizeString MessageNoWarp;
        [NMS(Index = 2)]
        /* 0x30 */ public ulong Timeout;
    }
}
