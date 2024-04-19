using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9A5A7905B97ECC83, NameHash = 0x1BD168A44ADE2D95)]
    public class GcMissionConditionCreatureSlots : NMSTemplate
    {
        /* 0x0 */ public int CreatureSlots;
        /* 0x4 */ public TkEqualityEnum Test;
        /* 0x8 */ public bool OnlyCountFreeSlots;
    }
}
