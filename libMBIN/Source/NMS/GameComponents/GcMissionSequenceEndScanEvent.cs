namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x593EBE192457373A, NameHash = 0xD15F5E0AAE5AA74)]
    public class GcMissionSequenceEndScanEvent : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x20A Event;
        [NMS(Index = 1)]
        /* 0x20 */ public NMSString0x80 DebugText;
    }
}
