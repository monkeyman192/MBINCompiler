using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    public class GcDefaultMissionSubstanceEnum : NMSTemplate
    {
		public enum DefaultSubstanceTypeEnum { None, PrimarySubstance, SecondarySubstance }
		public DefaultSubstanceTypeEnum DefaultSubstanceType;
    }
}
