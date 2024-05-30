using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9BB0FD2A1DEAF2A2, NameHash = 0x40154165764DAC5)]
    public class GcPlayerDamageTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcPlayerDamageData> DamageTable;
    }
}
