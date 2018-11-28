using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xA6EC1041FE8F1AF9)]
    public class GcGalaxyStarColours : NMSTemplate      // size: 0x40
    {
        [NMS( EnumType = typeof( GcGalaxyStarTypes.GalaxyStarTypeEnum ) )]
        public Colour[] ColourByStarType;
    }
}
