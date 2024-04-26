namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x606FCE0896D4B123, NameHash = 0xD9BAAE731EB23B1)]
    public class GcMissionSequenceVehicleScan : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x20A ScanEventID;
        [NMS(Index = 2)]
        /* 0x20 */ public NMSString0x80 DebugText;
        [NMS(Index = 0)]
        /* 0xA0 */ public NMSString0x80 Message;
    }
}
