using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6814616335D981C2, NameHash = 0x518EE963)]
    public class GcCreatureFullBodyIKComponentData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public List<GcCreatureIkData> JointData;
        [NMS(Index = 1)]
        /* 0x10 */ public List<GcIkPistonData> PistonData;
        [NMS(Index = 6)]
        /* 0x20 */ public float BodyMassWeight;
        [NMS(Index = 22)]
        /* 0x24 */ public float BodyPlannerMaxHeight;
        [NMS(Index = 23)]
        /* 0x28 */ public float BodyPlannerMaxPitch;
        [NMS(Index = 21)]
        /* 0x2C */ public float BodyPlannerMaxReach;
        [NMS(Index = 24)]
        /* 0x30 */ public float BodyPlannerMaxRoll;
        [NMS(Index = 26)]
        /* 0x34 */ public float BodyPlannerMeanHeightWeight;
        [NMS(Index = 27)]
        /* 0x38 */ public float BodyPlannerPivotBlend;
        [NMS(Index = 25)]
        /* 0x3C */ public float BodyPlannerResponseTime;
        [NMS(Index = 20)]
        /* 0x40 */ public float BodyPlannerTargetReach;
        [NMS(Index = 16)]
        /* 0x44 */ public float FootAngleSpeed;
        [NMS(Index = 12)]
        /* 0x48 */ public float FootPlantSpringTime;
        [NMS(Index = 18)]
        /* 0x4C */ public float FootTargetMaxReach;
        [NMS(Index = 13)]
        /* 0x50 */ public float FootTerrainHeightSmoothTime;
        [NMS(Index = 17)]
        /* 0x54 */ public float MaxFootAngle;
        [NMS(Index = 2)]
        /* 0x58 */ public float MaxHeadPitch;
        [NMS(Index = 3)]
        /* 0x5C */ public float MaxHeadRoll;
        [NMS(Index = 4)]
        /* 0x60 */ public float MaxHeadYaw;
        [NMS(Index = 28)]
        /* 0x64 */ public float MinLegJointMass;
        [NMS(Index = 9)]
        /* 0x68 */ public float MovementDamp;
        [NMS(Index = 7)]
        /* 0x6C */ public float Omega;
        [NMS(Index = 8)]
        /* 0x70 */ public float OmegaDropOff;
        [NMS(Index = 30)]
        /* 0x74 */ public bool Mech;
        [NMS(Index = 19)]
        /* 0x75 */ public bool UseBodyPlanner;
        [NMS(Index = 15)]
        /* 0x76 */ public bool UseFootAngle;
        [NMS(Index = 11)]
        /* 0x77 */ public bool UseFootGlue;
        [NMS(Index = 10)]
        /* 0x78 */ public bool UseFootRaycasts;
        [NMS(Index = 14)]
        /* 0x79 */ public bool UseFootTerrainPlane;
        [NMS(Index = 5)]
        /* 0x7A */ public bool UseHeadPosition;
        [NMS(Index = 29)]
        /* 0x7B */ public bool UsePistons;
    }
}
