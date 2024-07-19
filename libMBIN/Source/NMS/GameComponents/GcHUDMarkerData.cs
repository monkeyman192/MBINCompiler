namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE87D23E3B31E9499, NameHash = 0x75A01ACB)]
    public class GcHUDMarkerData : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public VariableSizeString Distance;
        [NMS(Index = 0)]
        /* 0x10 */ public VariableSizeString Icon;
        [NMS(Index = 1)]
        /* 0x20 */ public VariableSizeString IconBehind;
    }
}
