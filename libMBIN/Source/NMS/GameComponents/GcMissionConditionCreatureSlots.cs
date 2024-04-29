using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEA80EABC161073DE, NameHash = 0x1BD168A44ADE2D95)]
    public class GcMissionConditionCreatureSlots : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public int CreatureSlots;
        [NMS(Index = 2)]
        /* 0x4 */ public TkEqualityEnum Test;
        [NMS(Index = 1)]
        /* 0x8 */ public bool OnlyCountFreeSlots;
    }
}
