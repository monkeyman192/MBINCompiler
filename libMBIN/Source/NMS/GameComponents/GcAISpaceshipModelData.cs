using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x86EF94A1720A3ECA, NameHash = 0xA1AD260BA61A04EE)]
    public class GcAISpaceshipModelData : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x0 */ public GcAISpaceshipRoles AIRole;
        [NMS(Index = 1)]
        /* 0x4 */ public GcSpaceshipClasses Class;
        [NMS(Index = 3)]
        /* 0x8 */ public GcFrigateClass FrigateClass;
        [NMS(Index = 0)]
        /* 0xC */ public NMSString0x80 Filename;
    }
}
