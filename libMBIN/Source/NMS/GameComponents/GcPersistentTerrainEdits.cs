using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC359CE7CE22DC772, NameHash = 0xC6506D02A6391EEB)]
    public class GcPersistentTerrainEdits : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public List<Vector3f> BufferAnchors;
        [NMS(Index = 1)]
        /* 0x10 */ public List<int> BufferSizes;
        [NMS(Index = 3)]
        /* 0x20 */ public List<GcTerrainEdit> Edits;
        [NMS(Index = 0)]
        /* 0x30 */ public ulong GalacticAddress;
    }
}
