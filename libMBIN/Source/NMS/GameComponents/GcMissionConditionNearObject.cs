using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5D3EF5FA6BDF1BD8, NameHash = 0x27E4E7E9)]
    public class GcMissionConditionNearObject : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x0 */ public float Distance;
        // size: 0x8
        public enum MissionObjectEnum : uint {
            PlayerShip,
            PlayerVehicle,
            PlayerSubmarine,
            StoryPortal,
            OpenStoryPortal,
            OpenStandardPortal,
            ScannableOfType,
            TaggedObject,
        }
        [NMS(Index = 0)]
        /* 0x4 */ public MissionObjectEnum MissionObject;
        [NMS(Index = 2)]
        /* 0x8 */ public GcStaticTag TagToFind;
        [NMS(Index = 1)]
        /* 0xC */ public GcScannerIconTypes ScannableTypeToUse;
    }
}
