using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x18, GUID = 0x47B106C27F5CF01A, NameHash = 0xAC19C9A74178EED8)]
    public class GcRewardUnlockTitle : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string TitleID;
        /* 0x10 */ public bool NoMusic;
        /* 0x11 */ public bool ShowEvenIfAlreadyUnlocked;
        [NMS(Size = 0x6, Ignore = true)]
        /* 0x12 */ public byte[] EndPadding;
    }
}
