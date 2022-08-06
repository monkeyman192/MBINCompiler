using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x15E41A2902E18EE6, NameHash = 0x2E2A8DE0D58242BF)]
    public class GcSandwormTimerAndFrequencyOverride : NMSTemplate
    {
        /* 0x0 */ public ulong PackedUA;
        /* 0x8 */ public float Timer;
        /* 0xC */ public float SpawnChance;
    }
}
