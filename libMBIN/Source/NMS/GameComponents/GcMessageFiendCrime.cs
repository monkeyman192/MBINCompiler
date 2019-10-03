using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x20, GUID = 0x5873ED86AF6E466E, NameHash = 0x37D134945C6DC0E)]
    public class GcMessageFiendCrime : NMSTemplate
    {
        public Vector4f Positon;
        public GcFiendCrime FiendCrimeType;
        public float Value;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] EndPadding;
    }
}
