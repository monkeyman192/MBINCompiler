using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x6AA447716F6C436, NameHash = 0x340529EE9BE0F315)]
    public class GcNPCHabitationComponentData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string NPCSpawnLocator;

        public GcNPCHabitationType NPCHabitationType;
    }
}
