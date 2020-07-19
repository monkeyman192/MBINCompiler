using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xC, GUID = 0xF9E45ECC1F5FBB09, NameHash = 0xB254C2F2874C6D05)]
    public class GcCustomNotifyTimerOptions : NMSTemplate
    {
        /* 0x0 */ public bool HasCustomNotifyTimer;
        /* 0x4 */ public float NotifyDisplayTime;
        /* 0x8 */ public float NotifyPauseTime;
    }
}