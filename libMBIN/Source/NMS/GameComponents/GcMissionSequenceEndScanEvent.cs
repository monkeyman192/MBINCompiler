namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1128EE2DD6CCC01, NameHash = 0x4AEF809F)]
    public class GcMissionSequenceEndScanEvent : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x20A Event;
        [NMS(Index = 1)]
        /* 0x20 */ public VariableSizeString DebugText;
    }
}
