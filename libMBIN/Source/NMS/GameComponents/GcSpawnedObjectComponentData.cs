using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x119B8BC3DF2A39FA, NameHash = 0x7B019C2E35255293)]
    public class GcSpawnedObjectComponentData : NMSTemplate
    {
        public bool CanBeTeleported;
    }
}