using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD444BB434F26B84C, NameHash = 0x741554C15123D097)]
    public class GcCreatureFullBodyIKComponentData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public List<GcCreatureIkData> JointData;
        [NMS(Index = 1)]
        /* 0x10 */ public List<GcIkPistonData> PistonData;
        [NMS(Index = 6)]
        /* 0x20 */ public float BodyMassWeight;
        [NMS(Index = 14)]
        /* 0x24 */ public float FootAngleSpeed;
        [NMS(Index = 12)]
        /* 0x28 */ public float FootPlantSpringTime;
        // size: 0x6
        public enum HeadUpAxisEnum : uint {
            X,
            XNeg,
            Y,
            YNeg,
            Z,
            ZNeg,
        }
        [NMS(Index = 2)]
        /* 0x2C */ public HeadUpAxisEnum HeadUpAxis;
        [NMS(Index = 15)]
        /* 0x30 */ public float MaxFootAngle;
        [NMS(Index = 3)]
        /* 0x34 */ public float MaxHeadPitch;
        [NMS(Index = 4)]
        /* 0x38 */ public float MaxHeadRoll;
        [NMS(Index = 5)]
        /* 0x3C */ public float MaxHeadYaw;
        [NMS(Index = 9)]
        /* 0x40 */ public float MovementDamp;
        [NMS(Index = 7)]
        /* 0x44 */ public float Omega;
        [NMS(Index = 8)]
        /* 0x48 */ public float OmegaDropOff;
        [NMS(Index = 17)]
        /* 0x4C */ public bool Mech;
        [NMS(Index = 13)]
        /* 0x4D */ public bool UseFootAngle;
        [NMS(Index = 11)]
        /* 0x4E */ public bool UseFootGlue;
        [NMS(Index = 10)]
        /* 0x4F */ public bool UseFootRaycasts;
        [NMS(Index = 16)]
        /* 0x50 */ public bool UsePistons;
    }
}
