namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBA5F10A4BCFA5402, NameHash = 0xE11F7108)]
    public class GcSpookFiendSpawnData : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public NMSString0x10 SpawnID;
        [NMS(Index = 4)]
        /* 0x10 */ public int MaxNumSpawns;
        [NMS(Index = 2)]
        /* 0x14 */ public float SpawnChance;
        [NMS(Index = 0)]
        /* 0x18 */ public float ThresholdSpookLevel;
        [NMS(Index = 1)]
        /* 0x1C */ public float TimerAccelerator;
    }
}
