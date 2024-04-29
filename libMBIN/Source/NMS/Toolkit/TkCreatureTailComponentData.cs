using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x16BD46EE9EF63BC4, NameHash = 0x787641F134B1AFBD)]
    public class TkCreatureTailComponentData : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public TkCreatureTailParams DefaultParams;
        [NMS(Index = 3)]
        /* 0x70 */ public List<TkCreatureTailParams> ParamVariations;
        [NMS(Index = 0)]
        /* 0x80 */ public GcPrimaryAxis LengthAxis;
        [NMS(Index = 1)]
        /* 0x84 */ public bool CanUseDefaultParams;
    }
}
