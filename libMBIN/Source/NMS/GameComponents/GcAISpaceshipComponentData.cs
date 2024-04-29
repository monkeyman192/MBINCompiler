using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x162F095BB5A96B7B, NameHash = 0x4F5433BCFC028B49)]
    public class GcAISpaceshipComponentData : NMSTemplate
    {
        [NMS(Index = 5)]
        /* 0x00 */ public NMSString0x10 CombatDefinitionID;
        [NMS(Index = 3)]
        /* 0x10 */ public TkModelResource Hangar;
        [NMS(Index = 2)]
        /* 0x94 */ public GcPrimaryAxis Axis;
        [NMS(Index = 1)]
        /* 0x98 */ public GcSpaceshipClasses Class;
        [NMS(Index = 0)]
        /* 0x9C */ public GcAISpaceshipTypes Type;
        [NMS(Index = 4)]
        /* 0xA0 */ public bool IsSpaceAnomaly;
    }
}
