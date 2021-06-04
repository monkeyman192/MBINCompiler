using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x60, GUID = 0xD7CB6A6690A51D88, NameHash = 0x1B03CB87DECA6BCC)]
    public class GcEnvironmentSpawnData : NMSTemplate
    {
        /* 0x00 */ public List<GcCreatureSpawnData> Creatures;
        /* 0x10 */ public List<GcObjectSpawnData> DistantObjects;
        /* 0x20 */ public List<GcObjectSpawnData> Landmarks;
        /* 0x30 */ public List<GcObjectSpawnData> Objects;
        /* 0x40 */ public List<GcObjectSpawnData> DetailObjects;
        /* 0x50 */ public List<GcSelectableObjectSpawnList> SelectableObjects;
    }
}
