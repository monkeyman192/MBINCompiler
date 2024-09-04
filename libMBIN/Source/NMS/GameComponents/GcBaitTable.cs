using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x82C9FED3492EFBE, NameHash = 0x56721919)]
    public class GcBaitTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcBaitData> Bait;
    }
}
