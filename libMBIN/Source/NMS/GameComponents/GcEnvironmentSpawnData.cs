using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3266DB9F79DD1A8E, NameHash = 0x1B03CB87DECA6BCC)]
    public class GcEnvironmentSpawnData : NMSTemplate
    {
        /* 0x00 */ public List<GcCreatureSpawnData> Creatures;
        /* 0x10 */ public List<GcObjectSpawnData> DetailObjects;
        /* 0x20 */ public List<GcObjectSpawnData> DistantObjects;
        /* 0x30 */ public List<GcObjectSpawnData> Landmarks;
        /* 0x40 */ public List<GcObjectSpawnData> Objects;
        /* 0x50 */ public List<GcSelectableObjectSpawnList> SelectableObjects;
    }
}
