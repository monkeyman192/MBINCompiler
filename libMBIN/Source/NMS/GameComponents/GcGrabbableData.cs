using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1E328F216FA9CEBE, NameHash = 0x9BD0586E)]
    public class GcGrabbableData : NMSTemplate
    {
        [NMS(Index = 11)]
        /* 0x00 */ public NMSString0x10 HandPose;
        [NMS(Index = 6)]
        /* 0x10 */ public Vector2f RotationLimits;
        [NMS(Index = 2)]
        /* 0x18 */ public float AttachTime;
        [NMS(Index = 4)]
        /* 0x1C */ public float DetachTime;
        [NMS(Index = 1)]
        /* 0x20 */ public float GrabRadius;
        // size: 0x4
        public enum GrabTypeEnum : uint {
            Default,
            EjectHandle,
            ControlStickLeft,
            ControlStickRight,
        }
        [NMS(Index = 10)]
        /* 0x24 */ public GrabTypeEnum GrabType;
        [NMS(Index = 5)]
        /* 0x28 */ public GcHand Hand;
        [NMS(Index = 14)]
        /* 0x2C */ public float MovementMaxSpeed;
        [NMS(Index = 16)]
        /* 0x30 */ public float MovementRequiredForActivation;
        [NMS(Index = 15)]
        /* 0x34 */ public float MovementReturnSpeed;
        [NMS(Index = 3)]
        /* 0x38 */ public float ReleaseRadius;
        [NMS(Index = 9)]
        /* 0x3C */ public float ToggleGrabTime;
        [NMS(Index = 0)]
        /* 0x40 */ public NMSString0x20 LocatorName;
        [NMS(Index = 13)]
        /* 0x60 */ public NMSString0x20 MovementEndLocator;
        [NMS(Index = 12)]
        /* 0x80 */ public NMSString0x20 MovementStartLocator;
        [NMS(Index = 7)]
        /* 0xA0 */ public bool AllowOtherWayUp;
        [NMS(Index = 8)]
        /* 0xA1 */ public bool AutoGrab;
    }
}
