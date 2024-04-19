using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4913303252BDDB86, NameHash = 0xD04C1E382833D93A)]
    public class GcModelExplosionRules : NMSTemplate
    {
        /* 0x00 */ public List<GcModelExplosionRule> Rules;
        [NMS(Size = 0xA, EnumType = typeof(GcSpaceshipClasses.ShipClassEnum))]
        /* 0x10 */ public float[] ShipSalvageDisplayScales;
        [NMS(Size = 0xA, EnumType = typeof(GcSpaceshipClasses.ShipClassEnum))]
        /* 0x38 */ public bool[] UseRules;
    }
}
