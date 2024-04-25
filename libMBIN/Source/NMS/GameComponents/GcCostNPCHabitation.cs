using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x967AAA5F1ABBD644, NameHash = 0x6FDD00442DB9926C)]
    public class GcCostNPCHabitation : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcNPCHabitationType NPCHabitationType;
        [NMS(Index = 1)]
        /* 0x4 */ public bool MustBeInhabited;
    }
}
