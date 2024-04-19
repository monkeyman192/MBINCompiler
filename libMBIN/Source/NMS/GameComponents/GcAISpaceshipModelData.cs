using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC56C33DA8B63CF8D, NameHash = 0xA1AD260BA61A04EE)]
    public class GcAISpaceshipModelData : NMSTemplate
    {
        /* 0x0 */ public GcAISpaceshipRoles AIRole;
        /* 0x4 */ public GcSpaceshipClasses Class;
        /* 0x8 */ public GcFrigateClass FrigateClass;
        /* 0xC */ public NMSString0x80 Filename;
    }
}
