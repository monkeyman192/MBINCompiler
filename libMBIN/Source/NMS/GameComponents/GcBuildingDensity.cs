using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x10, GUID = 0xDE0E4B894E24695A, NameHash = 0xFC703DAD77E37E30)]
    public class GcBuildingDensity : NMSTemplate
    {
        public float BuildingSpacing;

        public enum ClusterChanceEnum { Cluster, Large, Small }     // TODO: need to check

        [NMS(Size = 0x3, EnumType = typeof(ClusterChanceEnum))]
        public float[] BuildingClusterChance;
    }
}
