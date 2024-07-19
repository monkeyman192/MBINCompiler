using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3C00B7432CD98DD0, NameHash = 0xD9D02175)]
    public class GcCostFleetStoredIncome : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcFrigateClass Class;
        [NMS(Index = 1)]
        /* 0x4 */ public int RequiredAmount;
    }
}
