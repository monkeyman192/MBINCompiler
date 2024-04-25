using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x668542673C3E202F, NameHash = 0x8EEA012026874C5C)]
    public class GcObjectSpawnerComponentData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public TkModelResource Object;
        [NMS(Index = 2)]
        /* 0x84 */ public float SpawnCooldown;
        [NMS(Index = 1)]
        /* 0x88 */ public int SpawnPowerCost;
    }
}
