namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x8ABC1ABB8765470E, NameHash = 0xA720068E4459862)]
    public class TkNoiseUberData : NMSTemplate
    {
        /* 0x00 */ public float AltitudeErosion;
        /* 0x04 */ public float AmplifyFeatures;
        // size: 0x4
        public enum DebugNoiseTypeEnum : uint {
            Plane,
            Check,
            Sine,
            Uber,
        }
        /* 0x08 */ public DebugNoiseTypeEnum DebugNoiseType;
        /* 0x0C */ public float Gain;
        /* 0x10 */ public float Lacunarity;
        /* 0x14 */ public int Octaves;
        /* 0x18 */ public float PerturbFeatures;
        /* 0x1C */ public float RemapFromMax;
        /* 0x20 */ public float RemapFromMin;
        /* 0x24 */ public float RemapToMax;
        /* 0x28 */ public float RemapToMin;
        /* 0x2C */ public float RidgeErosion;
        /* 0x30 */ public float SharpToRoundFeatures;
        /* 0x34 */ public float SlopeBias;
        /* 0x38 */ public float SlopeErosion;
        /* 0x3C */ public float SlopeGain;
    }
}
