using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x30, GUID = 0x94B1F64B650A15E0, NameHash = 0x3E0EF3AAF2E4B272)]
    public class GcRewardModifyStat : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string Stat;
        [NMS(Size = 0x10)]
        /* 0x10 */ public string OtherStat;
        /* 0x20 */ public int Amount;
        /* 0x24 */ public bool UseOtherStat;
        public enum ModifyTypeEnum { Set, Add, Subtract }
        /* 0x28 */ public ModifyTypeEnum ModifyType;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x2C */ public byte[] EndPadding;
    }
}
