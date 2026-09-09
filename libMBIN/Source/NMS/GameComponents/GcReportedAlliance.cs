namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x70B60FA00EBCC2D5, NameHash = 0x394E47C1)]
    public class GcReportedAlliance : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x40 AllianceId;
        [NMS(Index = 1)]
        /* 0x40 */ public NMSString0x20 OriginalName;
        [NMS(Index = 2)]
        /* 0x60 */ public NMSString0x20 OriginalTag;
        [NMS(Index = 3)]
        /* 0x80 */ public bool NameReported;
        [NMS(Index = 4)]
        /* 0x81 */ public bool TagReported;
    }
}
