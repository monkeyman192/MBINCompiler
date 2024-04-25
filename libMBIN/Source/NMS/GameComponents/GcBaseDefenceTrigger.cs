namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCBDA352215D0A296, NameHash = 0x295BE0CF9BD70B66)]
    public class GcBaseDefenceTrigger : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x00 */ public NMSString0x10 LaserEffectId;
        [NMS(Index = 0)]
        /* 0x10 */ public NMSString0x10 PerceptionId;
        [NMS(Index = 1)]
        /* 0x20 */ public bool ActiveWhenIdle;
        [NMS(Index = 3)]
        /* 0x21 */ public bool ActiveWhenSearching;
        [NMS(Index = 2)]
        /* 0x22 */ public bool ActiveWhenTargetAcquired;
    }
}
