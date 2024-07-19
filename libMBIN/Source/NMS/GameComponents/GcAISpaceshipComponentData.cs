using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x47D4F370B8829E7B, NameHash = 0xC674FA39)]
    public class GcAISpaceshipComponentData : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public TkModelResource Hangar;
        [NMS(Index = 5)]
        /* 0x18 */ public NMSString0x10 CombatDefinitionID;
        [NMS(Index = 2)]
        /* 0x28 */ public GcPrimaryAxis Axis;
        [NMS(Index = 1)]
        /* 0x2C */ public GcSpaceshipClasses Class;
        [NMS(Index = 0)]
        /* 0x30 */ public GcAISpaceshipTypes Type;
        [NMS(Index = 4)]
        /* 0x34 */ public bool IsSpaceAnomaly;
    }
}
