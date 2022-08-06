using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x7CCDABAB01548488, NameHash = 0x4915F8E34B74EAC3)]
    public class GcPortalData : NMSTemplate
    {
        /* 0x0 */ public float RuneRotateTime;      // 3F000000h
        /* 0x4 */ public bool SkipRuneEntry;        // 1
        /* 0x5 */ public bool KnowAllRunes;
    }
}
