using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA27BAFF181DF998F, NameHash = 0x7471FD77815538C2)]
    public class GcMissionSequenceReward : NMSTemplate
    {
        /* 0x00 */ public NMSString0x80 Message;
        /* 0x80 */ public NMSString0x10 Reward;
        /* 0x90 */ public bool CanOverride;
        /* 0x91 */ public bool Silent;
        public enum RewardInventoryOverrideEnum { None, Suit, Ship, Vehicle, Freighter }
        /* 0x94 */ public RewardInventoryOverrideEnum RewardInventoryOverride;
        /* 0x98 */ public NMSString0x80 DebugText;
    }
}
