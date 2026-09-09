namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4FB445DCBEA731B0, NameHash = 0xD18ED840)]
    public class GcAtlasBanner : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Id;
        [NMS(Index = 4)]
        /* 0x10 */ public NMSString0x10 TitleId;
        [NMS(Index = 3)]
        /* 0x20 */ public int BackgroundColourIndex;
        [NMS(Index = 1)]
        /* 0x24 */ public int IconIndex;
        [NMS(Index = 2)]
        /* 0x28 */ public int MainColourIndex;
    }
}
