using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x1003ACDA0DB7C653, NameHash = 0x839577D6883299CA)]
    public class GcPrimaryAxis : NMSTemplate
    {
		public enum PrimaryAxisEnum { Z, ZNeg, X, Xneg, Y, YNeg }
		public PrimaryAxisEnum PrimaryAxis;
    }
}
