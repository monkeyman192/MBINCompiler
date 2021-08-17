using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    [NMS(Size = 0x88, GUID = 0x942933E383D5C9C7, NameHash = 0x787641F134B1AFBD)]
    public class TkCreatureTailComponentData : NMSTemplate
    {
        /* 0x00 */ public GcPrimaryAxis LengthAxis;
        /* 0x04 */ public bool CanUseDefaultParams;
        /* 0x08 */ public TkCreatureTailParams DefaultParams;
        /* 0x78 */ public List<TkCreatureTailParams> ParamVariations;
    }
}
