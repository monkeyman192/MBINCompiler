namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFA9FDFB429B83B04, NameHash = 0x4F19AB09)]
    public class GcSwarmData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Id;
        [NMS(Index = 9)]
        /* 0x10 */ public float Alignment;
        [NMS(Index = 20)]
        /* 0x14 */ public float AreaMarginLower;
        [NMS(Index = 21)]
        /* 0x18 */ public float AreaMarginUpper;
        [NMS(Index = 8)]
        /* 0x1C */ public float Coherence;
        [NMS(Index = 2)]
        /* 0x20 */ public int CountMax;
        [NMS(Index = 1)]
        /* 0x24 */ public int CountMin;
        [NMS(Index = 28)]
        /* 0x28 */ public float FadeDistance;
        [NMS(Index = 6)]
        /* 0x2C */ public float Follow;
        [NMS(Index = 23)]
        /* 0x30 */ public float FollowArriveRange;
        [NMS(Index = 22)]
        /* 0x34 */ public float FollowHeight;
        [NMS(Index = 24)]
        /* 0x38 */ public float FollowOrbitRadius;
        [NMS(Index = 26)]
        /* 0x3C */ public float FollowOrbitSpeed;
        // size: 0x2
        public enum FollowPathTypeEnum : uint {
            Area,
            Circle,
        }
        [NMS(Index = 27)]
        /* 0x40 */ public FollowPathTypeEnum FollowPathType;
        [NMS(Index = 7)]
        /* 0x44 */ public float FollowSpeed;
        [NMS(Index = 15)]
        /* 0x48 */ public float InfluenceRange;
        [NMS(Index = 14)]
        /* 0x4C */ public float MaxSpeed;
        [NMS(Index = 18)]
        /* 0x50 */ public float MaxTorque;
        [NMS(Index = 13)]
        /* 0x54 */ public float MinSpeed;
        [NMS(Index = 12)]
        /* 0x58 */ public float Momentum;
        [NMS(Index = 4)]
        /* 0x5C */ public float ScaleVarianceMax;
        [NMS(Index = 3)]
        /* 0x60 */ public float ScaleVarianceMin;
        [NMS(Index = 11)]
        /* 0x64 */ public float Separation;
        [NMS(Index = 10)]
        /* 0x68 */ public float Spacing;
        // size: 0x4
        public enum SwarmMovementAreaEnum : uint {
            Underwater,
            Air,
            Ground,
            Space,
        }
        [NMS(Index = 19)]
        /* 0x6C */ public SwarmMovementAreaEnum SwarmMovementArea;
        [NMS(Index = 16)]
        /* 0x70 */ public float TurnRollAngle;
        [NMS(Index = 17)]
        /* 0x74 */ public float TurnStrength;
        [NMS(Index = 25)]
        /* 0x78 */ public bool FollowOrbitUseBounds;
        [NMS(Index = 5)]
        /* 0x79 */ public bool StartLanded;
    }
}
