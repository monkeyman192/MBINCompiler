using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5B87C6C3D6899DFA, NameHash = 0xFADF3E5CAB7333FF)]
    public class GcJourney : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcJourneyCategory> Categories;
    }
}
