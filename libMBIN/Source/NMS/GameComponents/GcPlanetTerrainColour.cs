using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF7DB684EAAC0E986, NameHash = 0xDA4AB69C)]
    public class GcPlanetTerrainColour : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public TkPaletteTexture Palette;
        [NMS(Index = 1)]
        /* 0xC */ public int Index;
    }
}
