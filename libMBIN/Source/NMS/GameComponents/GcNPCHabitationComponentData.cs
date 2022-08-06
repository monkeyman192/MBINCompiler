using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x06AA447716F6C436, NameHash = 0x340529EE9BE0F315)]
    public class GcNPCHabitationComponentData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 NPCSpawnLocator;
        /* 0x10 */ public GcNPCHabitationType NPCHabitationType;
    }
}
