using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0x10B96B017A55BF39, NameHash = 0xD1E7F0BE0B98FD48)]
    public class TkNGuiAlignment : NMSTemplate
    {

		public enum VerticalEnum { Top, Middle, Bottom }
		public VerticalEnum Vertical;


		public enum HorizontalEnum { Left, Center, Right }
		public HorizontalEnum Horizontal;
    }
}