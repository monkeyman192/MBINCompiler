using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x84, GUID = 0x9F99427CD6CB8D5C, NameHash = 0x1297324AF39B5F4E)]
	public class GcFontData : NMSTemplate
	{
		public NMSString0x80 File;
		public int MinCharWidth;
	}
}