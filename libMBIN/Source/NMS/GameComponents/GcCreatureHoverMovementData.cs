using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2FF4484161DC2C44, NameHash = 0xFA76C7A4963051DC)]
    public class GcCreatureHoverMovementData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcCreatureHoverMovementDataParams> Params;
    }
}
