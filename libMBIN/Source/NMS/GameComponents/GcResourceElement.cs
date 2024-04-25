using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x95B481E7A5B767DD, NameHash = 0x91CAC70AC2792E2A)]
    public class GcResourceElement : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x000 */ public TkProceduralTextureChosenOptionList ProceduralTexture;
        [NMS(Index = 2)]
        /* 0x010 */ public GcSeed Seed;
        [NMS(Index = 1)]
        /* 0x020 */ public GcResource ResHandle;
        [NMS(Index = 3)]
        /* 0x024 */ public NMSString0x200 AltId;
        [NMS(Index = 0)]
        /* 0x224 */ public NMSString0x80 Filename;
    }
}
