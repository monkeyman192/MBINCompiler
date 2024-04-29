using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x27B2F717BF6FACE7, NameHash = 0xF9B9838B50251311)]
    public class GcPlanetTerrainColour : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public TkPaletteTexture Palette;
        [NMS(Index = 1)]
        /* 0x8 */ public int Index;
    }
}
