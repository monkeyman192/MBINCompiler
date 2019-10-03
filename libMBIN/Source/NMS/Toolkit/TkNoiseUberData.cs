using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x40, GUID = 0x55BA4726F9A4A05D, NameHash = 0xA720068E4459862)]
    public class TkNoiseUberData : NMSTemplate
    {
        /* 0x00 */ public int Octaves;
        /* 0x04 */ public float SlopeGain;
        /* 0x08 */ public float SlopeBias;
        /* 0x0C */ public float SharpToRoundFeatures;
        /* 0x10 */ public float AmplifyFeatures;
        /* 0x14 */ public float PerturbFeatures;
        /* 0x18 */ public float AltitudeErosion;
        /* 0x1C */ public float RidgeErosion;
        /* 0x20 */ public float SlopeErosion;
        /* 0x24 */ public float Lacunarity;
        /* 0x28 */ public float Gain;
        /* 0x2C */ public float RemapFromMin;
        /* 0x30 */ public float RemapFromMax;
        /* 0x34 */ public float RemapToMin;
        /* 0x38 */ public float RemapToMax;
		public enum DebugNoiseTypeEnum { Plane, Check, Sine, Uber }
		public DebugNoiseTypeEnum DebugNoiseType;
    }
}
