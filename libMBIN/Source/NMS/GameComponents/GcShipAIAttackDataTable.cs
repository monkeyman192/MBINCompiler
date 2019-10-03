using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x600CAC2FB5629419, NameHash = 0xC501980088063B)]
    public class GcShipAIAttackDataTable : NMSTemplate       // size: 0x60
    {
        /* 0x00 */ public List<GcShipAICombatDefinition> Definitions;
        /* 0x10 */ public List<GcShipAIAttackData> BehaviourTable;
        /* 0x20 */ public List<GcSpaceshipTravelData> EngineTable;
        [NMS(Size = 3)]
        /* 0x30 */ public NMSString0x10[] TraderAttackLookup;
    }
}
