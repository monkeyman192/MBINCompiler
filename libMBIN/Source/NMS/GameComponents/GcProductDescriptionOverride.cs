namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x926CC53724C0D6A9, NameHash = 0x4EBB345F)]
    public class GcProductDescriptionOverride : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public NMSString0x20A NewDescription;
        [NMS(Index = 1)]
        /* 0x20 */ public NMSString0x10 MissionID;
        [NMS(Index = 0)]
        /* 0x30 */ public NMSString0x10 ProductID;
    }
}
