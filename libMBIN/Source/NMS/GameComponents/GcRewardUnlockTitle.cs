namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9886B628740CE568, NameHash = 0xAC19C9A74178EED8)]
    public class GcRewardUnlockTitle : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 TitleID;
        [NMS(Index = 1)]
        /* 0x10 */ public bool NoMusic;
        [NMS(Index = 2)]
        /* 0x11 */ public bool ShowEvenIfAlreadyUnlocked;
    }
}
