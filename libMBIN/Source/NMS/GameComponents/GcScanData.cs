using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6AC29EE3849817B5, NameHash = 0x8531B20A02DD0931)]
    public class GcScanData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 CameraEventId;
        // size: 0x3
        public enum CameraEventFocusTargetTypeEnum : uint {
            None,
            ScanEventBuilding,
            RevealedNPC,
        }
        /* 0x10 */ public CameraEventFocusTargetTypeEnum CameraEventFocusTargetType;
        // size: 0x3
        public enum CameraEventTypeEnum : uint {
            None,
            AerialView,
            LookAt,
        }
        /* 0x14 */ public CameraEventTypeEnum CameraEventType;
        /* 0x18 */ public float ChargeTime;
        /* 0x1C */ public float PulseRange;
        /* 0x20 */ public float PulseTime;
        /* 0x24 */ public float ScanRevealDelay;
        /* 0x28 */ public GcScanType ScanType;
        /* 0x2C */ public bool AddMarkers;
        /* 0x2D */ public bool PlayAudioOnMarkers;
    }
}
