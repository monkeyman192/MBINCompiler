using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x28, GUID = 0x8D21E8BBC0C6961B, NameHash = 0x295BE0CF9BD70B66)]
    public class GcBaseDefenceTrigger : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 PerceptionId;
        /* 0x10 */ public bool ActiveWhenTargetAcquired;
        /* 0x11 */ public bool ActiveWhenTargetLost;
        [NMS(Size = 0x6, Ignore = true)]
        /* 0x12 */ public byte[] Padding12;
        /* 0x18 */ public NMSString0x10 LaserEffectId;
}
}
