using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9E75B6A4E4541190, NameHash = 0x9D866220)]
    public class GcTechnologyTypes : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcTechnology> Technology;
    }
}
