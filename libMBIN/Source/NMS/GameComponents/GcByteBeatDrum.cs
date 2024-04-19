using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF8AAFC9337502934, NameHash = 0xAAB4AB6EC567BC2F)]
    public class GcByteBeatDrum : NMSTemplate
    {
        /* 0x00 */ public GcByteBeatEnvelope AttackEnvelope;
        // size: 0x3
        public enum AugmentModeEnum : uint {
            Add,
            Multiply,
            Max,
        }
        /* 0x04 */ public AugmentModeEnum AugmentMode;
        /* 0x08 */ public float AugmentOverdrive;
        /* 0x0C */ public float AugmentPitch;
        /* 0x10 */ public float AugmentPitchFalloff;
        /* 0x14 */ public float AugmentPitchFalloffPower;
        /* 0x18 */ public float AugmentSineNoiseMix;
        /* 0x1C */ public float AugmentVolume;
        /* 0x20 */ public GcByteBeatEnvelope DecayEnvelope;
        /* 0x24 */ public float Duration;
        /* 0x28 */ public float OctaveShift;
        /* 0x2C */ public float Volume;
        /* 0x30 */ public GcByteBeatWave WaveType;
        /* 0x34 */ public NMSString0x40 Tree;
    }
}
