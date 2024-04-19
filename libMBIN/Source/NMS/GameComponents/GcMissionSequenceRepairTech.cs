using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x968BA03C12A75A61, NameHash = 0xF83A832D3507037F)]
    public class GcMissionSequenceRepairTech : NMSTemplate
    {
        /* 0x00 */ public List<NMSString0x10> TechsToRepair;
        /* 0x10 */ public NMSString0x80 DebugText;
        /* 0x90 */ public NMSString0x80 Message;
    }
}
