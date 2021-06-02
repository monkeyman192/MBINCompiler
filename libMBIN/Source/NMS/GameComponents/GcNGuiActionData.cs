using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x98, GUID = 0x8AB614E47861119A, NameHash = 0x2D0ED597896EB5AF)]
    public class GcNGuiActionData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 LayerID;
        /* 0x10 */ public NMSString0x80 Data;
		public enum ActionEnum { Click, Hover, ArrowLeft, ArrowRight }
		/* 0x90 */ public ActionEnum Action;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x94 */ public byte[] EndPadding;
    }
}