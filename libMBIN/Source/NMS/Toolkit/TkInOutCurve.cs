using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0xC, GUID = 0x3AEA123B35FF91D2, NameHash = 0x37F732EF5C0B44F6)]
    public class TkInOutCurve : NMSTemplate
    {
        /* 0x000 */ public float Midpoint;
		/* 0x004 */ public TkCurveType InCurve;
		/* 0x008 */ public TkCurveType OutCurve;
    }
}