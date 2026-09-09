using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB956130822EF026F, NameHash = 0x27E4E7E9)]
    public class GcMissionConditionNearObject : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x0 */ public float Distance;
        // size: 0x7
        public enum MissionObjectEnum : uint {
            PlayerShip,
            PlayerVehicle,
            PlayerSubmarine,
            StoryPortal,
            OpenStoryPortal,
            OpenStandardPortal,
            ScannableOfType,
        }
        [NMS(Index = 0)]
        /* 0x4 */ public MissionObjectEnum MissionObject;
        [NMS(Index = 1)]
        /* 0x8 */ public GcScannerIconTypes ScannableTypeToUse;
    }
}
