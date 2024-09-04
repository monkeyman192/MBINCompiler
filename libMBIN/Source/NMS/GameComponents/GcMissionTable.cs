using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x509A1E714BFF88D4, NameHash = 0x4E2556EB)]
    public class GcMissionTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcGenericMissionSequence> Missions;
    }
}
