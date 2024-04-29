namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x23D23EC1846967AF, NameHash = 0xF6987FC027F7291)]
    public class TkInteractiveControlData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x10 RewardId;
        [NMS(Index = 2)]
        /* 0x10 */ public float Cooldown;
        [NMS(Index = 0)]
        /* 0x14 */ public NMSString0x20 Id;
    }
}
