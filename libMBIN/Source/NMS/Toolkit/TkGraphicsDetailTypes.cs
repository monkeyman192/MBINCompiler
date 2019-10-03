using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0xEC040260D3EBB1E1, NameHash = 0xAACA1A6A0194D948)]
    public class TkGraphicsDetailTypes : NMSTemplate
    {
		public enum GraphicDetailEnum { Low, Medium, High, Ultra }
		public GraphicDetailEnum GraphicDetail;
    }
}
