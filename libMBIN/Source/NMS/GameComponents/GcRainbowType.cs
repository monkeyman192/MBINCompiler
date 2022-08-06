using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xB9CF7DBD6666BED1, NameHash = 0x71FCE9DED22FE107)]
    public class GcRainbowType : NMSTemplate
    {
		public enum RainbowTypeEnum { Always, Occasional, Storm, None }
		public RainbowTypeEnum RainbowType;
    }
}