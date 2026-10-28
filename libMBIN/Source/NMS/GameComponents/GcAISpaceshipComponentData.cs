using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB4D108704E701F3D, NameHash = 0xC674FA39)]
    public class GcAISpaceshipComponentData : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public TkModelResource Hangar;
        [NMS(Index = 6)]
        /* 0x20 */ public NMSString0x10 CombatDefinitionID;
        [NMS(Index = 2)]
        /* 0x30 */ public GcPrimaryAxis Axis;
        [NMS(Index = 1)]
        /* 0x34 */ public GcSpaceshipClasses Class;
        [NMS(Index = 0)]
        /* 0x38 */ public GcAISpaceshipTypes Type;
        [NMS(Index = 4)]
        /* 0x3C */ public bool IsSpaceAnomaly;
        [NMS(Index = 5)]
        /* 0x3D */ public bool IsUnarmed;
    }
}
