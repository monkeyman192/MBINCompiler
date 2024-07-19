using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE83398D39919816C, NameHash = 0xF8F1B5FB)]
    public class GcObjectSpawnerComponentData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public TkModelResource Object;
        [NMS(Index = 2)]
        /* 0x18 */ public float SpawnCooldown;
        [NMS(Index = 1)]
        /* 0x1C */ public int SpawnPowerCost;
    }
}
