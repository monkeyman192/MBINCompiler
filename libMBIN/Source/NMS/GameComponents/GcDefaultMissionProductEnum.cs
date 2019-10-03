using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xAD7818FB633DD38, NameHash = 0x20AE1E70418EDA80)]
    public class GcDefaultMissionProductEnum : NMSTemplate
    {
		public enum DefaultProductTypeEnum { None, PrimaryProduct, SecondaryProduct }
		public DefaultProductTypeEnum DefaultProductType;
    }
}
