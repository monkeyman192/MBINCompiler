using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x28, GUID = 0xF032A4340F8381ED, NameHash = 0xCA4D2B1DC7089D9D)]
    public class GcRewardActivateCorruptedDrone : NMSTemplate
    {
        [NMS(Size = 0x20)]
        /* 0x00 */ public string EncounterComponentScanEvent;
        /* 0x20 */ public float SummonRadius;
        /* 0x24 */ public int GuardsToSpawn;
    }
}
