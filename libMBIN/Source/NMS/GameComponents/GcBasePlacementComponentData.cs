using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE91C013B0484F99E, NameHash = 0xBA4C53DBACF34B41)]
    public class GcBasePlacementComponentData : NMSTemplate
    {
        public List<GcBasePlacementRule> Rules;
    }
}
