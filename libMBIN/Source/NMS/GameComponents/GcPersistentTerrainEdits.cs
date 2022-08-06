using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x24AFDEE56923EAD3, NameHash = 0xC6506D02A6391EEB)]
    public class GcPersistentTerrainEdits : NMSTemplate
    {
        public ulong GalacticAddress;
        public List<int> BufferSizes;
        public List<Vector3f> BufferAnchors;
        public List<GcTerrainEdit> Edits;       // just a guess... Don't think any structs use this...
    }
}
