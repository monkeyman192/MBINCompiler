using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAC51492EF13E3829, NameHash = 0xD14E108F)]
    public class GcTileTypeSet : NMSTemplate
    {
        [NMS(Index = 1, Size = 0xC)]
        /* 0x00 */ public TkPaletteTexture[] Colours;
        [NMS(Index = 0)]
        /* 0x60 */ public float Probability;
    }
}
