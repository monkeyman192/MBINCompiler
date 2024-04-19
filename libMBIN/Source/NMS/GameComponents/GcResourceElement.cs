using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x95B481E7A5B767DD, NameHash = 0x91CAC70AC2792E2A)]
    public class GcResourceElement : NMSTemplate
    {
        /* 0x000 */ public TkProceduralTextureChosenOptionList ProceduralTexture;
        /* 0x010 */ public GcSeed Seed;
        /* 0x020 */ public GcResource ResHandle;
        /* 0x024 */ public NMSString0x200 AltId;
        /* 0x224 */ public NMSString0x80 Filename;
    }
}
