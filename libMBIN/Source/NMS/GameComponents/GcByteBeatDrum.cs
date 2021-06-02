using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x58, GUID = 0x6887BA8A0295E6C8, NameHash = 0xAAB4AB6EC567BC2F)]
    public class GcByteBeatDrum : NMSTemplate
    {
        /* 0x00 */ public NMSString0x40 Tree;
        /* 0x40 */ public float Volume;
        /* 0x44 */ public float Duration;
        /* 0x48 */ public float OctaveShift;
        /* 0x4C */ public GcByteBeatEnvelope AttackEnvelope;
        /* 0x50 */ public GcByteBeatEnvelope DecayEnvelope;
        /* 0x54 */ public GcByteBeatWave WaveType;
    }
}
