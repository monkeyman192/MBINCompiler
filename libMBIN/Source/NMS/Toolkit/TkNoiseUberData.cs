namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xBC6530CC576628F9, NameHash = 0xEBC6EB93)]
    public class TkNoiseUberData : NMSTemplate
    {
        [NMS(Index = 6)]
        /* 0x00 */ public float AltitudeErosion;
        [NMS(Index = 4)]
        /* 0x04 */ public float AmplifyFeatures;
        // size: 0x4
        public enum DebugNoiseTypeEnum : uint {
            Plane,
            Check,
            Sine,
            Uber,
        }
        [NMS(Index = 15)]
        /* 0x08 */ public DebugNoiseTypeEnum DebugNoiseType;
        [NMS(Index = 10)]
        /* 0x0C */ public float Gain;
        [NMS(Index = 9)]
        /* 0x10 */ public float Lacunarity;
        [NMS(Index = 0)]
        /* 0x14 */ public int Octaves;
        [NMS(Index = 5)]
        /* 0x18 */ public float PerturbFeatures;
        [NMS(Index = 12)]
        /* 0x1C */ public float RemapFromMax;
        [NMS(Index = 11)]
        /* 0x20 */ public float RemapFromMin;
        [NMS(Index = 14)]
        /* 0x24 */ public float RemapToMax;
        [NMS(Index = 13)]
        /* 0x28 */ public float RemapToMin;
        [NMS(Index = 7)]
        /* 0x2C */ public float RidgeErosion;
        [NMS(Index = 3)]
        /* 0x30 */ public float SharpToRoundFeatures;
        [NMS(Index = 2)]
        /* 0x34 */ public float SlopeBias;
        [NMS(Index = 8)]
        /* 0x38 */ public float SlopeErosion;
        [NMS(Index = 1)]
        /* 0x3C */ public float SlopeGain;
    }
}
