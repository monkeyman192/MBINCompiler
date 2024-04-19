using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0x8F2F3FB8E36B1F67, NameHash = 0xAE0EEF5ED0659FF3)]
    public class GcMultiplayerGlobals : NMSTemplate
    {
        /* 0x000 */ public NMSString0x10 EpicMissionRewardOverride;
        /* 0x010 */ public NMSString0x10 EpicMissionSecondReward;
        /* 0x020 */ public NMSString0x10 NexusMissionStandardReward;
        /* 0x030 */ public NMSString0x10 QuicksilverMissionSecondReward;
        /* 0x040 */ public NMSString0x10 StandardMissionSecondReward;
        /* 0x050 */ public NMSString0x10 WeekendMissionSecondReward;
        /* 0x060 */ public ulong AbandonedEntityWaitPeriod;
        /* 0x068 */ public TkTextureResource EpicMissionIcon;
        /* 0x0EC */ public TkTextureResource EpicMissionIconNotSelected;
        /* 0x170 */ public TkTextureResource EpicMissionIconSelected;
        /* 0x1F4 */ public Vector2f FullSimHandUpdateDistance;
        /* 0x1FC */ public Vector2f FullSimHandUpdateInterval;
        /* 0x204 */ public float BaseHeaderBroadcastInterval;
        /* 0x208 */ public float BlobHeightOffset;
        /* 0x20C */ public float ChanceMissionEpic;
        /* 0x210 */ public float CharacterDirectionLerpModifier;
        /* 0x214 */ public float ConstantScoreDepletionRate;
        /* 0x218 */ public float DisconnectionDisplayTime;
        /* 0x21C */ public float DistanceBetweenTeleportMovementEffects;
        /* 0x220 */ public float EditMessageInterval;
        /* 0x224 */ public float EditMessageReceivedSyncBackOffTime;
        /* 0x228 */ public float EditMessageSentSyncBackOffTime;
        /* 0x22C */ public float EntityUpdateMaxRateDist;
        /* 0x230 */ public float EntityUpdateMinRateDist;
        /* 0x234 */ public float FactorScoreDepletionRate;
        /* 0x238 */ public float FullSimHandUpdateDisabledDistance;
        /* 0x23C */ public float FullSimUpdateInterval;
        /* 0x240 */ public float HashCheckMessageInterval;
        /* 0x244 */ public float HashCheckMessageOverdueDistanceDivisor;
        /* 0x248 */ public int HashMessageSentCooldown;
        /* 0x24C */ public int HashReceivedCooldown;
        /* 0x250 */ public float HostBiasScore;
        /* 0x254 */ public float HostOnConnectedTimeout;
        /* 0x258 */ public float InviteInteractionTimeout;
        /* 0x25C */ public float JoinInteractionTimeout;
        /* 0x260 */ public int MaxDownloadableBases;
        /* 0x264 */ public int MaxSyncResponsesPerHash;
        /* 0x268 */ public int MessageQueueSize;
        /* 0x26C */ public int MessageQueueSizeDropUnreliable;
        /* 0x270 */ public float MinScore;
        /* 0x274 */ public int MissionRecurrenceTime;
        /* 0x278 */ public float MissionWaitOnceAllPlayersReadyTime;
        /* 0x27C */ public float NewBlockMessageInterval;
        /* 0x280 */ public float NewBlockMessageOverdueDistanceDivisor;
        /* 0x284 */ public int NewBlockMessageSentCooldown;
        /* 0x288 */ public int NewerHashReceivedCooldown;
        /* 0x28C */ public float NPCInteractionTimeout;
        /* 0x290 */ public float NPCReplicateEndDistance;
        /* 0x294 */ public float NPCReplicateStartDistance;
        /* 0x298 */ public float PlaceholderBroadcastInterval;
        /* 0x29C */ public float PlanetLocalEnitityInterestEnd;
        /* 0x2A0 */ public float PlanetLocalEnitityInterestStart;
        /* 0x2A4 */ public float PlayerInteractCooldown;
        /* 0x2A8 */ public float PlayerMarkerDisplayDistance;
        /* 0x2AC */ public float PlayerMarkerLargeIconCloseSize;
        /* 0x2B0 */ public float PlayerMarkerLargeIconDist;
        /* 0x2B4 */ public float PlayerMarkerLargeIconFarSize;
        /* 0x2B8 */ public float PlayerMarkerMinShowDistance;
        /* 0x2BC */ public float PlayerMarkerScreenOffsetY;
        /* 0x2C0 */ public float PlayerMarkerSmallIconSize;
        /* 0x2C4 */ public float RemoveDuplicateChatMessageTime;
        /* 0x2C8 */ public float ShipDirectionLerpModifier;
        /* 0x2CC */ public float ShipLandShakeMaxDist;
        /* 0x2D0 */ public float ShipSyncConvervengeMultiplier;
        /* 0x2D4 */ public float StatSyncRadiusPlanet;
        /* 0x2D8 */ public float StatSyncRadiusSpace;
        /* 0x2DC */ public float SyncMessageInterval;
        /* 0x2E0 */ public int TransactionTimeout;
        /* 0x2E4 */ public float UpdateSlerpModifier;
        /* 0x2E8 */ public int UsefulSyncResponseCooldown;
        /* 0x2EC */ public float UsefulSyncResponseScore;
        /* 0x2F0 */ public int UselessSyncResponseCooldown;
        /* 0x2F4 */ public float UselessSyncResponseScore;
        /* 0x2F8 */ public float VehicleStickLerpModifier;
        /* 0x2FC */ public float VehicleThrottleLerpModifier;
        /* 0x300 */ public bool PlayerMarkerCenteredName;
        /* 0x301 */ public bool VoiceChatEnabled;
    }
}
