using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0x76657DBD09918A71, NameHash = 0x8122CE73)]
    public class GcGameTableGlobals : NMSTemplate
    {
        [NMS(Index = 128, Size = 0x9, EnumType = typeof(GcPetBattlerAffinity.PetBattlerAffinityEnum))]
        /* 0x0000 */ public Colour[] PetAffinityGlowColours;
        [NMS(Index = 135, Size = 0x7, EnumType = typeof(GcPetBattlerVRPanel.PetBattlerVRPanelEnum))]
        /* 0x0090 */ public Vector3f[] PetBattleVRPanelOffset;
        [NMS(Index = 33)]
        /* 0x0100 */ public Vector3f CameraLocationOffsetBase;
        [NMS(Index = 34)]
        /* 0x0110 */ public Vector3f CameraTargetOffsetBase;
        [NMS(Index = 71)]
        /* 0x0120 */ public Colour DamageNumberAffinityBoostColour;
        [NMS(Index = 72)]
        /* 0x0130 */ public Colour DamageNumberAffinityBoostColourOutline;
        [NMS(Index = 69)]
        /* 0x0140 */ public Colour DamageNumberHealColour;
        [NMS(Index = 70)]
        /* 0x0150 */ public Colour DamageNumberHealColourOutline;
        [NMS(Index = 73)]
        /* 0x0160 */ public Colour DamageNumberIneffectiveColour;
        [NMS(Index = 74)]
        /* 0x0170 */ public Colour DamageNumberIneffectiveColourOutline;
        [NMS(Index = 134)]
        /* 0x0180 */ public Vector3f PetBattleVRMainPanelOffset;
        [NMS(Index = 59)]
        /* 0x0190 */ public Colour PetPopupBarColour;
        [NMS(Index = 111, Size = 0xA, EnumType = typeof(GcPetBattlerMoveEffect.PetBattlerMoveEffectEnum))]
        /* 0x01A0 */ public GcPetBattlerEffectTable[] EffectTables;
        [NMS(Index = 108, Size = 0x9, EnumType = typeof(GcPetBattlerAffinity.PetBattlerAffinityEnum))]
        /* 0x1550 */ public GcPetBattlerEffectData[] InstantEffectData;
        [NMS(Index = 113, Size = 0x9, EnumType = typeof(GcPetBattlerAffinity.PetBattlerAffinityEnum))]
        /* 0x1748 */ public NMSString0x20A[] PetAffinityLoc;
        [NMS(Index = 115, Size = 0x9, EnumType = typeof(GcPetBattlerAffinity.PetBattlerAffinityEnum))]
        /* 0x1868 */ public NMSString0x20A[] PetAffinityLocInSentence;
        [NMS(Index = 114, Size = 0x9, EnumType = typeof(GcPetBattlerAffinity.PetBattlerAffinityEnum))]
        /* 0x1988 */ public NMSString0x20A[] PetAffinityLocLower;
        [NMS(Index = 123, Size = 0xA, EnumType = typeof(GcPetBattlerMoveEffect.PetBattlerMoveEffectEnum))]
        /* 0x1AA8 */ public GcPetBattleCameraSet[] PetBattleCameraSetsLocal;
        [NMS(Index = 124, Size = 0xA, EnumType = typeof(GcPetBattlerMoveEffect.PetBattlerMoveEffectEnum))]
        /* 0x1B48 */ public GcPetBattleCameraSet[] PetBattleCameraSetsRemote;
        [NMS(Index = 1, Size = 0x3, EnumType = typeof(GcGameTableMode.GameTableModeEnum))]
        /* 0x1BE8 */ public NMSString0x20A[] DefaultAIPlayerConfigs;
        [NMS(Index = 2)]
        /* 0x1C48 */ public GcGameTableNPCSpawnData DefaultGameTableNPC;
        [NMS(Index = 101, Size = 0x3, EnumType = typeof(GcCreaturePetTraits.PetTraitEnum))]
        /* 0x1C88 */ public NMSString0x10[] BonusMovesNegative;
        [NMS(Index = 100, Size = 0x3, EnumType = typeof(GcCreaturePetTraits.PetTraitEnum))]
        /* 0x1CB8 */ public NMSString0x10[] BonusMovesPositive;
        [NMS(Index = 4)]
        /* 0x1CE8 */ public NMSString0x10 AIPlayerHologramEffect;
        [NMS(Index = 98)]
        /* 0x1CF8 */ public NMSString0x10 DefaultMove;
        [NMS(Index = 99)]
        /* 0x1D08 */ public NMSString0x10 DefaultMoveSet;
        [NMS(Index = 110)]
        /* 0x1D18 */ public List<GcPetBattlerEffectPathOverride> EffectProjectileOverride;
        [NMS(Index = 122)]
        /* 0x1D28 */ public List<GcPetBattleCamera> PetBattleCameraLibrary;
        [NMS(Index = 46)]
        /* 0x1D38 */ public List<float> XPGapPerLevel;
        [NMS(Index = 83, Size = 0x3, EnumType = typeof(GcPetBattlerCoreStat.PetBattlerCoreStatEnum))]
        /* 0x1D48 */ public GcPetBattlerCoreStatRangeData[] CoreStatClassRangeTable;
        [NMS(Index = 8)]
        /* 0x1DA8 */ public GcGameTableDiceAutoRollParams DiceAutoRollParams;
        [NMS(Index = 97, Size = 0xF, EnumType = typeof(GcPetBattlerStat.PetBattlerStatEnum))]
        /* 0x1DE8 */ public float[] PetStatPayloadBoosts;
        [NMS(Index = 84, Size = 0x3, EnumType = typeof(GcPetBattlerCoreStat.PetBattlerCoreStatEnum))]
        /* 0x1E24 */ public GcPetBattlerCoreStatRollData[] CoreStatClassPerLevelBoosts;
        [NMS(Index = 78, Size = 0x3, EnumType = typeof(GcPetBattlerCoreStat.PetBattlerCoreStatEnum))]
        /* 0x1E54 */ public GcPetBattlerCoreStatRollData[] CoreStatClassRollTable;
        [NMS(Index = 133, Size = 0x7, EnumType = typeof(GcPetBattlerVRPanel.PetBattlerVRPanelEnum))]
        /* 0x1E84 */ public float[] PetBattlerVRPanelScale;
        [NMS(Index = 41, Size = 0x3, EnumType = typeof(GcGameTableAIDifficulty.GameTableAIDifficultyEnum))]
        /* 0x1EA0 */ public Vector2f[] AIPetTeamLevelDifficultyScaling;
        [NMS(Index = 35)]
        /* 0x1EB8 */ public GcPetBattleCameraPose PetBattleDefaultCameraPose;
        [NMS(Index = 36)]
        /* 0x1ED0 */ public GcPetBattleCameraPose PetBattleDefaultCameraPoseVR;
        [NMS(Index = 126)]
        /* 0x1EE8 */ public TkCameraWanderData PetBattleCamerWanderOrientation;
        [NMS(Index = 125)]
        /* 0x1EFC */ public TkCameraWanderData PetBattleCamerWanderPos;
        [NMS(Index = 103, Size = 0x5, EnumType = typeof(GcPetBattlerPayloadStrength.PetPayloadStrengthEnum))]
        /* 0x1F10 */ public int[] PetBattlerStrengthWeighting;
        [NMS(Index = 43, Size = 0x4, EnumType = typeof(GcInventoryClass.InventoryClassEnum))]
        /* 0x1F24 */ public float[] ClassXPMultipliers;
        [NMS(Index = 121, Size = 0x3, EnumType = typeof(GcPetBattlerAffinityEffectiveness.PetBattlerAffinityEffectivenessEnum))]
        /* 0x1F34 */ public float[] AffinityDamageEffectiveness;
        [NMS(Index = 58, Size = 0x3, EnumType = typeof(GcPetBattlerCoreStat.PetBattlerCoreStatEnum))]
        /* 0x1F40 */ public float[] BinocsUnknownPetStatsVariationOffsets;
        [NMS(Index = 55)]
        /* 0x1F4C */ public Vector2f PetAgilityScaleRange;
        [NMS(Index = 76)]
        /* 0x1F54 */ public Vector2f PetBattlerSizeRange;
        [NMS(Index = 54)]
        /* 0x1F5C */ public Vector2f PetMissAgilityRange;
        [NMS(Index = 75)]
        /* 0x1F64 */ public Vector2f PetSizeRange;
        [NMS(Index = 94)]
        /* 0x1F6C */ public float AbsorbPercent;
        [NMS(Index = 47)]
        /* 0x1F70 */ public float AffinityStrengthBonus;
        [NMS(Index = 48)]
        /* 0x1F74 */ public float AffinityWeakReducer;
        [NMS(Index = 25)]
        /* 0x1F78 */ public float AIWaitTimeMax;
        [NMS(Index = 24)]
        /* 0x1F7C */ public float AIWaitTimeMin;
        [NMS(Index = 56)]
        /* 0x1F80 */ public float BinocsUnknownPetStatsVariationRange;
        [NMS(Index = 57)]
        /* 0x1F84 */ public float BinocsUnknownPetStatsVariationTime;
        [NMS(Index = 102)]
        /* 0x1F88 */ public float BonusMoveChance;
        [NMS(Index = 39)]
        /* 0x1F8C */ public float CameraActionInSpring;
        [NMS(Index = 40)]
        /* 0x1F90 */ public float CameraActionOutSpring;
        [NMS(Index = 37)]
        /* 0x1F94 */ public float CameraFOV;
        [NMS(Index = 38)]
        /* 0x1F98 */ public float CameraFOVActionExtra;
        [NMS(Index = 89)]
        /* 0x1F9C */ public float CombatBudgetModerator;
        [NMS(Index = 88)]
        /* 0x1FA0 */ public float CooldownScoreBoostMax;
        [NMS(Index = 87)]
        /* 0x1FA4 */ public float CooldownScoreBoostMin;
        [NMS(Index = 82)]
        /* 0x1FA8 */ public float CoreStatScaleVarianceMul;
        [NMS(Index = 65)]
        /* 0x1FAC */ public float DamageNumberDuration;
        [NMS(Index = 62)]
        /* 0x1FB0 */ public float DamageNumberFontSizeLarge;
        [NMS(Index = 61)]
        /* 0x1FB4 */ public float DamageNumberFontSizeNormal;
        [NMS(Index = 60)]
        /* 0x1FB8 */ public float DamageNumberMinTimeSeparation;
        [NMS(Index = 66)]
        /* 0x1FBC */ public float DamageNumberOffset;
        [NMS(Index = 67)]
        /* 0x1FC0 */ public float DamageNumberOffsetHeal;
        [NMS(Index = 68)]
        /* 0x1FC4 */ public float DamageNumberOffsetMiss;
        [NMS(Index = 63)]
        /* 0x1FC8 */ public float DamageNumberOutlineSize;
        [NMS(Index = 64)]
        /* 0x1FCC */ public float DamageNumberShadowSize;
        [NMS(Index = 6)]
        /* 0x1FD0 */ public int DiceGameWinningScore;
        [NMS(Index = 9)]
        /* 0x1FD4 */ public float DiceMinSpeedForRandomForce;
        [NMS(Index = 12)]
        /* 0x1FD8 */ public float DiceRandomForceDirectionVariationRate;
        [NMS(Index = 11)]
        /* 0x1FDC */ public float DiceRandomForceOffset;
        [NMS(Index = 10)]
        /* 0x1FE0 */ public float DiceRandomForceStrength;
        [NMS(Index = 7)]
        /* 0x1FE4 */ public float DiceShakerScale;
        [NMS(Index = 109)]
        /* 0x1FE8 */ public float EffectMissScale;
        [NMS(Index = 19)]
        /* 0x1FEC */ public float FlyerBobSpeed;
        [NMS(Index = 20)]
        /* 0x1FF0 */ public float FlyerBobStrength;
        [NMS(Index = 77)]
        /* 0x1FF4 */ public float FlyingPetOffset;
        [NMS(Index = 95)]
        /* 0x1FF8 */ public float HealModerator;
        [NMS(Index = 21)]
        /* 0x1FFC */ public float ImpactShrink;
        [NMS(Index = 86)]
        /* 0x2000 */ public int MaxCooldownBoost;
        [NMS(Index = 96)]
        /* 0x2004 */ public float MaxMoveVariance;
        [NMS(Index = 92)]
        /* 0x2008 */ public float MissChanceBoost;
        [NMS(Index = 26)]
        /* 0x200C */ public float MoveIntroTime;
        [NMS(Index = 27)]
        /* 0x2010 */ public float MoveIntroTimeVR;
        [NMS(Index = 29)]
        /* 0x2014 */ public float MoveOutroTime;
        [NMS(Index = 30)]
        /* 0x2018 */ public float MoveOutroTimeVR;
        [NMS(Index = 28)]
        /* 0x201C */ public float MultiMovePause;
        [NMS(Index = 91)]
        /* 0x2020 */ public float MultiPhaseMoveBoost;
        [NMS(Index = 129)]
        /* 0x2024 */ public float NearestTableAudioFadeTime;
        [NMS(Index = 93)]
        /* 0x2028 */ public float NegativeEffectBoost;
        [NMS(Index = 22)]
        /* 0x202C */ public float NonAnimPetAttackSwell;
        [NMS(Index = 23)]
        /* 0x2030 */ public float NonAnimPetAttackSwellSpring;
        [NMS(Index = 0)]
        /* 0x2034 */ public float OutroTimer;
        [NMS(Index = 90)]
        /* 0x2038 */ public float PercentageMovesBooster;
        [NMS(Index = 42)]
        /* 0x203C */ public float PerPetXPAnimDelay;
        [NMS(Index = 49)]
        /* 0x2040 */ public float PetBaseCritChance;
        [NMS(Index = 50)]
        /* 0x2044 */ public float PetBaseCritDamageMul;
        [NMS(Index = 52)]
        /* 0x2048 */ public float PetBaseDodgeChance;
        [NMS(Index = 51)]
        /* 0x204C */ public float PetBaseMissChance;
        [NMS(Index = 132)]
        /* 0x2050 */ public int PetBattlerImpactScreenHeight;
        [NMS(Index = 130)]
        /* 0x2054 */ public float PetBattlerImpactScreenScale;
        [NMS(Index = 131)]
        /* 0x2058 */ public int PetBattlerImpactScreenWidth;
        [NMS(Index = 104)]
        /* 0x205C */ public float PetDamageShakeAmplitude;
        [NMS(Index = 105)]
        /* 0x2060 */ public float PetDamageShakeDampingStrength;
        [NMS(Index = 106)]
        /* 0x2064 */ public float PetDamageShakePhaseHz;
        [NMS(Index = 107)]
        /* 0x2068 */ public float PetEffectCooldownTime;
        [NMS(Index = 127)]
        /* 0x206C */ public float PetHealthBarAnimSpeed;
        [NMS(Index = 32)]
        /* 0x2070 */ public float PetKOSwapDelayTime;
        [NMS(Index = 81)]
        /* 0x2074 */ public int PetMaxLevel;
        [NMS(Index = 53)]
        /* 0x2078 */ public float PetMissAgiltyBasedExtra;
        [NMS(Index = 31)]
        /* 0x207C */ public float PostMovePauseTime;
        [NMS(Index = 80)]
        /* 0x2080 */ public float TeamStrengthMaxLevelsBelowHighestLevelMember;
        [NMS(Index = 79)]
        /* 0x2084 */ public float TeamStrengthShiftTowardsHighestLevelMemberFactor;
        [NMS(Index = 5)]
        /* 0x2088 */ public float TriggerTeleportEffectForRemotePlayersOnTableInteractDistance;
        [NMS(Index = 15)]
        /* 0x208C */ public int TurnTimerFailureDecrement;
        [NMS(Index = 17)]
        /* 0x2090 */ public int TurnTimerMaxValue;
        [NMS(Index = 16)]
        /* 0x2094 */ public int TurnTimerMinValue;
        [NMS(Index = 18)]
        /* 0x2098 */ public int TurnTimerShowThreshold;
        [NMS(Index = 13)]
        /* 0x209C */ public int TurnTimerStartingValue;
        [NMS(Index = 14)]
        /* 0x20A0 */ public int TurnTimerSuccessIncrement;
        [NMS(Index = 45)]
        /* 0x20A4 */ public float XPBasicAward;
        [NMS(Index = 44)]
        /* 0x20A8 */ public float XPValueBaseMul;
        [NMS(Index = 118, Size = 0x9, EnumType = typeof(GcPetBattlerAffinity.PetBattlerAffinityEnum))]
        /* 0x20AC */ public NMSString0x20[] PetAffinityInTextIconName;
        [NMS(Index = 116, Size = 0x9, EnumType = typeof(GcPetBattlerAffinity.PetBattlerAffinityEnum))]
        /* 0x21CC */ public NMSString0x20[] PetAffinityLocStub;
        [NMS(Index = 117, Size = 0x9, EnumType = typeof(GcPetBattlerTarget.PetBattlerTargetEnum))]
        /* 0x22EC */ public NMSString0x20[] PetTargetLoc;
        [NMS(Index = 112, Size = 0x11, EnumType = typeof(GcBiomeType.BiomeEnum))]
        /* 0x240C */ public GcPetBattlerAffinity[] PetBiomeAffinities;
        [NMS(Index = 85, Size = 0xF, EnumType = typeof(GcPetBattlerStat.PetBattlerStatEnum))]
        /* 0x241D */ public bool[] IsOffensiveStat;
        [NMS(Index = 119, Size = 0x9, EnumType = typeof(GcPetBattlerAffinity.PetBattlerAffinityEnum))]
        /* 0x242C */ public GcPetBattlerAffinity[] PetAffinityStrongVersus;
        [NMS(Index = 120, Size = 0x9, EnumType = typeof(GcPetBattlerAffinity.PetBattlerAffinityEnum))]
        /* 0x2435 */ public GcPetBattlerAffinity[] PetAffinityWeakVersus;
        [NMS(Index = 3)]
        /* 0x243E */ public bool ShowDebugStatus;
    }
}
