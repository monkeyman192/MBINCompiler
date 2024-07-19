using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x186E4A51915A2FD4, NameHash = 0x184A3B01)]
    public class GcCostBuildingParts : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x20A Description;
        [NMS(Index = 1)]
        /* 0x20 */ public List<GcBuildingCostPartCount> RequiredParts;
    }
}
