using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xEA3C8CC4592D4410, NameHash = 0xC1BECA54193DD3FB)]
    public class GcMissionConditionTest : NMSTemplate
    {
		public enum ConditionTestEnum { AnyFalse, AllFalse, AnyTrue, AllTrue }
		public ConditionTestEnum ConditionTest;
    }
}