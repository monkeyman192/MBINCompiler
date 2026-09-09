namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x50E030B390546454, NameHash = 0x6041C794)]
    public class TkNavMeshVelocitySamplingParams : NMSTemplate
    {
        [NMS(Index = 13)]
        /* 0x00 */ public uint AdaptiveDepths;
        [NMS(Index = 11)]
        /* 0x04 */ public uint AdaptiveDivs;
        [NMS(Index = 12)]
        /* 0x08 */ public uint AdaptiveRings;
        [NMS(Index = 14)]
        /* 0x0C */ public uint GridSize;
        [NMS(Index = 9)]
        /* 0x10 */ public float HorizonTime;
        [NMS(Index = 0)]
        /* 0x14 */ public float VelocityBias;
        [NMS(Index = 8)]
        /* 0x18 */ public float WeightClearance;
        [NMS(Index = 7)]
        /* 0x1C */ public float WeightCollisionTime;
        [NMS(Index = 4)]
        /* 0x20 */ public float WeightCurVel;
        [NMS(Index = 3)]
        /* 0x24 */ public float WeightDesiredVel;
        [NMS(Index = 2)]
        /* 0x28 */ public float WeightEnergyCost;
        [NMS(Index = 5)]
        /* 0x2C */ public float WeightFacingDir;
        [NMS(Index = 1)]
        /* 0x30 */ public float WeightProgress;
        [NMS(Index = 6)]
        /* 0x34 */ public float WeightSide;
        // size: 0x2
        public enum SamplingTypeEnum : byte {
            Adaptive,
            Grid,
        }
        [NMS(Index = 10)]
        /* 0x38 */ public SamplingTypeEnum SamplingType;
    }
}
