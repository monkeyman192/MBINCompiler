using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x75B1338A1741B7FD, NameHash = 0xD2657A8AE39E6E61)]
    public class TkProceduralModelList : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Id;
        [NMS(Index = 1)]
        /* 0x10 */ public List<NMSString0x80> List;
    }
}
