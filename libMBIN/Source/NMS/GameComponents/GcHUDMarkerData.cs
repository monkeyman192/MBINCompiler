namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA4159AB1AA0D170A, NameHash = 0x73308053CF12ECFF)]
    public class GcHUDMarkerData : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x000 */ public NMSString0x80 Distance;
        [NMS(Index = 0)]
        /* 0x080 */ public NMSString0x80 Icon;
        [NMS(Index = 1)]
        /* 0x100 */ public NMSString0x80 IconBehind;
    }
}
