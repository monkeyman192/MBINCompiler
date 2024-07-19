namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5A3F8B5FC8BC1B2, NameHash = 0x10AEB3EA)]
    public class GcMissionSequenceShowPodMessage : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public VariableSizeString DebugText;
        [NMS(Index = 0)]
        /* 0x10 */ public VariableSizeString Message;
    }
}
