using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x28, GUID = 0xA3DD15E1F86778ED, NameHash = 0x295BE0CF9BD70B66)]
    public class GcBaseDefenceTrigger : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 PerceptionId;
        /* 0x10 */ public bool ActiveWhenIdle;
        /* 0x11 */ public bool ActiveWhenTargetAcquired;
        /* 0x12 */ public bool ActiveWhenSearching;
        /* 0x18 */ public NMSString0x10 LaserEffectId;
}
}
