using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x1E0F7291EFAFB51B, NameHash = 0xE6DFCD18)]
    public class TkDynamicChainComponentData : NMSTemplate
    {
        [NMS(Index = 14)]
        /* 0x00 */ public List<NMSString0x20> IgnoreJoints;
        [NMS(Index = 6)]
        /* 0x10 */ public float AirThickness;
        [NMS(Index = 10)]
        /* 0x14 */ public float AngularDamping;
        [NMS(Index = 0)]
        /* 0x18 */ public float AngularLimit;
        [NMS(Index = 12)]
        /* 0x1C */ public float BodyMassChange;
        [NMS(Index = 5)]
        /* 0x20 */ public float Gravity;
        [NMS(Index = 11)]
        /* 0x24 */ public float InitialBodyMass;
        [NMS(Index = 9)]
        /* 0x28 */ public float LinearDamping;
        [NMS(Index = 4)]
        /* 0x2C */ public float MaxMotorForce;
        [NMS(Index = 2)]
        /* 0x30 */ public float MotorStrengthCone;
        [NMS(Index = 3)]
        /* 0x34 */ public float MotorStrengthTwist;
        [NMS(Index = 1)]
        /* 0x38 */ public float TwistLimit;
        [NMS(Index = 7)]
        /* 0x3C */ public float VertAirThickness;
        [NMS(Index = 8)]
        /* 0x40 */ public float WindStrength;
        [NMS(Index = 13)]
        /* 0x44 */ public bool WeightByJointLength;
    }
}
