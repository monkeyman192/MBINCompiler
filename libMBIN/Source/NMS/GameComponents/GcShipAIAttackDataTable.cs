using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8DDEBCFB1C0F614D, NameHash = 0x838AEBEE)]
    public class GcShipAIAttackDataTable : NMSTemplate
    {
        [NMS(Index = 4, Size = 0x4, EnumType = typeof(GcWealthClass.WealthClassEnum))]
        /* 0x00 */ public NMSString0x10[] TraderAttackLookup;
        [NMS(Index = 1)]
        /* 0x40 */ public List<GcShipAIAttackData> BehaviourTable;
        [NMS(Index = 0)]
        /* 0x50 */ public List<GcShipAICombatDefinition> Definitions;
        [NMS(Index = 2)]
        /* 0x60 */ public List<GcSpaceshipTravelData> EngineTable;
        [NMS(Index = 3)]
        /* 0x70 */ public List<GcSpaceshipShieldData> ShieldTable;
    }
}
