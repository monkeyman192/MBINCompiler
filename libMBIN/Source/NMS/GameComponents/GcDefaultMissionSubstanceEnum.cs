using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x751F47F5E80735E, NameHash = 0x1BAC8ECF2C7CC8FC)]
    public class GcDefaultMissionSubstanceEnum : NMSTemplate
    {
		public enum DefaultSubstanceTypeEnum { None, PrimarySubstance, SecondarySubstance }
		public DefaultSubstanceTypeEnum DefaultSubstanceType;
    }
}
