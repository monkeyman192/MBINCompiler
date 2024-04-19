namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAB6146971456B356, NameHash = 0xB4FC959D6A910DEB)]
    public class GcNPCNavigationAreaComponentData : NMSTemplate
    {
        /* 0x00 */ public float ConnectionLengthFactor;
        /* 0x04 */ public float MaxNeighbourSlope;
        /* 0x08 */ public float MaxRadius;
        /* 0x0C */ public float MinRadius;
        // size: 0x9
        public enum NavAreaTypeEnum : uint {
            Normal,
            BuildingWithExterior,
            Debris,
            Ship,
            Mech,
            PlanetMech,
            Demo,
            WFCBase,
            FreighterBase,
        }
        /* 0x10 */ public NavAreaTypeEnum NavAreaType;
        /* 0x14 */ public float NeighbourCandidateDistance;
        /* 0x18 */ public float SphereCastHeightClearance;
        /* 0x1C */ public bool LimitPOIConnections;
    }
}
