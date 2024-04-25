using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6AC29EE3849817B5, NameHash = 0x8531B20A02DD0931)]
    public class GcScanData : NMSTemplate
    {
        [NMS(Index = 8)]
        /* 0x00 */ public NMSString0x10 CameraEventId;
        // size: 0x3
        public enum CameraEventFocusTargetTypeEnum : uint {
            None,
            ScanEventBuilding,
            RevealedNPC,
        }
        [NMS(Index = 9)]
        /* 0x10 */ public CameraEventFocusTargetTypeEnum CameraEventFocusTargetType;
        // size: 0x3
        public enum CameraEventTypeEnum : uint {
            None,
            AerialView,
            LookAt,
        }
        [NMS(Index = 7)]
        /* 0x14 */ public CameraEventTypeEnum CameraEventType;
        [NMS(Index = 5)]
        /* 0x18 */ public float ChargeTime;
        [NMS(Index = 1)]
        /* 0x1C */ public float PulseRange;
        [NMS(Index = 2)]
        /* 0x20 */ public float PulseTime;
        [NMS(Index = 6)]
        /* 0x24 */ public float ScanRevealDelay;
        [NMS(Index = 0)]
        /* 0x28 */ public GcScanType ScanType;
        [NMS(Index = 3)]
        /* 0x2C */ public bool AddMarkers;
        [NMS(Index = 4)]
        /* 0x2D */ public bool PlayAudioOnMarkers;
    }
}
