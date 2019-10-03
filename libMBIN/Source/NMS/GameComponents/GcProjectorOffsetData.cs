using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x70, GUID = 0xB560F06E5F3D3F59, NameHash = 0xB9DD91F357A56979)]
    public class GcProjectorOffsetData : NMSTemplate
    {
        public float Scale;
        [NMS(Size = 0xC, Ignore = true)]
        public byte[] Padding4;
        public GcInWorldUIScreenData Active;
        public GcInWorldUIScreenData Inactive;
    }
}
