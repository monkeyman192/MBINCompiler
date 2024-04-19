using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC52A83607CC704B8, NameHash = 0xEF85A351ABA84D63)]
    public class GcGrabbableData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 HandPose;
        /* 0x10 */ public Vector2f RotationLimits;
        /* 0x18 */ public float AttachTime;
        /* 0x1C */ public float DetachTime;
        /* 0x20 */ public float GrabRadius;
        // size: 0x4
        public enum GrabTypeEnum : uint {
            Default,
            EjectHandle,
            ControlStickLeft,
            ControlStickRight,
        }
        /* 0x24 */ public GrabTypeEnum GrabType;
        /* 0x28 */ public GcHand Hand;
        /* 0x2C */ public float MovementMaxSpeed;
        /* 0x30 */ public float MovementRequiredForActivation;
        /* 0x34 */ public float MovementReturnSpeed;
        /* 0x38 */ public float ReleaseRadius;
        /* 0x3C */ public float ToggleGrabTime;
        /* 0x40 */ public NMSString0x20 LocatorName;
        /* 0x60 */ public NMSString0x20 MovementEndLocator;
        /* 0x80 */ public NMSString0x20 MovementStartLocator;
        /* 0xA0 */ public bool AllowOtherWayUp;
        /* 0xA1 */ public bool AutoGrab;
    }
}
