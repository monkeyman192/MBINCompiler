using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x5919458DC143C31C, NameHash = 0xE1E4B793)]
    public class TkNavMeshAreaGroup : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public List<TkNavMeshAreaType> Areas;
        [NMS(Index = 0)]
        /* 0x10 */ public NMSString0x10 GroupId;
    }
}
