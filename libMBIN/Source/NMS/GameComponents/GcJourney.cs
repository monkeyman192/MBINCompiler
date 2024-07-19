using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4FF29BD54D19A6FA, NameHash = 0x7249CADC)]
    public class GcJourney : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcJourneyCategory> Categories;
    }
}
