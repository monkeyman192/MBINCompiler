using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xE7279B8D8F4A2E2C, NameHash = 0x2B250A75A37497B9)]
    public class GcProceduralProductDeployable : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 BaseID;
        /* 0x10 */ public int Variants;
    }
}
