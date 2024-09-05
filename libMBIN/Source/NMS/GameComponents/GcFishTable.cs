using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x91E17C74A6968B57, NameHash = 0x8C266C57)]
    public class GcFishTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcFishData> Fish;
    }
}
