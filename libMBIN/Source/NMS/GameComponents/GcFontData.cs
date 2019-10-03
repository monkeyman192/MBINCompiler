using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x9F99427CD6CB8D5C, NameHash = 0x1297324AF39B5F4E)]
	public class GcFontData : NMSTemplate
	{
		[NMS(Size = 0x80)]
		public string File;
		public int MinCharWidth;
	}
}
