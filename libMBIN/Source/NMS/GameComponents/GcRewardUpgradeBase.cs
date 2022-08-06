using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xFD2AF4A7805E60BD, NameHash = 0xE60E16C73CCFBAC0)]
    public class GcRewardUpgradeBase : NMSTemplate
    {
		public enum UpgradeBaseTypeEnum { AllMatching, NearestMatching }
		public UpgradeBaseTypeEnum UpgradeBaseType;
        public List<GcPersistentBaseTypes> MatchingBaseTypes;
    }
}
