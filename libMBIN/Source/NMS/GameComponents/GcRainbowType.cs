using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS( Size = 0x4, GUID = 0xB9CF7DBD6666BED1 )]
    public class GcRainbowType : NMSTemplate
    {
		public enum RainbowTypeEnum { Always, Occasional, Storm, None }
		public RainbowTypeEnum RainbowType;
    }
}
