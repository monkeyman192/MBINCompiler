namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x890EDF0323EEF368, NameHash = 0x4222EB9E)]
    public class GcAttractorComponentData : NMSTemplate
    {
        [NMS(Index = 18)]
        /* 0x00 */ public NMSString0x10 GrabEffect;
        [NMS(Index = 16)]
        /* 0x10 */ public float AttachAngularSpeedThreshold;
        [NMS(Index = 15)]
        /* 0x14 */ public float AttachLinearSpeedThreshold;
        [NMS(Index = 14)]
        /* 0x18 */ public float AttachTime;
        [NMS(Index = 7)]
        /* 0x1C */ public float AttractFalloff;
        [NMS(Index = 10)]
        /* 0x20 */ public float AttractorAngularDampingStrength;
        [NMS(Index = 24)]
        /* 0x24 */ public float EjectAngularSpeedMax;
        [NMS(Index = 23)]
        /* 0x28 */ public float EjectAngularSpeedMin;
        [NMS(Index = 20)]
        /* 0x2C */ public float EjectInterval;
        [NMS(Index = 22)]
        /* 0x30 */ public float EjectLinearSpeedMax;
        [NMS(Index = 21)]
        /* 0x34 */ public float EjectLinearSpeedMin;
        [NMS(Index = 5)]
        /* 0x38 */ public float InnerVolumeScale;
        [NMS(Index = 8)]
        /* 0x3C */ public float LateralDamping;
        [NMS(Index = 9)]
        /* 0x40 */ public float LateralDampingFalloff;
        [NMS(Index = 1)]
        /* 0x44 */ public float MaxSpeed;
        [NMS(Index = 17)]
        /* 0x48 */ public float OwnershipRequestCooldown;
        [NMS(Index = 2)]
        /* 0x4C */ public float Radius;
        [NMS(Index = 13)]
        /* 0x50 */ public float StickyAngularDamping;
        [NMS(Index = 11)]
        /* 0x54 */ public float StickyDistance;
        [NMS(Index = 12)]
        /* 0x58 */ public float StickyLinearDamping;
        [NMS(Index = 0)]
        /* 0x5C */ public float Strength;
        [NMS(Index = 6)]
        /* 0x60 */ public NMSString0x20 GravGunReleaseVolumeNodeName;
        [NMS(Index = 4)]
        /* 0x80 */ public NMSString0x20 InnerVolumeNodeName;
        [NMS(Index = 3)]
        /* 0xA0 */ public NMSString0x20 VolumeNodeName;
        [NMS(Index = 19)]
        /* 0xC0 */ public bool DeliverablesOnly;
    }
}
