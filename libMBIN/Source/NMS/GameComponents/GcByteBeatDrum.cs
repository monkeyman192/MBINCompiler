using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x74, GUID = 0x39E7DA2C8408A28C, NameHash = 0xAAB4AB6EC567BC2F)]
    public class GcByteBeatDrum : NMSTemplate
    {
        /* 0x00 */ public NMSString0x40 Tree;
        /* 0x40 */ public float Volume;
        /* 0x44 */ public float Duration;
        /* 0x48 */ public float OctaveShift;
        /* 0x4C */ public GcByteBeatEnvelope AttackEnvelope;
        /* 0x50 */ public GcByteBeatEnvelope DecayEnvelope;
        /* 0x54 */ public GcByteBeatWave WaveType;
        /* 0x58 */ public float AugmentVolume;
        /* 0x5C */ public float AugmentOverdrive;
        /* 0x60 */ public float AugmentSineNoiseMix;
        /* 0x64 */ public float AugmentPitch;
        /* 0x68 */ public float AugmentPitchFalloff;
        /* 0x6C */ public float AugmentPitchFalloffPower;
        public enum AugmentModeEnum { Add, Multiply, Max };
        /* 0x70 */ public AugmentModeEnum AugmentMode;
    }
}
