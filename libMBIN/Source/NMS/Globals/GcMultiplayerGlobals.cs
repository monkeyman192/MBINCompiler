using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0x3A0A4DE4E56FA6F9, NameHash = 0xAE0EEF5ED0659FF3)]
    public class GcMultiplayerGlobals : NMSTemplate
    {
        [NMS(Index = 68)]
        /* 0x000 */ public NMSString0x10 EpicMissionRewardOverride;
        [NMS(Index = 66)]
        /* 0x010 */ public NMSString0x10 EpicMissionSecondReward;
        [NMS(Index = 69)]
        /* 0x020 */ public NMSString0x10 NexusMissionStandardReward;
        [NMS(Index = 65)]
        /* 0x030 */ public NMSString0x10 QuicksilverMissionSecondReward;
        [NMS(Index = 64)]
        /* 0x040 */ public NMSString0x10 StandardMissionSecondReward;
        [NMS(Index = 67)]
        /* 0x050 */ public NMSString0x10 WeekendMissionSecondReward;
        [NMS(Index = 30)]
        /* 0x060 */ public ulong AbandonedEntityWaitPeriod;
        [NMS(Index = 70)]
        /* 0x068 */ public TkTextureResource EpicMissionIcon;
        [NMS(Index = 72)]
        /* 0x0EC */ public TkTextureResource EpicMissionIconNotSelected;
        [NMS(Index = 71)]
        /* 0x170 */ public TkTextureResource EpicMissionIconSelected;
        [NMS(Index = 0)]
        /* 0x1F4 */ public Vector2f FullSimHandUpdateDistance;
        [NMS(Index = 1)]
        /* 0x1FC */ public Vector2f FullSimHandUpdateInterval;
        [NMS(Index = 53)]
        /* 0x204 */ public float BaseHeaderBroadcastInterval;
        [NMS(Index = 8)]
        /* 0x208 */ public float BlobHeightOffset;
        [NMS(Index = 62)]
        /* 0x20C */ public float ChanceMissionEpic;
        [NMS(Index = 17)]
        /* 0x210 */ public float CharacterDirectionLerpModifier;
        [NMS(Index = 37)]
        /* 0x214 */ public float ConstantScoreDepletionRate;
        [NMS(Index = 14)]
        /* 0x218 */ public float DisconnectionDisplayTime;
        [NMS(Index = 2)]
        /* 0x21C */ public float DistanceBetweenTeleportMovementEffects;
        [NMS(Index = 41)]
        /* 0x220 */ public float EditMessageInterval;
        [NMS(Index = 44)]
        /* 0x224 */ public float EditMessageReceivedSyncBackOffTime;
        [NMS(Index = 43)]
        /* 0x228 */ public float EditMessageSentSyncBackOffTime;
        [NMS(Index = 75)]
        /* 0x22C */ public float EntityUpdateMaxRateDist;
        [NMS(Index = 76)]
        /* 0x230 */ public float EntityUpdateMinRateDist;
        [NMS(Index = 38)]
        /* 0x234 */ public float FactorScoreDepletionRate;
        [NMS(Index = 3)]
        /* 0x238 */ public float FullSimHandUpdateDisabledDistance;
        [NMS(Index = 4)]
        /* 0x23C */ public float FullSimUpdateInterval;
        [NMS(Index = 39)]
        /* 0x240 */ public float HashCheckMessageInterval;
        [NMS(Index = 46)]
        /* 0x244 */ public float HashCheckMessageOverdueDistanceDivisor;
        [NMS(Index = 49)]
        /* 0x248 */ public int HashMessageSentCooldown;
        [NMS(Index = 48)]
        /* 0x24C */ public int HashReceivedCooldown;
        [NMS(Index = 34)]
        /* 0x250 */ public float HostBiasScore;
        [NMS(Index = 31)]
        /* 0x254 */ public float HostOnConnectedTimeout;
        [NMS(Index = 6)]
        /* 0x258 */ public float InviteInteractionTimeout;
        [NMS(Index = 5)]
        /* 0x25C */ public float JoinInteractionTimeout;
        [NMS(Index = 7)]
        /* 0x260 */ public int MaxDownloadableBases;
        [NMS(Index = 32)]
        /* 0x264 */ public int MaxSyncResponsesPerHash;
        [NMS(Index = 10)]
        /* 0x268 */ public int MessageQueueSize;
        [NMS(Index = 11)]
        /* 0x26C */ public int MessageQueueSizeDropUnreliable;
        [NMS(Index = 33)]
        /* 0x270 */ public float MinScore;
        [NMS(Index = 60)]
        /* 0x274 */ public int MissionRecurrenceTime;
        [NMS(Index = 61)]
        /* 0x278 */ public float MissionWaitOnceAllPlayersReadyTime;
        [NMS(Index = 42)]
        /* 0x27C */ public float NewBlockMessageInterval;
        [NMS(Index = 45)]
        /* 0x280 */ public float NewBlockMessageOverdueDistanceDivisor;
        [NMS(Index = 47)]
        /* 0x284 */ public int NewBlockMessageSentCooldown;
        [NMS(Index = 52)]
        /* 0x288 */ public int NewerHashReceivedCooldown;
        [NMS(Index = 57)]
        /* 0x28C */ public float NPCInteractionTimeout;
        [NMS(Index = 59)]
        /* 0x290 */ public float NPCReplicateEndDistance;
        [NMS(Index = 58)]
        /* 0x294 */ public float NPCReplicateStartDistance;
        [NMS(Index = 54)]
        /* 0x298 */ public float PlaceholderBroadcastInterval;
        [NMS(Index = 74)]
        /* 0x29C */ public float PlanetLocalEnitityInterestEnd;
        [NMS(Index = 73)]
        /* 0x2A0 */ public float PlanetLocalEnitityInterestStart;
        [NMS(Index = 29)]
        /* 0x2A4 */ public float PlayerInteractCooldown;
        [NMS(Index = 12)]
        /* 0x2A8 */ public float PlayerMarkerDisplayDistance;
        [NMS(Index = 26)]
        /* 0x2AC */ public float PlayerMarkerLargeIconCloseSize;
        [NMS(Index = 24)]
        /* 0x2B0 */ public float PlayerMarkerLargeIconDist;
        [NMS(Index = 25)]
        /* 0x2B4 */ public float PlayerMarkerLargeIconFarSize;
        [NMS(Index = 27)]
        /* 0x2B8 */ public float PlayerMarkerMinShowDistance;
        [NMS(Index = 22)]
        /* 0x2BC */ public float PlayerMarkerScreenOffsetY;
        [NMS(Index = 23)]
        /* 0x2C0 */ public float PlayerMarkerSmallIconSize;
        [NMS(Index = 63)]
        /* 0x2C4 */ public float RemoveDuplicateChatMessageTime;
        [NMS(Index = 16)]
        /* 0x2C8 */ public float ShipDirectionLerpModifier;
        [NMS(Index = 19)]
        /* 0x2CC */ public float ShipLandShakeMaxDist;
        [NMS(Index = 18)]
        /* 0x2D0 */ public float ShipSyncConvervengeMultiplier;
        [NMS(Index = 55)]
        /* 0x2D4 */ public float StatSyncRadiusPlanet;
        [NMS(Index = 56)]
        /* 0x2D8 */ public float StatSyncRadiusSpace;
        [NMS(Index = 40)]
        /* 0x2DC */ public float SyncMessageInterval;
        [NMS(Index = 9)]
        /* 0x2E0 */ public int TransactionTimeout;
        [NMS(Index = 15)]
        /* 0x2E4 */ public float UpdateSlerpModifier;
        [NMS(Index = 50)]
        /* 0x2E8 */ public int UsefulSyncResponseCooldown;
        [NMS(Index = 35)]
        /* 0x2EC */ public float UsefulSyncResponseScore;
        [NMS(Index = 51)]
        /* 0x2F0 */ public int UselessSyncResponseCooldown;
        [NMS(Index = 36)]
        /* 0x2F4 */ public float UselessSyncResponseScore;
        [NMS(Index = 20)]
        /* 0x2F8 */ public float VehicleStickLerpModifier;
        [NMS(Index = 21)]
        /* 0x2FC */ public float VehicleThrottleLerpModifier;
        [NMS(Index = 28)]
        /* 0x300 */ public bool PlayerMarkerCenteredName;
        [NMS(Index = 13)]
        /* 0x301 */ public bool VoiceChatEnabled;
    }
}
