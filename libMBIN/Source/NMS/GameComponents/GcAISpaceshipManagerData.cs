using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x8C3E63EA3A2D7991)]
    public class GcAISpaceshipManagerData : NMSTemplate     // size: 0x50
    {
        [NMS( EnumType = typeof( GcRealityCommonFactions.AIFactionEnum ) )]
        public GcAISpaceshipModelDataArray[] SystemSpaceships;
    }
}
