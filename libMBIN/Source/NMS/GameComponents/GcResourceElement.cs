using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x54E0C31157A2EE94, NameHash = 0xC435CF34)]
    public class GcResourceElement : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x00 */ public VariableSizeString AltId;
        [NMS(Index = 0)]
        /* 0x10 */ public GcFilename Filename;
        [NMS(Index = 3)]
        /* 0x20 */ public TkProceduralTextureChosenOptionList ProceduralTexture;
        [NMS(Index = 2)]
        /* 0x30 */ public GcSeed Seed;
        [NMS(Index = 1)]
        /* 0x40 */ public GcResource ResHandle;
    }
}
