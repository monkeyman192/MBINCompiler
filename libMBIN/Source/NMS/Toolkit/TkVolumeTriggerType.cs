namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x8AEBEF11092A0AA6, NameHash = 0xEE0FA479)]
    public class TkVolumeTriggerType : NMSTemplate
    {
        // size: 0x12
        public enum VolumeTriggerTypeEnum : uint {
            Open,
            GenericInterior,
            GenericGlassInterior,
            Corridor,
            SmallRoom,
            LargeRoom,
            OpenCovered,
            HazardProtection,
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
        }
        [NMS(Index = 0)]
        /* 0x0 */ public VolumeTriggerTypeEnum VolumeTriggerType;
    }
}
