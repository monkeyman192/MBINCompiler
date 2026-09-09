using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x137E11DBB61AFEEB, NameHash = 0x141119D1)]
    public class GcSwarmDataTable : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public List<GcSwarmResource> Resources;
        [NMS(Index = 0)]
        /* 0x10 */ public List<GcSwarmData> Table;
    }
}
