using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x8C3E63EA3A2D7991, NameHash = 0x785665CB6C017B4C)]
    public class GcAISpaceshipManagerData : NMSTemplate     // size: 0x50
    {
        [NMS(Size = 5, EnumType = typeof(GcRealityCommonFactions.AIFactionEnum))]
        public GcAISpaceshipModelDataArray[] SystemSpaceships;
    }
}
