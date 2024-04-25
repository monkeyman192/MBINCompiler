namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2F2901151340C2B1, NameHash = 0xC87FA7A77434B86F)]
    public class GcCostHasActiveScanEvent : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x20A OptionalEventID;
        [NMS(Index = 0)]
        /* 0x20 */ public NMSString0x20A Text;
    }
}
