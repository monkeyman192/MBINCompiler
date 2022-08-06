using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xB560F06E5F3D3F59, NameHash = 0xB9DD91F357A56979)]
    public class GcProjectorOffsetData : NMSTemplate
    {
        public float Scale;
        public GcInWorldUIScreenData Active;
        public GcInWorldUIScreenData Inactive;
    }
}
