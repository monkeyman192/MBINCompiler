namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4FD311BB97293E36, NameHash = 0x748605335FA1C427)]
    public class GcMissionConditionNearObject : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public float Distance;
        // size: 0x6
        public enum MissionObjectEnum : uint {
            PlayerShip,
            PlayerVehicle,
            PlayerSubmarine,
            StoryPortal,
            OpenStoryPortal,
            OpenStandardPortal,
        }
        [NMS(Index = 0)]
        /* 0x4 */ public MissionObjectEnum MissionObject;
    }
}
