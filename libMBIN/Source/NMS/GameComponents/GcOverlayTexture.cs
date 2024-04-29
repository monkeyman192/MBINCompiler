namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA4D03B988E8C611A, NameHash = 0x5F253115B1050DE1)]
    public class GcOverlayTexture : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x000 */ public int OverlayMaskIdx;
        [NMS(Index = 0)]
        /* 0x004 */ public NMSString0x80 OverlayDiffuse;
        [NMS(Index = 2)]
        /* 0x084 */ public NMSString0x80 OverlayMasks;
        [NMS(Index = 1)]
        /* 0x104 */ public NMSString0x80 OverlayNormal;
    }
}
