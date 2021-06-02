using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x30, GUID = 0x900EB9C7527F9E30, NameHash = 0xA1B202DE9A10A705)]
    public class GcPlayerExperienceSpawnTable : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Event;
        public enum ExperienceSpawnTypeEnum { Freighter, Mission };
        /* 0x10 */ public ExperienceSpawnTypeEnum ExperienceSpawnType;
        /* 0x14 */ public float ResponseRate;
        /* 0x18 */ public float PerSpawnDelay;
        /* 0x1C */ public bool Destroy;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x1D */ public byte[] Padding1D;
        /* 0x20 */ public List<GcPlayerExperienceSpawnData> Spawns;
    }
}
