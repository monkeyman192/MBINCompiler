using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC14BF7ED102A75DF, NameHash = 0x9D866220)]
    public class GcTechnologyTypes : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcTechnology> Technology;
    }
}
