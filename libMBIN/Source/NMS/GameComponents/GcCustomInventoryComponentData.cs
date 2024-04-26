using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x51AD00284F2D2C83, NameHash = 0xB16E966B1CE41461)]
    public class GcCustomInventoryComponentData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public List<GcInventoryTechProbability> DesiredTechs;
        [NMS(Index = 0)]
        /* 0x10 */ public NMSString0x10 Size;
        [NMS(Index = 2)]
        /* 0x20 */ public bool Cool;
    }
}
