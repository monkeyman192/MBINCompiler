namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x79B617DAB348E129, NameHash = 0x29990E222BC59FCC)]
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
