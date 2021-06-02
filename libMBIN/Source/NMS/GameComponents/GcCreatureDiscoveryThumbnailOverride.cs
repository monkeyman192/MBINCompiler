using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x40, GUID = 0xE51870A924FB0FD7, NameHash = 0xF81E00514EB73ED9)]
    public class GcCreatureDiscoveryThumbnailOverride : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20 ContainsDescriptor;
        /* 0x20 */ public float DiscoveryUIScaler;
        /* 0x30 */ public Vector3f DiscoveryUIOffset;
    }
}
