using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEA103B6799D7024D, NameHash = 0x7A1015F7)]
    public class GcFishingRodTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public VariableSizeString FishingRodResource;
        [NMS(Index = 1)]
        /* 0x10 */ public List<GcFishingRodData> FishingRods;
    }
}
