using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x10, GUID = 0xDE0E4B894E24695A)]
    public class GcBuildingDensity : NMSTemplate
    {
        public float BuildingSpacing;
        [NMS( EnumType = typeof( GcBuildingClusterPlacement.BuildingClusterPlacementEnum ) )]
        public float[] BuildingClusterChance;
    }
}
