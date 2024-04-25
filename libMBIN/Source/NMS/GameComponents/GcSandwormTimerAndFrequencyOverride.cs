namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBE39D72AE1D2F6ED, NameHash = 0x2E2A8DE0D58242BF)]
    public class GcSandwormTimerAndFrequencyOverride : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public ulong PackedUA;
        [NMS(Index = 2)]
        /* 0x8 */ public float SpawnChance;
        [NMS(Index = 1)]
        /* 0xC */ public float Timer;
    }
}
