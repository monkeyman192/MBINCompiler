namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x99D79E3090915908, NameHash = 0xF28B5D3A889453A9)]
    public class GcBuildingDistribution : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Name;
        [NMS(Index = 2)]
        /* 0x10 */ public int MaxDistance;
        [NMS(Index = 1)]
        /* 0x14 */ public int MinDistance;
    }
}
