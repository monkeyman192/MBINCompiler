namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCE5A3AF133C12ECA, NameHash = 0xCB1AFECA)]
    public class GcMissionSequenceWaitForAbandFreighterDoorOpen : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public VariableSizeString DebugText;
        [NMS(Index = 0)]
        /* 0x10 */ public VariableSizeString Message;
        [NMS(Index = 1)]
        /* 0x20 */ public VariableSizeString MessageOvertime;
        [NMS(Index = 2)]
        /* 0x30 */ public float MinTime;
    }
}
