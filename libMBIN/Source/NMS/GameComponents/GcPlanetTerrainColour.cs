using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3EDD93D9E37AFC13, NameHash = 0xDA4AB69C)]
    public class GcPlanetTerrainColour : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public TkPaletteTexture Palette;
        [NMS(Index = 1)]
        /* 0x8 */ public int Index;
    }
}
