using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x52D48301CBD7C1B4, NameHash = 0x806D4C2B)]
    public class GcByteBeatDrum : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x00 */ public GcByteBeatEnvelope AttackEnvelope;
        // size: 0x3
        public enum AugmentModeEnum : uint {
            Add,
            Multiply,
            Max,
        }
        [NMS(Index = 13)]
        /* 0x04 */ public AugmentModeEnum AugmentMode;
        [NMS(Index = 8)]
        /* 0x08 */ public float AugmentOverdrive;
        [NMS(Index = 10)]
        /* 0x0C */ public float AugmentPitch;
        [NMS(Index = 11)]
        /* 0x10 */ public float AugmentPitchFalloff;
        [NMS(Index = 12)]
        /* 0x14 */ public float AugmentPitchFalloffPower;
        [NMS(Index = 9)]
        /* 0x18 */ public float AugmentSineNoiseMix;
        [NMS(Index = 7)]
        /* 0x1C */ public float AugmentVolume;
        [NMS(Index = 5)]
        /* 0x20 */ public GcByteBeatEnvelope DecayEnvelope;
        [NMS(Index = 2)]
        /* 0x24 */ public float Duration;
        [NMS(Index = 3)]
        /* 0x28 */ public float OctaveShift;
        [NMS(Index = 1)]
        /* 0x2C */ public float Volume;
        [NMS(Index = 6)]
        /* 0x30 */ public GcByteBeatWave WaveType;
        [NMS(Index = 0)]
        /* 0x34 */ public NMSString0x40 Tree;
    }
}
