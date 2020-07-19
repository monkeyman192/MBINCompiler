using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x88, GUID = 0x455421BA61AB44, NameHash = 0x787641F134B1AFBD)]
    public class TkCreatureTailComponentData : NMSTemplate
    {
        /* 0x00 */ public GcPrimaryAxis LengthAxis;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x04 */ public byte[] Padding4;
        /* 0x08 */ public TkCreatureTailParams DefaultParams;
        /* 0x78 */ public List<TkCreatureTailParams> ParamVariations;
    }
}