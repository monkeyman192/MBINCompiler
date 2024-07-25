using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE8E33AB63FFF9582, NameHash = 0x1C40312)]
    public class GcCreatureCrystalMovementData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcCreatureCrystalMovementDataParams> Params;
    }
}
