namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4FD311BB97293E36, NameHash = 0x748605335FA1C427)]
    public class GcMissionConditionNearObject : NMSTemplate
    {
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
        /* 0x4 */ public MissionObjectEnum MissionObject;
    }
}
