using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x10, GUID = 0x1B43A3BABC81D6E8, NameHash = 0xA954F03559C40EB5)]
    public class TkHitCurveData : NMSTemplate
    {
        /* 0x000 */ public float Time;
		/* 0x004 */ public TkInOutCurve Curve;
    }
}