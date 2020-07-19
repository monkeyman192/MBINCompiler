using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x78, GUID = 0xCE1BDDB6390AC195, NameHash = 0x76E523097495B90)]
    public class GcPlayerExperienceSpawnData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string Archetype;
        [NMS(Size = 0x10)]
        /* 0x10 */ public string AppearAnim;
        [NMS(Size = 0x10)]
        /* 0x20 */ public string SpawnLocator;
        public enum FaceDirEnum { Random, TowardsPlayer, SpawnerAt };
        /* 0x30 */ public FaceDirEnum FaceDir;
        /* 0x34 */ public float MinDist;
        /* 0x38 */ public float MaxDist;
        [NMS(Size = 0x7)]
        /* 0x3C */ public int[] MinNum;
        [NMS(Size = 0x7)]
        /* 0x58 */ public int[] MaxNum;
        /* 0x74 */ public float ActiveTime;
    }
}
