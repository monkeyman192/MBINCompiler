namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDD5F1888E15870B6, NameHash = 0xB4FC959D6A910DEB)]
    public class GcNPCNavigationAreaComponentData : NMSTemplate
    {
        [NMS(Index = 7)]
        /* 0x00 */ public float ConnectionLengthFactor;
        [NMS(Index = 5)]
        /* 0x04 */ public float MaxNeighbourSlope;
        [NMS(Index = 2)]
        /* 0x08 */ public float MaxRadius;
        [NMS(Index = 1)]
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
        [NMS(Index = 0)]
        /* 0x10 */ public NavAreaTypeEnum NavAreaType;
        [NMS(Index = 4)]
        /* 0x14 */ public float NeighbourCandidateDistance;
        [NMS(Index = 3)]
        /* 0x18 */ public float SphereCastHeightClearance;
        [NMS(Index = 6)]
        /* 0x1C */ public bool LimitPOIConnections;
    }
}
