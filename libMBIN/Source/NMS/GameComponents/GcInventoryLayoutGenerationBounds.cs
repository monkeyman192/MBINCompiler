namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xECAF88AD522ED4A2, NameHash = 0xDCCAA3DA4C5BEA87)]
    public class GcInventoryLayoutGenerationBounds : NMSTemplate
    {
        [NMS(Index = 5)]
        /* 0x00 */ public int MaxHeightLarge;
        [NMS(Index = 1)]
        /* 0x04 */ public int MaxHeightSmall;
        [NMS(Index = 3)]
        /* 0x08 */ public int MaxHeightStandard;
        [NMS(Index = 4)]
        /* 0x0C */ public int MaxWidthLarge;
        [NMS(Index = 0)]
        /* 0x10 */ public int MaxWidthSmall;
        [NMS(Index = 2)]
        /* 0x14 */ public int MaxWidthStandard;
    }
}
