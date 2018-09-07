using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    public class GcDefaultMissionProductEnum : NMSTemplate
    {
		public enum DefaultProductTypeEnum { None, PrimaryProduct, SecondaryProduct }
		public DefaultProductTypeEnum DefaultProductType;
    }
}
