using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x121, GUID = 0x417C3F79FC136943, NameHash = 0x416E9E84AB204114)]
    public class GcMissionSequenceWaitForPortalWarp : NMSTemplate
    {
        /* 0x000 */ public NMSString0x80 Message;
        /* 0x080 */ public NMSString0x80 DebugText;
        /* 0x100 */ public bool WarpToSpace;
        /* 0x101 */ public NMSString0x20 OverrideUA;
    }
}
