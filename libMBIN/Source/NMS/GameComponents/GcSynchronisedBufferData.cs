using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7D116C09DC740F48, NameHash = 0xBBC409)]
    public class GcSynchronisedBufferData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<ulong> Data;
    }
}
