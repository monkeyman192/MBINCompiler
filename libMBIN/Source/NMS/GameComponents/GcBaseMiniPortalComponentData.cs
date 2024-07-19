namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAF9974D3994342BA, NameHash = 0x16C75ED9)]
    public class GcBaseMiniPortalComponentData : NMSTemplate
    {
        [NMS(Index = 9)]
        /* 0x00 */ public NMSString0x10 DestinationGroupID;
        [NMS(Index = 8)]
        /* 0x10 */ public NMSString0x10 GroupID;
        // size: 0x4
        public enum DestinationSortTypeEnum : uint {
            NearestPotal,
            BaseBuildingConnection,
            AbandonedFreighter,
            PortalNearestPlayerShip,
        }
        [NMS(Index = 10)]
        /* 0x20 */ public DestinationSortTypeEnum DestinationSortType;
        [NMS(Index = 7)]
        /* 0x24 */ public int PowerCost;
        [NMS(Index = 4)]
        /* 0x28 */ public float SnapFacingAngle;
        [NMS(Index = 1)]
        /* 0x2C */ public bool AllowSpawnedObjects;
        [NMS(Index = 0)]
        /* 0x2D */ public bool AllowVehicles;
        [NMS(Index = 5)]
        /* 0x2E */ public bool DoPlayerEffects;
        [NMS(Index = 2)]
        /* 0x2F */ public bool FlipFacingDirection;
        [NMS(Index = 3)]
        /* 0x30 */ public bool SnapFacingDirection;
        [NMS(Index = 6)]
        /* 0x31 */ public bool TeleportCamera;
    }
}
