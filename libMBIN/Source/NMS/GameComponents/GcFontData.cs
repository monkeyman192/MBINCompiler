using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	public class GcFontData : NMSTemplate
	{
		[NMS(Size = 0x80)]
		public string File;
		public int MinCharWidth;
	}
}
