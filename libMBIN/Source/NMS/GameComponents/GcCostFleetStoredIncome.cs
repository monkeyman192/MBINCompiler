using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1DCCD4ED3D803D9F, NameHash = 0x77F73B95EA71A04C)]
    public class GcCostFleetStoredIncome : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcFrigateClass Class;
        [NMS(Index = 1)]
        /* 0x4 */ public int RequiredAmount;
    }
}
