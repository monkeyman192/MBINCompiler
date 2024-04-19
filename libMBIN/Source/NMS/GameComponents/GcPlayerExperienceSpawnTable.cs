using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD9E830C7BE45A916, NameHash = 0xA1B202DE9A10A705)]
    public class GcPlayerExperienceSpawnTable : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Event;
        /* 0x10 */ public List<GcPlayerExperienceSpawnData> Spawns;
        // size: 0x2
        public enum ExperienceSpawnTypeEnum : uint {
            Freighter,
            Mission,
        }
        /* 0x20 */ public ExperienceSpawnTypeEnum ExperienceSpawnType;
        /* 0x24 */ public float PerSpawnDelay;
        /* 0x28 */ public float ResponseRate;
        /* 0x2C */ public bool Destroy;
    }
}
