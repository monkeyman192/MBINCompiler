using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0x9EA7BF9D76C20264, NameHash = 0xDAFDD0DB)]
    public class GcMultiplayerGlobals : NMSTemplate
    {
        [NMS(Index = 70)]
        /* 0x000 */ public TkTextureResource EpicMissionIcon;
        [NMS(Index = 72)]
        /* 0x018 */ public TkTextureResource EpicMissionIconNotSelected;
        [NMS(Index = 71)]
        /* 0x030 */ public TkTextureResource EpicMissionIconSelected;
        [NMS(Index = 68)]
        /* 0x048 */ public NMSString0x10 EpicMissionRewardOverride;
        [NMS(Index = 66)]
        /* 0x058 */ public NMSString0x10 EpicMissionSecondReward;
        [NMS(Index = 69)]
        /* 0x068 */ public NMSString0x10 NexusMissionStandardReward;
        [NMS(Index = 65)]
        /* 0x078 */ public NMSString0x10 QuicksilverMissionSecondReward;
        [NMS(Index = 64)]
        /* 0x088 */ public NMSString0x10 StandardMissionSecondReward;
        [NMS(Index = 67)]
        /* 0x098 */ public NMSString0x10 WeekendMissionSecondReward;
        [NMS(Index = 30)]
        /* 0x0A8 */ public ulong AbandonedEntityWaitPeriod;
        [NMS(Index = 0)]
        /* 0x0B0 */ public Vector2f FullSimHandUpdateDistance;
        [NMS(Index = 1)]
        /* 0x0B8 */ public Vector2f FullSimHandUpdateInterval;
        [NMS(Index = 53)]
        /* 0x0C0 */ public float BaseHeaderBroadcastInterval;
        [NMS(Index = 8)]
        /* 0x0C4 */ public float BlobHeightOffset;
        [NMS(Index = 62)]
        /* 0x0C8 */ public float ChanceMissionEpic;
        [NMS(Index = 17)]
        /* 0x0CC */ public float CharacterDirectionLerpModifier;
        [NMS(Index = 37)]
        /* 0x0D0 */ public float ConstantScoreDepletionRate;
        [NMS(Index = 14)]
        /* 0x0D4 */ public float DisconnectionDisplayTime;
        [NMS(Index = 2)]
        /* 0x0D8 */ public float DistanceBetweenTeleportMovementEffects;
        [NMS(Index = 41)]
        /* 0x0DC */ public float EditMessageInterval;
        [NMS(Index = 44)]
        /* 0x0E0 */ public float EditMessageReceivedSyncBackOffTime;
        [NMS(Index = 43)]
        /* 0x0E4 */ public float EditMessageSentSyncBackOffTime;
        [NMS(Index = 75)]
        /* 0x0E8 */ public float EntityUpdateMaxRateDist;
        [NMS(Index = 76)]
        /* 0x0EC */ public float EntityUpdateMinRateDist;
        [NMS(Index = 38)]
        /* 0x0F0 */ public float FactorScoreDepletionRate;
        [NMS(Index = 3)]
        /* 0x0F4 */ public float FullSimHandUpdateDisabledDistance;
        [NMS(Index = 4)]
        /* 0x0F8 */ public float FullSimUpdateInterval;
        [NMS(Index = 39)]
        /* 0x0FC */ public float HashCheckMessageInterval;
        [NMS(Index = 46)]
        /* 0x100 */ public float HashCheckMessageOverdueDistanceDivisor;
        [NMS(Index = 49)]
        /* 0x104 */ public int HashMessageSentCooldown;
        [NMS(Index = 48)]
        /* 0x108 */ public int HashReceivedCooldown;
        [NMS(Index = 34)]
        /* 0x10C */ public float HostBiasScore;
        [NMS(Index = 31)]
        /* 0x110 */ public float HostOnConnectedTimeout;
        [NMS(Index = 6)]
        /* 0x114 */ public float InviteInteractionTimeout;
        [NMS(Index = 5)]
        /* 0x118 */ public float JoinInteractionTimeout;
        [NMS(Index = 7)]
        /* 0x11C */ public int MaxDownloadableBases;
        [NMS(Index = 32)]
        /* 0x120 */ public int MaxSyncResponsesPerHash;
        [NMS(Index = 10)]
        /* 0x124 */ public int MessageQueueSize;
        [NMS(Index = 11)]
        /* 0x128 */ public int MessageQueueSizeDropUnreliable;
        [NMS(Index = 33)]
        /* 0x12C */ public float MinScore;
        [NMS(Index = 60)]
        /* 0x130 */ public int MissionRecurrenceTime;
        [NMS(Index = 61)]
        /* 0x134 */ public float MissionWaitOnceAllPlayersReadyTime;
        [NMS(Index = 42)]
        /* 0x138 */ public float NewBlockMessageInterval;
        [NMS(Index = 45)]
        /* 0x13C */ public float NewBlockMessageOverdueDistanceDivisor;
        [NMS(Index = 47)]
        /* 0x140 */ public int NewBlockMessageSentCooldown;
        [NMS(Index = 52)]
        /* 0x144 */ public int NewerHashReceivedCooldown;
        [NMS(Index = 57)]
        /* 0x148 */ public float NPCInteractionTimeout;
        [NMS(Index = 59)]
        /* 0x14C */ public float NPCReplicateEndDistance;
        [NMS(Index = 58)]
        /* 0x150 */ public float NPCReplicateStartDistance;
        [NMS(Index = 54)]
        /* 0x154 */ public float PlaceholderBroadcastInterval;
        [NMS(Index = 74)]
        /* 0x158 */ public float PlanetLocalEnitityInterestEnd;
        [NMS(Index = 73)]
        /* 0x15C */ public float PlanetLocalEnitityInterestStart;
        [NMS(Index = 29)]
        /* 0x160 */ public float PlayerInteractCooldown;
        [NMS(Index = 12)]
        /* 0x164 */ public float PlayerMarkerDisplayDistance;
        [NMS(Index = 26)]
        /* 0x168 */ public float PlayerMarkerLargeIconCloseSize;
        [NMS(Index = 24)]
        /* 0x16C */ public float PlayerMarkerLargeIconDist;
        [NMS(Index = 25)]
        /* 0x170 */ public float PlayerMarkerLargeIconFarSize;
        [NMS(Index = 27)]
        /* 0x174 */ public float PlayerMarkerMinShowDistance;
        [NMS(Index = 22)]
        /* 0x178 */ public float PlayerMarkerScreenOffsetY;
        [NMS(Index = 23)]
        /* 0x17C */ public float PlayerMarkerSmallIconSize;
        [NMS(Index = 63)]
        /* 0x180 */ public float RemoveDuplicateChatMessageTime;
        [NMS(Index = 16)]
        /* 0x184 */ public float ShipDirectionLerpModifier;
        [NMS(Index = 19)]
        /* 0x188 */ public float ShipLandShakeMaxDist;
        [NMS(Index = 18)]
        /* 0x18C */ public float ShipSyncConvervengeMultiplier;
        [NMS(Index = 55)]
        /* 0x190 */ public float StatSyncRadiusPlanet;
        [NMS(Index = 56)]
        /* 0x194 */ public float StatSyncRadiusSpace;
        [NMS(Index = 40)]
        /* 0x198 */ public float SyncMessageInterval;
        [NMS(Index = 9)]
        /* 0x19C */ public int TransactionTimeout;
        [NMS(Index = 15)]
        /* 0x1A0 */ public float UpdateSlerpModifier;
        [NMS(Index = 50)]
        /* 0x1A4 */ public int UsefulSyncResponseCooldown;
        [NMS(Index = 35)]
        /* 0x1A8 */ public float UsefulSyncResponseScore;
        [NMS(Index = 51)]
        /* 0x1AC */ public int UselessSyncResponseCooldown;
        [NMS(Index = 36)]
        /* 0x1B0 */ public float UselessSyncResponseScore;
        [NMS(Index = 20)]
        /* 0x1B4 */ public float VehicleStickLerpModifier;
        [NMS(Index = 21)]
        /* 0x1B8 */ public float VehicleThrottleLerpModifier;
        [NMS(Index = 28)]
        /* 0x1BC */ public bool PlayerMarkerCenteredName;
        [NMS(Index = 13)]
        /* 0x1BD */ public bool VoiceChatEnabled;
    }
}
