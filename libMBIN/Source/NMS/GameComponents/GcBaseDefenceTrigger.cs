namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCBDA352215D0A296, NameHash = 0x295BE0CF9BD70B66)]
    public class GcBaseDefenceTrigger : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 LaserEffectId;
        /* 0x10 */ public NMSString0x10 PerceptionId;
        /* 0x20 */ public bool ActiveWhenIdle;
        /* 0x21 */ public bool ActiveWhenSearching;
        /* 0x22 */ public bool ActiveWhenTargetAcquired;
    }
}
