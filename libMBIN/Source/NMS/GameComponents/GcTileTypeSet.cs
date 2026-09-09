using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE13DB2A0375F5567, NameHash = 0xD14E108F)]
    public class GcTileTypeSet : NMSTemplate
    {
        [NMS(Index = 1, Size = 0xC)]
        /* 0x00 */ public TkPaletteTexture[] Colours;
        [NMS(Index = 0)]
        /* 0x90 */ public float Probability;
    }
}
