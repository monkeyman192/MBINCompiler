using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8C39235EBFEC39E6, NameHash = 0x20FFEA13)]
    public class GcId256List : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x20A Id;
        [NMS(Index = 1)]
        /* 0x20 */ public List<NMSString0x20A> IdList;
    }
}
