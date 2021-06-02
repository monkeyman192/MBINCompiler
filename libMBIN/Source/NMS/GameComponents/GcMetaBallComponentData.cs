using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xD0, GUID = 0x1D1348AD9F68E484, NameHash = 0xDA00E84E26C162C5)]
    public class GcMetaBallComponentData : NMSTemplate
    {
        /* 0x000 */ public NMSString0x80 File;
        /* 0x080 */ public NMSString0x20 Root;
        /* 0x0A0 */ public float Radius;
        /* 0x0B0 */ public Vector4f MinSize;
        /* 0x0C0 */ public Vector4f MaxSize;
    }
}