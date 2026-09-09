using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF3FC7DCE44448149, NameHash = 0xC6B4C69F)]
    public class GcSalvageEventData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public TkModelResource Model;
        [NMS(Index = 3)]
        /* 0x20 */ public NMSString0x10 Effect;
        [NMS(Index = 0)]
        /* 0x30 */ public NMSString0x10 Id;
        [NMS(Index = 2)]
        /* 0x40 */ public float Chance;
        [NMS(Index = 5)]
        /* 0x44 */ public int MaxObjsToSpawn;
        [NMS(Index = 4)]
        /* 0x48 */ public int MinObjsToSpawn;
        [NMS(Index = 6)]
        /* 0x4C */ public float SpawnSpread;
    }
}
