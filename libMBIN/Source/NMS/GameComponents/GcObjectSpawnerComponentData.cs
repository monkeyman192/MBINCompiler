using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x668542673C3E202F, NameHash = 0x8EEA012026874C5C)]
    public class GcObjectSpawnerComponentData : NMSTemplate
    {
        /* 0x00 */ public TkModelResource Object;
        /* 0x84 */ public float SpawnCooldown;
        /* 0x88 */ public int SpawnPowerCost;
    }
}
