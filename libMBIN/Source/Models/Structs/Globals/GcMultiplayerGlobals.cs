namespace libMBIN.Models.Structs
{
    public class GcMultiplayerGlobals : NMSTemplate
    {
        /* 0x0 */ public float FullSimUpdateInterval;
        /* 0x4 */ public int MaxDownloadableBases;
        /* 0x8 */ public float BlobHeightOffset;
        /* 0xC */ public int MatchmakingVersion;
        /* 0x10 */ public int TransactionTimeout;
        /* 0x14 */ public int MessageQueueSize;
        /* 0x18 */ public int MessageQueueSizeDropUnreliable;
        /* 0x1C */ public float PlayerMarkerDisplayDistance;
        /* 0x20 */ public bool VoiceChatEnabled;
        /* 0x21 */ public bool FullSimHostMigration;
        /* 0x24 */ public float DisconnectionDisplayTime;
        /* 0x28 */ public float UpdatePeriod;
        /* 0x2C */ public float UpdatePeriodSteam;
        /* 0x30 */ public float VoiceUpdatePeriod;
        /* 0x34 */ public float VoiceUpdatePeriodSteam;
        /* 0x38 */ public float UpdateSlerpModifier;
        /* 0x3C */ public float ShipDirectionLerpModifier;
        /* 0x40 */ public float CharacterDirectionLerpModifier;
        /* 0x44 */ public float ShipSyncConvervengeMultiplier;
        /* 0x48 */ public float VehicleStickLerpModifier;
        /* 0x4C */ public float VehicleThrottleLerpModifier;
        /* 0x50 */ public float PlayerMarkerScreenOffsetY;
        /* 0x54 */ public float PlayerMarkerLargeIconDist;
        /* 0x58 */ public float PlayerMarkerLargeIconSize;
        /* 0x5C */ public float PlayerMarkerSmallIconSize;
        /* 0x60 */ public float PlayerMarkerMinShowDistance;
        /* 0x64 */ public bool PlayerMarkerCenteredName;
        /* 0x68 */ public int AbandonedEntityWaitPeriod_A;
        /* 0x6C */ public int AbandonedEntityWaitPeriod_B;
        /* 0x70 */ public float HostOnConnectedTimeout;
        /* 0x74 */ public int MaxSyncResponsesPerHash;
        /* 0x78 */ public float MinScore;
        /* 0x7C */ public float HostBiasScore;
        /* 0x80 */ public float UsefulSyncResponseScore;
        /* 0x84 */ public float UselessSyncResponseScore;
        /* 0x88 */ public float ConstantScoreDepletionRate;
        /* 0x8C */ public float FactorScoreDepletionRate;
        /* 0x90 */ public float HashCheckMessageInterval;
        /* 0x94 */ public float SyncMessageInterval;
        /* 0x98 */ public float EditMessageInterval;
        /* 0x9C */ public float NewBlockMessageInterval;
        /* 0xA0 */ public float EditMessageSentSyncBackOffTime;
        /* 0xA4 */ public float EditMessageReceivedSyncBackOffTime;
        /* 0xA8 */ public float NewBlockMessageOverdueDistanceDivisor;
        /* 0xAC */ public float HashCheckMessageOverdueDistanceDivisor;
        /* 0xB0 */ public int NewBlockMessageSentCooldown;
        /* 0xB4 */ public int HashReceivedCooldown;
        /* 0xB8 */ public int HashMessageSentCooldown;
        /* 0xBC */ public float UsefulSyncResponseCooldown;
        /* 0xC0 */ public int UselessSyncResponseCooldown;
        /* 0xC4 */ public float NewerHashReceivedCooldown;
        /* 0xC8 */ public float BaseHeaderBroadcastInterval;
        /* 0xCC */ public float PlaceholderBroadcastInterval;
        /* 0xD0 */ public float StatSyncRadiusPlanet;
        /* 0xD4 */ public float StatSyncRadiusSpace;
    }
}
