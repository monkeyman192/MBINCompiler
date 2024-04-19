using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x38F8BA7B7D94CFC6, NameHash = 0x787641F134B1AFBD)]
    public class TkCreatureTailComponentData : NMSTemplate
    {
        /* 0x00 */ public TkCreatureTailParams DefaultParams;
        /* 0x70 */ public List<TkCreatureTailParams> ParamVariations;
        /* 0x80 */ public GcPrimaryAxis LengthAxis;
        /* 0x84 */ public bool CanUseDefaultParams;
    }
}
