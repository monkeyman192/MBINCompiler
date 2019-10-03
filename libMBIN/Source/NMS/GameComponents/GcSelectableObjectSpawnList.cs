using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Alignment = 0x8, GUID = 0x311A462F48D3006, NameHash = 0xA8FBF05C737FA4E2)]
    public class GcSelectableObjectSpawnList : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Name;
        public List<GcSelectableObjectSpawnData> Objects;
    }
}
