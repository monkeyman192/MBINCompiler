using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x270ED76F1C241C20, NameHash = 0xC435CF34)]
    public class GcResourceElement : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public VariableSizeString AltId;
        [NMS(Index = 0)]
        /* 0x10 */ public VariableSizeString Filename;
        [NMS(Index = 4)]
        /* 0x20 */ public TkProceduralTextureChosenOptionList ProceduralTexture;
        [NMS(Index = 2)]
        /* 0x30 */ public GcSeed Seed;
        [NMS(Index = 1)]
        /* 0x40 */ public GcResource ResHandle;
    }
}
