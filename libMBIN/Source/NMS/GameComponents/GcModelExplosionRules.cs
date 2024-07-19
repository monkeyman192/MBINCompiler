using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x66531AE847CB821C, NameHash = 0xE59ABC9B)]
    public class GcModelExplosionRules : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public List<GcModelExplosionRule> Rules;
        [NMS(Index = 2, Size = 0xA, EnumType = typeof(GcSpaceshipClasses.ShipClassEnum))]
        /* 0x10 */ public float[] ShipSalvageDisplayScales;
        [NMS(Index = 1, Size = 0xA, EnumType = typeof(GcSpaceshipClasses.ShipClassEnum))]
        /* 0x38 */ public bool[] UseRules;
    }
}
