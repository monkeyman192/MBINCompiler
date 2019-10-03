using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x30, GUID = 0x1E6D02062E36E3D, NameHash = 0xFFAAB9AB630ACB70)]
    public class GcInWorldUIScreenData : NMSTemplate
    {
        public float ScreenScale;
        public Vector3f ScreenOffset;
        public Vector3f ScreenRotation;
    }
}
