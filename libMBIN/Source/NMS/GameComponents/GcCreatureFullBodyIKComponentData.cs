using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9D39B3D04CBFE703, NameHash = 0x518EE963)]
    public class GcCreatureFullBodyIKComponentData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public List<GcCreatureIkData> JointData;
        [NMS(Index = 1)]
        /* 0x10 */ public List<GcIkPistonData> PistonData;
        [NMS(Index = 5)]
        /* 0x20 */ public float BodyMassWeight;
        [NMS(Index = 13)]
        /* 0x24 */ public float FootAngleSpeed;
        [NMS(Index = 11)]
        /* 0x28 */ public float FootPlantSpringTime;
        [NMS(Index = 14)]
        /* 0x2C */ public float MaxFootAngle;
        [NMS(Index = 2)]
        /* 0x30 */ public float MaxHeadPitch;
        [NMS(Index = 3)]
        /* 0x34 */ public float MaxHeadRoll;
        [NMS(Index = 4)]
        /* 0x38 */ public float MaxHeadYaw;
        [NMS(Index = 8)]
        /* 0x3C */ public float MovementDamp;
        [NMS(Index = 6)]
        /* 0x40 */ public float Omega;
        [NMS(Index = 7)]
        /* 0x44 */ public float OmegaDropOff;
        [NMS(Index = 16)]
        /* 0x48 */ public bool Mech;
        [NMS(Index = 12)]
        /* 0x49 */ public bool UseFootAngle;
        [NMS(Index = 10)]
        /* 0x4A */ public bool UseFootGlue;
        [NMS(Index = 9)]
        /* 0x4B */ public bool UseFootRaycasts;
        [NMS(Index = 15)]
        /* 0x4C */ public bool UsePistons;
    }
}
