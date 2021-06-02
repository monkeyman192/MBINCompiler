using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x40, GUID = 0x22CB6BAAB2AFDCD6, NameHash = 0xAF919B46C646D940)]
    public class GcVibrationChannelData : NMSTemplate
    {
        public NMSString0x10 Id;
        public enum SideEnum { Left, Right };
        [NMS(Size = 0x2, EnumType = typeof(SideEnum))]
        public GcVibrationData[] Data;
    }
}
