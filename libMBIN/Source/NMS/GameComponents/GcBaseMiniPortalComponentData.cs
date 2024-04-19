namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6B51F3B80FECAB80, NameHash = 0xBBBD45634207B79F)]
    public class GcBaseMiniPortalComponentData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 DestinationGroupID;
        /* 0x10 */ public NMSString0x10 GroupID;
        // size: 0x4
        public enum DestinationSortTypeEnum : uint {
            NearestPotal,
            BaseBuildingConnection,
            AbandonedFreighter,
            PortalNearestPlayerShip,
        }
        /* 0x20 */ public DestinationSortTypeEnum DestinationSortType;
        /* 0x24 */ public int PowerCost;
        /* 0x28 */ public float SnapFacingAngle;
        /* 0x2C */ public bool AllowSpawnedObjects;
        /* 0x2D */ public bool AllowVehicles;
        /* 0x2E */ public bool DoPlayerEffects;
        /* 0x2F */ public bool FlipFacingDirection;
        /* 0x30 */ public bool SnapFacingDirection;
        /* 0x31 */ public bool TeleportCamera;
    }
}
