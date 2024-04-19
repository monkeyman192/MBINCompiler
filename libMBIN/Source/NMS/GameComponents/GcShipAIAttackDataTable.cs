using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6F42C726DA6DDA51, NameHash = 0xC501980088063B)]
    public class GcShipAIAttackDataTable : NMSTemplate
    {
        [NMS(Size = 0x4, EnumType = typeof(GcWealthClass.WealthClassEnum))]
        /* 0x00 */ public NMSString0x10[] TraderAttackLookup;
        /* 0x40 */ public List<GcShipAIAttackData> BehaviourTable;
        /* 0x50 */ public List<GcShipAICombatDefinition> Definitions;
        /* 0x60 */ public List<GcSpaceshipTravelData> EngineTable;
        /* 0x70 */ public List<GcSpaceshipShieldData> ShieldTable;
    }
}
