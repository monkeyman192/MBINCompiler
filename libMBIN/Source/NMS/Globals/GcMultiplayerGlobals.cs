using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0xA27C0169387247CF, NameHash = 0xDAFDD0DB)]
    public class GcMultiplayerGlobals : NMSTemplate
    {
        [NMS(Index = 71)]
        /* 0x000 */ public TkTextureResource EpicMissionIcon;
        [NMS(Index = 73)]
        /* 0x018 */ public TkTextureResource EpicMissionIconNotSelected;
        [NMS(Index = 72)]
        /* 0x030 */ public TkTextureResource EpicMissionIconSelected;
        [NMS(Index = 69)]
        /* 0x048 */ public NMSString0x10 EpicMissionRewardOverride;
        [NMS(Index = 67)]
        /* 0x058 */ public NMSString0x10 EpicMissionSecondReward;
        [NMS(Index = 70)]
        /* 0x068 */ public NMSString0x10 NexusMissionStandardReward;
        [NMS(Index = 66)]
        /* 0x078 */ public NMSString0x10 QuicksilverMissionSecondReward;
        [NMS(Index = 65)]
        /* 0x088 */ public NMSString0x10 StandardMissionSecondReward;
        [NMS(Index = 68)]
        /* 0x098 */ public NMSString0x10 WeekendMissionSecondReward;
        [NMS(Index = 31)]
        /* 0x0A8 */ public ulong AbandonedEntityWaitPeriod;
        [NMS(Index = 0)]
        /* 0x0B0 */ public Vector2f FullSimHandUpdateDistance;
        [NMS(Index = 1)]
        /* 0x0B8 */ public Vector2f FullSimHandUpdateInterval;
        [NMS(Index = 54)]
        /* 0x0C0 */ public float BaseHeaderBroadcastInterval;
        [NMS(Index = 9)]
        /* 0x0C4 */ public float BlobHeightOffset;
        [NMS(Index = 63)]
        /* 0x0C8 */ public float ChanceMissionEpic;
        [NMS(Index = 18)]
        /* 0x0CC */ public float CharacterDirectionLerpModifier;
        [NMS(Index = 38)]
        /* 0x0D0 */ public float ConstantScoreDepletionRate;
        [NMS(Index = 15)]
        /* 0x0D4 */ public float DisconnectionDisplayTime;
        [NMS(Index = 2)]
        /* 0x0D8 */ public float DistanceBetweenTeleportMovementEffects;
        [NMS(Index = 42)]
        /* 0x0DC */ public float EditMessageInterval;
        [NMS(Index = 45)]
        /* 0x0E0 */ public float EditMessageReceivedSyncBackOffTime;
        [NMS(Index = 44)]
        /* 0x0E4 */ public float EditMessageSentSyncBackOffTime;
        [NMS(Index = 78)]
        /* 0x0E8 */ public int EntityUpdateBurstThreshold;
        [NMS(Index = 76)]
        /* 0x0EC */ public float EntityUpdateMaxRateDist;
        [NMS(Index = 77)]
        /* 0x0F0 */ public float EntityUpdateMinRateDist;
        [NMS(Index = 80)]
        /* 0x0F4 */ public int EntityUpdateSendEarlyLookAhead;
        [NMS(Index = 79)]
        /* 0x0F8 */ public int EntityUpdateSpreadLookAhead;
        [NMS(Index = 39)]
        /* 0x0FC */ public float FactorScoreDepletionRate;
        [NMS(Index = 3)]
        /* 0x100 */ public float FullSimHandUpdateDisabledDistance;
        [NMS(Index = 4)]
        /* 0x104 */ public float FullSimUpdateInterval;
        [NMS(Index = 40)]
        /* 0x108 */ public float HashCheckMessageInterval;
        [NMS(Index = 47)]
        /* 0x10C */ public float HashCheckMessageOverdueDistanceDivisor;
        [NMS(Index = 50)]
        /* 0x110 */ public int HashMessageSentCooldown;
        [NMS(Index = 49)]
        /* 0x114 */ public int HashReceivedCooldown;
        [NMS(Index = 35)]
        /* 0x118 */ public float HostBiasScore;
        [NMS(Index = 32)]
        /* 0x11C */ public float HostOnConnectedTimeout;
        [NMS(Index = 6)]
        /* 0x120 */ public float InviteInteractionTimeout;
        [NMS(Index = 5)]
        /* 0x124 */ public float JoinInteractionTimeout;
        [NMS(Index = 8)]
        /* 0x128 */ public int MaxDownloadableBases;
        [NMS(Index = 33)]
        /* 0x12C */ public int MaxSyncResponsesPerHash;
        [NMS(Index = 11)]
        /* 0x130 */ public int MessageQueueSize;
        [NMS(Index = 12)]
        /* 0x134 */ public int MessageQueueSizeDropUnreliable;
        [NMS(Index = 34)]
        /* 0x138 */ public float MinScore;
        [NMS(Index = 61)]
        /* 0x13C */ public int MissionRecurrenceTime;
        [NMS(Index = 62)]
        /* 0x140 */ public float MissionWaitOnceAllPlayersReadyTime;
        [NMS(Index = 43)]
        /* 0x144 */ public float NewBlockMessageInterval;
        [NMS(Index = 46)]
        /* 0x148 */ public float NewBlockMessageOverdueDistanceDivisor;
        [NMS(Index = 48)]
        /* 0x14C */ public int NewBlockMessageSentCooldown;
        [NMS(Index = 53)]
        /* 0x150 */ public int NewerHashReceivedCooldown;
        [NMS(Index = 58)]
        /* 0x154 */ public float NPCInteractionTimeout;
        [NMS(Index = 60)]
        /* 0x158 */ public float NPCReplicateEndDistance;
        [NMS(Index = 59)]
        /* 0x15C */ public float NPCReplicateStartDistance;
        [NMS(Index = 55)]
        /* 0x160 */ public float PlaceholderBroadcastInterval;
        [NMS(Index = 75)]
        /* 0x164 */ public float PlanetLocalEnitityInterestEnd;
        [NMS(Index = 74)]
        /* 0x168 */ public float PlanetLocalEnitityInterestStart;
        [NMS(Index = 30)]
        /* 0x16C */ public float PlayerInteractCooldown;
        [NMS(Index = 13)]
        /* 0x170 */ public float PlayerMarkerDisplayDistance;
        [NMS(Index = 27)]
        /* 0x174 */ public float PlayerMarkerLargeIconCloseSize;
        [NMS(Index = 25)]
        /* 0x178 */ public float PlayerMarkerLargeIconDist;
        [NMS(Index = 26)]
        /* 0x17C */ public float PlayerMarkerLargeIconFarSize;
        [NMS(Index = 28)]
        /* 0x180 */ public float PlayerMarkerMinShowDistance;
        [NMS(Index = 23)]
        /* 0x184 */ public float PlayerMarkerScreenOffsetY;
        [NMS(Index = 24)]
        /* 0x188 */ public float PlayerMarkerSmallIconSize;
        [NMS(Index = 64)]
        /* 0x18C */ public float RemoveDuplicateChatMessageTime;
        [NMS(Index = 17)]
        /* 0x190 */ public float ShipDirectionLerpModifier;
        [NMS(Index = 20)]
        /* 0x194 */ public float ShipLandShakeMaxDist;
        [NMS(Index = 19)]
        /* 0x198 */ public float ShipSyncConvervengeMultiplier;
        [NMS(Index = 56)]
        /* 0x19C */ public float StatSyncRadiusPlanet;
        [NMS(Index = 57)]
        /* 0x1A0 */ public float StatSyncRadiusSpace;
        [NMS(Index = 41)]
        /* 0x1A4 */ public float SyncMessageInterval;
        [NMS(Index = 10)]
        /* 0x1A8 */ public int TransactionTimeout;
        [NMS(Index = 16)]
        /* 0x1AC */ public float UpdateSlerpModifier;
        [NMS(Index = 51)]
        /* 0x1B0 */ public int UsefulSyncResponseCooldown;
        [NMS(Index = 36)]
        /* 0x1B4 */ public float UsefulSyncResponseScore;
        [NMS(Index = 52)]
        /* 0x1B8 */ public int UselessSyncResponseCooldown;
        [NMS(Index = 37)]
        /* 0x1BC */ public float UselessSyncResponseScore;
        [NMS(Index = 21)]
        /* 0x1C0 */ public float VehicleStickLerpModifier;
        [NMS(Index = 22)]
        /* 0x1C4 */ public float VehicleThrottleLerpModifier;
        [NMS(Index = 7)]
        /* 0x1C8 */ public bool EnableBackgroundMessageSending;
        [NMS(Index = 29)]
        /* 0x1C9 */ public bool PlayerMarkerCenteredName;
        [NMS(Index = 14)]
        /* 0x1CA */ public bool VoiceChatEnabled;
    }
}
