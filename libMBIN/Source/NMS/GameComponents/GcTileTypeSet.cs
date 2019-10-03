using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x843A3DAF82E8DFDF, NameHash = 0x30CD85DD787F512A)]
    public class GcTileTypeSet : NMSTemplate
    {
        public float Probability;

        [NMS(Size = 0xC)]
        public TkPaletteTexture[] Colours;
    }
}
