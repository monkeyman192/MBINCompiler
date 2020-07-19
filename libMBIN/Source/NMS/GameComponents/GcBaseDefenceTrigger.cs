using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x28, GUID = 0x8D21E8BBC0C6961B, NameHash = 0x295BE0CF9BD70B66)]
    public class GcBaseDefenceTrigger : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string PerceptionId;
        /* 0x10 */ public bool ActiveWhenTargetAcquired;
        /* 0x11 */ public bool ActiveWhenTargetLost;
        [NMS(Size = 0x6, Ignore = true)]
        /* 0x12 */ public byte[] Padding12;
        [NMS(Size = 0x10)]
        /* 0x18 */ public string LaserEffectId;
}
}
