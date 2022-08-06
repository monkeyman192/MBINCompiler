using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9E330B2FB618842F, NameHash = 0xC9CDB8F662EAE0B2)]
    public class GcBaseBuildingEntryGroup : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Group;
        /* 0x10 */ public NMSString0x10 SubGroupName;
        /* 0x20 */ public int SubGroup;
    }
}
