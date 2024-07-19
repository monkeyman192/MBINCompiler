using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDDDA0867EFD27CB2, NameHash = 0x1717CCB7)]
    public class GcCostNPCHabitation : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcNPCHabitationType NPCHabitationType;
        [NMS(Index = 1)]
        /* 0x4 */ public bool MustBeInhabited;
    }
}
