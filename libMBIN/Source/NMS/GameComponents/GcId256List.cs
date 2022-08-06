using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCE1454356F629FB8, NameHash = 0x19E8AD6BA0D5AB9)]
    public class GcId256List : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A Id;
        /* 0x20 */ public List<NMSString0x20A> IdList;
    }
}
