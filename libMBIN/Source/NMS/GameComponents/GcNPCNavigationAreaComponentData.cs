using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x1C, GUID = 0x8D72B0118FE37410, NameHash = 0xB4FC959D6A910DEB)]
    public class GcNPCNavigationAreaComponentData : NMSTemplate
    {
        public enum NavAreaTypeEnum { Normal, BuildingWithExterior , Debris, Ship }
        public NavAreaTypeEnum GetNavAreaType;
        public float MinRadius;
        public float MaxRadius;
        public float SphereCastHeightClearance;
        public float NeighbourCandidateDistance;
        public float MaxNeighbourSlope;
        public float ConnectionLengthFactor;
    }
}
