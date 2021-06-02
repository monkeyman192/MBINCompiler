using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x108, GUID = 0x0350697CF0829EFA, NameHash = 0x00368D06565D9CC1)]
    public class GcMissionSequenceDiscoverOnPlanet : NMSTemplate
    {
        /* 0x00 */ public float PercentToDiscover;
        /* 0x04 */ public NMSString0x80 Message;
        public enum DiscoverTargetOnThisPlanetEnum { Animal, Vegetable, Mineral };
        /* 0x84 */ public DiscoverTargetOnThisPlanetEnum DiscoverTargetOnThisPlanet;
        /* 0x88 */ public NMSString0x80 DebugText;
    }
}
