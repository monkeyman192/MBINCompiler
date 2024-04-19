namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x5ECF7EC2AF5DF7BD, NameHash = 0xF6987FC027F7291)]
    public class TkInteractiveControlData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 RewardId;
        /* 0x10 */ public float Cooldown;
        /* 0x14 */ public NMSString0x20 Id;
    }
}
