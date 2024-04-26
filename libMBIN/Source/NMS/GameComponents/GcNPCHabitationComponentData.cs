using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x604F221F03B0371, NameHash = 0x340529EE9BE0F315)]
    public class GcNPCHabitationComponentData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 NPCSpawnLocator;
        [NMS(Index = 1)]
        /* 0x10 */ public GcNPCHabitationType NPCHabitationType;
    }
}
