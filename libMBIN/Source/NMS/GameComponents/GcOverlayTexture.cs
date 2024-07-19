namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF04112F1E6E8705C, NameHash = 0x6AF2B1D8)]
    public class GcOverlayTexture : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public VariableSizeString OverlayDiffuse;
        [NMS(Index = 2)]
        /* 0x10 */ public VariableSizeString OverlayMasks;
        [NMS(Index = 1)]
        /* 0x20 */ public VariableSizeString OverlayNormal;
        [NMS(Index = 3)]
        /* 0x30 */ public int OverlayMaskIdx;
    }
}
