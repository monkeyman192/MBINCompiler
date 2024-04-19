using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8CE0334F5701E7E7, NameHash = 0x741554C15123D097)]
    public class GcCreatureFullBodyIKComponentData : NMSTemplate
    {
        /* 0x00 */ public List<GcCreatureIkData> JointData;
        /* 0x10 */ public List<GcIkPistonData> PistonData;
        /* 0x20 */ public float BodyMassWeight;
        /* 0x24 */ public float FootAngleSpeed;
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
        /* 0x2C */ public HeadUpAxisEnum HeadUpAxis;
        /* 0x30 */ public float MaxFootAngle;
        /* 0x34 */ public float MaxHeadPitch;
        /* 0x38 */ public float MaxHeadRoll;
        /* 0x3C */ public float MaxHeadYaw;
        /* 0x40 */ public float MovementDamp;
        /* 0x44 */ public float Omega;
        /* 0x48 */ public float OmegaDropOff;
        /* 0x4C */ public bool Mech;
        /* 0x4D */ public bool UseFootAngle;
        /* 0x4E */ public bool UseFootGlue;
        /* 0x4F */ public bool UseFootRaycasts;
        /* 0x50 */ public bool UsePistons;
    }
}
