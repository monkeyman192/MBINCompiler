using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF1654B8174FA01B5, NameHash = 0xC8EEAC6B)]
    public class GcFlagshipBattleConfig : NMSTemplate
    {
        [NMS(Index = 59)]
        /* 0x000 */ public NMSString0x20A AlliedDeadBossBarTitle;
        [NMS(Index = 60)]
        /* 0x020 */ public NMSString0x20A AlliedDeadHostileEnginedDestroyedBossBarSubtitle;
        [NMS(Index = 61)]
        /* 0x040 */ public NMSString0x20A AlliedDeadHostileEscapingBossBarSubtitle;
        [NMS(Index = 47)]
        /* 0x060 */ public NMSString0x20A AlliedDeadHostileLeavingMsg;
        [NMS(Index = 39)]
        /* 0x080 */ public NMSString0x20A AlliedDeadMsg;
        [NMS(Index = 38)]
        /* 0x0A0 */ public NMSString0x20A AlliedHullMsg;
        [NMS(Index = 28)]
        /* 0x0C0 */ public NMSString0x20A AlliedKilledOSD;
        [NMS(Index = 37)]
        /* 0x0E0 */ public NMSString0x20A AlliedShieldMsg;
        [NMS(Index = 33)]
        /* 0x100 */ public NMSString0x20A BattleJoinedOSD;
        [NMS(Index = 52)]
        /* 0x120 */ public NMSString0x20A DefaultTitle;
        [NMS(Index = 55)]
        /* 0x140 */ public NMSString0x20A EscapeTitle;
        [NMS(Index = 27)]
        /* 0x160 */ public NMSString0x20A FleeCancelOSD;
        [NMS(Index = 26)]
        /* 0x180 */ public NMSString0x20A FleeOSD;
        [NMS(Index = 34)]
        /* 0x1A0 */ public NMSString0x20A FlyByOSD;
        [NMS(Index = 68)]
        /* 0x1C0 */ public NMSString0x20A HostileChargingWarpBossBarSubtitle;
        [NMS(Index = 67)]
        /* 0x1E0 */ public NMSString0x20A HostileChargingWarpBossBarTitle;
        [NMS(Index = 63)]
        /* 0x200 */ public NMSString0x20A HostileDeadAlliedAliveBossBarSubtitle;
        [NMS(Index = 48)]
        /* 0x220 */ public NMSString0x20A HostileDeadAlliedAliveMsg;
        [NMS(Index = 64)]
        /* 0x240 */ public NMSString0x20A HostileDeadAlliedDeadBossBarSubtitle;
        [NMS(Index = 49)]
        /* 0x260 */ public NMSString0x20A HostileDeadAlliedDeadMsg;
        [NMS(Index = 62)]
        /* 0x280 */ public NMSString0x20A HostileDeadBossBarTitle;
        [NMS(Index = 29)]
        /* 0x2A0 */ public NMSString0x20A HostileDestroyedOSD;
        [NMS(Index = 50)]
        /* 0x2C0 */ public NMSString0x20A HostileEscapedAlliedAliveMsg;
        [NMS(Index = 72)]
        /* 0x2E0 */ public NMSString0x20A HostileEscapedAlliedAliveSubtitle;
        [NMS(Index = 71)]
        /* 0x300 */ public NMSString0x20A HostileEscapedAlliedAliveTitle;
        [NMS(Index = 51)]
        /* 0x320 */ public NMSString0x20A HostileEscapedAlliedDeadMsg;
        [NMS(Index = 70)]
        /* 0x340 */ public NMSString0x20A HostileEscapedAlliedDeadSubtitle;
        [NMS(Index = 69)]
        /* 0x360 */ public NMSString0x20A HostileEscapedAlliedDeadTitle;
        [NMS(Index = 31)]
        /* 0x380 */ public NMSString0x20A HostileEscapedOSD;
        [NMS(Index = 32)]
        /* 0x3A0 */ public NMSString0x20A HostileRetreatedOSD;
        [NMS(Index = 40)]
        /* 0x3C0 */ public NMSString0x20A HostileShieldActiveMsg;
        [NMS(Index = 41)]
        /* 0x3E0 */ public NMSString0x20A HostileShieldDownMsg;
        [NMS(Index = 77)]
        /* 0x400 */ public NMSString0x20A HostileShieldsActiveBossBarSubtitle;
        [NMS(Index = 76)]
        /* 0x420 */ public NMSString0x20A HostileShieldsActiveBossBarTitle;
        [NMS(Index = 79)]
        /* 0x440 */ public NMSString0x20A HostileShieldsDownBossBarSubtitle;
        [NMS(Index = 78)]
        /* 0x460 */ public NMSString0x20A HostileShieldsDownBossBarTitle;
        [NMS(Index = 66)]
        /* 0x480 */ public NMSString0x20A HostileSurrenderedBossBarSubtitle;
        [NMS(Index = 65)]
        /* 0x4A0 */ public NMSString0x20A HostileSurrenderedBossBarTitle;
        [NMS(Index = 46)]
        /* 0x4C0 */ public NMSString0x20A HostileSurrenderedMsg;
        [NMS(Index = 74)]
        /* 0x4E0 */ public NMSString0x20A HostileTorpedosActiveBossBarSubtitle;
        [NMS(Index = 73)]
        /* 0x500 */ public NMSString0x20A HostileTorpedosBossBarTitle;
        [NMS(Index = 75)]
        /* 0x520 */ public NMSString0x20A HostileTorpedosLaunchingBossBarSubtitle;
        [NMS(Index = 45)]
        /* 0x540 */ public NMSString0x20A HostileWarpChargingMsg;
        [NMS(Index = 54)]
        /* 0x560 */ public NMSString0x20A LoseTitle;
        [NMS(Index = 42)]
        /* 0x580 */ public NMSString0x20A PlayerShieldLowMsg;
        [NMS(Index = 25)]
        /* 0x5A0 */ public NMSString0x20A ShieldDownHostileOSD;
        [NMS(Index = 30)]
        /* 0x5C0 */ public NMSString0x20A SurrenderOSD;
        [NMS(Index = 43)]
        /* 0x5E0 */ public NMSString0x20A TorpedoActiveMsg;
        [NMS(Index = 44)]
        /* 0x600 */ public NMSString0x20A TorpedoLaunchMsg;
        [NMS(Index = 35)]
        /* 0x620 */ public NMSString0x20A TorpedoLaunchOSD;
        [NMS(Index = 56)]
        /* 0x640 */ public NMSString0x20A TorpedoTitle;
        [NMS(Index = 53)]
        /* 0x660 */ public NMSString0x20A WinTitle;
        [NMS(Index = 20)]
        /* 0x680 */ public NMSString0x10 AlliedDestroyedReward;
        [NMS(Index = 22)]
        /* 0x690 */ public NMSString0x10 AlliedSavedLargeReward;
        [NMS(Index = 21)]
        /* 0x6A0 */ public NMSString0x10 AlliedSavedSmallReward;
        [NMS(Index = 23)]
        /* 0x6B0 */ public NMSString0x10 BattleSeenStat;
        [NMS(Index = 24)]
        /* 0x6C0 */ public NMSString0x10 BattleWonStat;
        [NMS(Index = 19)]
        /* 0x6D0 */ public NMSString0x10 HostileDestroyedReward;
        [NMS(Index = 14)]
        /* 0x6E0 */ public NMSString0x10 MinorLaserPlayerDamage;
        [NMS(Index = 12)]
        /* 0x6F0 */ public NMSString0x10 PrimaryLaserPlayerDamage;
        [NMS(Index = 80)]
        /* 0x700 */ public GcAudioWwiseEvents AlliedKilledAudioCue;
        [NMS(Index = 10)]
        /* 0x704 */ public float BattleNoTargetLeaderTime;
        [NMS(Index = 6)]
        /* 0x708 */ public float FleeHealthFraction;
        [NMS(Index = 13)]
        /* 0x70C */ public int MinorLaserDamageLevel;
        [NMS(Index = 11)]
        /* 0x710 */ public int PrimaryLaserDamageLevel;
        [NMS(Index = 15)]
        /* 0x714 */ public float RewardDelayTime;
        [NMS(Index = 16)]
        /* 0x718 */ public float RewardDelayTimeEscaped;
        [NMS(Index = 17)]
        /* 0x71C */ public float RewardMessageDelayTime;
        [NMS(Index = 18)]
        /* 0x720 */ public float RewardMessageDelayTimeEscaped;
        [NMS(Index = 81)]
        /* 0x724 */ public GcAudioWwiseEvents TorpedoLaunchAudioCue;
        [NMS(Index = 9)]
        /* 0x728 */ public int TotalEnginesForWarpCharging;
        [NMS(Index = 7)]
        /* 0x72C */ public float WarpChargeTime;
        [NMS(Index = 8)]
        /* 0x730 */ public float WarpChargeTimePerBrokenEngine;
        [NMS(Index = 0)]
        /* 0x734 */ public bool AllowSurrender;
        [NMS(Index = 2)]
        /* 0x735 */ public bool CanEscapeWhenBattleOver;
        [NMS(Index = 1)]
        /* 0x736 */ public bool CanFlee;
        [NMS(Index = 3)]
        /* 0x737 */ public bool HasDestructibleEngines;
        [NMS(Index = 5)]
        /* 0x738 */ public bool HasShieldGenerators;
        [NMS(Index = 4)]
        /* 0x739 */ public bool HasTorpedoes;
        [NMS(Index = 57)]
        /* 0x73A */ public bool HideBossBarIfAlliedInactive;
        [NMS(Index = 58)]
        /* 0x73B */ public bool HideBossBarIfHostileInactive;
        [NMS(Index = 36)]
        /* 0x73C */ public GcScannerIconTypes Icon;
    }
}
