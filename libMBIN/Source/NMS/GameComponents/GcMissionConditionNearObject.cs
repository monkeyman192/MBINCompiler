namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x569261DBF05BD8B2, NameHash = 0x27E4E7E9)]
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
