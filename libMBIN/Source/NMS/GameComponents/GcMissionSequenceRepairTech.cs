using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5C361668AA87F229, NameHash = 0xB9BA9B9A)]
    public class GcMissionSequenceRepairTech : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public VariableSizeString DebugText;
        [NMS(Index = 0)]
        /* 0x10 */ public VariableSizeString Message;
        [NMS(Index = 1)]
        /* 0x20 */ public List<NMSString0x10> TechsToRepair;
    }
}
