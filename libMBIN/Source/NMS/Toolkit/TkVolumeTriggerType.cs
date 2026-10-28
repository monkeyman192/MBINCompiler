namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xEE906B423CB477E1, NameHash = 0xEE0FA479)]
    public class TkVolumeTriggerType : NMSTemplate
    {
        // size: 0x18
        public enum VolumeTriggerTypeEnum : uint {
            Open,
            GenericInterior,
            GenericGlassInterior,
            Corridor,
            SmallRoom,
            LargeRoom,
            OpenCovered,
            HazardProtection,
            Dungeon,
            FieldBoundary,
            Custom_Biodome,
            Portal,
            VehicleBoost,
            NexusPlaza,
            NexusCommunityHub,
            NexusHangar,
            RaceObstacle,
            HazardProtectionCold,
            SpaceStorm,
            HazardProtectionNoRecharge,
            HazardProtectionSpook,
            ForceJetpackIgnition,
            SpookHazard,
            LocalPlayerOnly,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public VolumeTriggerTypeEnum VolumeTriggerType;
    }
}
