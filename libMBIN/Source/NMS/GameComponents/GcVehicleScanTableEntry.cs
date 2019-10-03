using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xC8, GUID = 0x37F6B86B46BC4BDD, NameHash = 0xBAC942D350F478B1)]
    public class GcVehicleScanTableEntry : NMSTemplate
    {
        
        /* 0x00 */ public List<NMSString0x20> ScanList;
        [NMS(Size = 0x20)]
        /* 0x10 */ public string Name;
        [NMS(Size = 0x10)]
        /* 0x30 */ public string RequiredTech;
        /* 0x40 */ public TkTextureResource Icon;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0xC4 */ public byte[] EndPadding;
    }
}