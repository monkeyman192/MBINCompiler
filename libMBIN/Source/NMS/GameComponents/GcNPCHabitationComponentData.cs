using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFF711CE044F84310, NameHash = 0xBDFDEA25)]
    public class GcNPCHabitationComponentData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 NPCSpawnLocator;
        [NMS(Index = 1)]
        /* 0x10 */ public GcNPCHabitationType NPCHabitationType;
    }
}
