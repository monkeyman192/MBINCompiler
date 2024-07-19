using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x15FD454F79A2FCA9, NameHash = 0xDC8CEC5A)]
    public class GcWFCDecorationSet : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcWFCDecorationItem> Items;
    }
}
