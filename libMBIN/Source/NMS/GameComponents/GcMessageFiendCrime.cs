using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x20, GUID = 0x5873ED86AF6E466E, NameHash = 0x37D134945C6DC0E)]
    public class GcMessageFiendCrime : NMSTemplate
    {
        /* 0x00 */ public Vector3f Positon;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x10 */ public byte[] Padding10;  // Not sure why this padding is needed. Maybe an internal field?
        /* 0x14 */ public GcFiendCrime FiendCrimeType;
        /* 0x18 */ public float Value;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x1C */ public byte[] EndPadding;
    }
}
