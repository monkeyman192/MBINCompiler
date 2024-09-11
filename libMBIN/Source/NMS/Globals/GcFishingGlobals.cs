using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0x65CFA21DCE978DAA, NameHash = 0x5C7DDD33)]
    public class GcFishingGlobals : NMSTemplate
    {
        [NMS(Index = 36)]
        /* 0x000 */ public Vector3f CastLaunchOffset;
        [NMS(Index = 83)]
        /* 0x010 */ public Colour LineColourBite;
        [NMS(Index = 84)]
        /* 0x020 */ public Colour LineColourChase;
        [NMS(Index = 81)]
        /* 0x030 */ public Colour LineColourDefault;
        [NMS(Index = 86)]
        /* 0x040 */ public Colour LineColourFail;
        [NMS(Index = 85)]
        /* 0x050 */ public Colour LineColourLand;
        [NMS(Index = 82)]
        /* 0x060 */ public Colour LineColourNibble;
        [NMS(Index = 31)]
        /* 0x070 */ public Vector3f RodFirstPersonOffset;
        [NMS(Index = 32)]
        /* 0x080 */ public Vector3f RodFirstPersonOffsetReelIn;
        [NMS(Index = 39)]
        /* 0x090 */ public Vector3f VRRodOffset;
        [NMS(Index = 38)]
        /* 0x0A0 */ public Vector3f VRRodRotation;
        [NMS(Index = 54)]
        /* 0x0B0 */ public GcCompositeCurveData BaitFlickBobCurve;
        [NMS(Index = 55)]
        /* 0x0C8 */ public GcCompositeCurveData BaitFlickLineCurve;
        [NMS(Index = 65, Size = 0x4, EnumType = typeof(GcFishSize.FishSizeEnum))]
        /* 0x0E0 */ public GcFishSizeProbability[] SizeWeights;
        [NMS(Index = 67, Size = 0x4, EnumType = typeof(GcFishSize.FishSizeEnum))]
        /* 0x120 */ public GcGaussianCurveData[] FishMass;
        [NMS(Index = 22, Size = 0x5, EnumType = typeof(GcItemQuality.ItemQualityEnum))]
        /* 0x140 */ public float[] BaitRarityBoostTotalScoreQualityScaling;
        [NMS(Index = 88, Size = 0x5, EnumType = typeof(GcItemQuality.ItemQualityEnum))]
        /* 0x154 */ public int[] MaxSeaHarvesterCaughtFish;
        [NMS(Index = 66, Size = 0x5, EnumType = typeof(GcItemQuality.ItemQualityEnum))]
        /* 0x168 */ public int[] QualityWeights;
        [NMS(Index = 25, Size = 0x4, EnumType = typeof(GcFishSize.FishSizeEnum))]
        /* 0x17C */ public float[] BaitSizeBoostTotalScoreQualityScaling;
        [NMS(Index = 63, Size = 0x4, EnumType = typeof(GcFishSize.FishSizeEnum))]
        /* 0x18C */ public float[] ChaseTimes;
        [NMS(Index = 64, Size = 0x4, EnumType = typeof(GcFishSize.FishSizeEnum))]
        /* 0x19C */ public float[] MysteryFishScales;
        [NMS(Index = 30)]
        /* 0x1AC */ public float BaitCookingValueMin;
        [NMS(Index = 48)]
        /* 0x1B0 */ public float BaitFlickBobHeight;
        [NMS(Index = 52)]
        /* 0x1B4 */ public float BaitFlickBobHeightLean;
        [NMS(Index = 50)]
        /* 0x1B8 */ public float BaitFlickBobTime;
        [NMS(Index = 51)]
        /* 0x1BC */ public float BaitFlickBobTimeLean;
        [NMS(Index = 49)]
        /* 0x1C0 */ public float BaitFlickBobTimeOffset;
        [NMS(Index = 53)]
        /* 0x1C4 */ public float BaitFlickEffectTime;
        [NMS(Index = 29)]
        /* 0x1C8 */ public float BaitRandScoreCookingValueFactor;
        [NMS(Index = 24)]
        /* 0x1CC */ public float BaitRarityBoostTotalScoreMax;
        [NMS(Index = 23)]
        /* 0x1D0 */ public float BaitRarityBoostTotalScoreMin;
        [NMS(Index = 27)]
        /* 0x1D4 */ public float BaitSizeBoostTotalScoreMax;
        [NMS(Index = 26)]
        /* 0x1D8 */ public float BaitSizeBoostTotalScoreMin;
        [NMS(Index = 28)]
        /* 0x1DC */ public float BaitWeatherBoostScoreThresholdForNotes;
        [NMS(Index = 46)]
        /* 0x1E0 */ public float CastGravity;
        [NMS(Index = 45)]
        /* 0x1E4 */ public float CastLaunchAngle;
        [NMS(Index = 35)]
        /* 0x1E8 */ public float CastLaunchDelayTime;
        [NMS(Index = 40)]
        /* 0x1EC */ public float CastVelocityBlendFactor;
        [NMS(Index = 91)]
        /* 0x1F0 */ public float DebugSceneCastDist;
        [NMS(Index = 90)]
        /* 0x1F4 */ public float DebugSceneFlicktimeMax;
        [NMS(Index = 89)]
        /* 0x1F8 */ public float DebugSceneFlicktimeMin;
        [NMS(Index = 0)]
        /* 0x1FC */ public float FirstPersonMaxTurnAngle;
        [NMS(Index = 12)]
        /* 0x200 */ public float FirstPersonPitchMaxSpeedScaling;
        [NMS(Index = 10)]
        /* 0x204 */ public float FirstPersonPitchMaxSpeedYawAngle;
        [NMS(Index = 11)]
        /* 0x208 */ public float FirstPersonPitchMinSpeedScaling;
        [NMS(Index = 9)]
        /* 0x20C */ public float FirstPersonPitchMinSpeedYawAngle;
        [NMS(Index = 5)]
        /* 0x210 */ public float FirstPersonPullBackAngle;
        [NMS(Index = 6)]
        /* 0x214 */ public float FirstPersonPullBackSpeedScaling;
        [NMS(Index = 2)]
        /* 0x218 */ public float FirstPersonTurnSpeedBaseScaling;
        [NMS(Index = 56)]
        /* 0x21C */ public float FishCatchAfterBiteTime;
        [NMS(Index = 57)]
        /* 0x220 */ public float FishingRange;
        [NMS(Index = 44)]
        /* 0x224 */ public float FishingRangeVRMultiplier;
        [NMS(Index = 58)]
        /* 0x228 */ public float FishMouthOffset;
        [NMS(Index = 60)]
        /* 0x22C */ public float FishNibbleOffset;
        [NMS(Index = 59)]
        /* 0x230 */ public float FishWaterDisplacementSmoothTime;
        [NMS(Index = 19)]
        /* 0x234 */ public float FloatTiltAmount;
        [NMS(Index = 20)]
        /* 0x238 */ public float FloatTiltIntoTime;
        [NMS(Index = 21)]
        /* 0x23C */ public float FloatTiltOutOfTime;
        [NMS(Index = 18)]
        /* 0x240 */ public float FloatTiltThreshold;
        [NMS(Index = 33)]
        /* 0x244 */ public float LandTimeBegin;
        [NMS(Index = 34)]
        /* 0x248 */ public float LandTimeEnd;
        [NMS(Index = 14)]
        /* 0x24C */ public float LeanCausesBobThreshold;
        [NMS(Index = 69)]
        /* 0x250 */ public float LineAttachmentOffset;
        [NMS(Index = 76)]
        /* 0x254 */ public float LineBiteSag;
        [NMS(Index = 70)]
        /* 0x258 */ public float LineBrightness;
        [NMS(Index = 77)]
        /* 0x25C */ public float LineColourChangeRate;
        [NMS(Index = 79)]
        /* 0x260 */ public float LineColourChangeRateBite;
        [NMS(Index = 78)]
        /* 0x264 */ public float LineColourChangeRateNibble;
        [NMS(Index = 75)]
        /* 0x268 */ public float LineFlickSag;
        [NMS(Index = 74)]
        /* 0x26C */ public float LineNibbleSag;
        [NMS(Index = 73)]
        /* 0x270 */ public float LineWaitSag;
        [NMS(Index = 72)]
        /* 0x274 */ public float LineWidth;
        [NMS(Index = 62)]
        /* 0x278 */ public float MaxWaitTime;
        [NMS(Index = 37)]
        /* 0x27C */ public float MinVelocityToCast;
        [NMS(Index = 61)]
        /* 0x280 */ public float MinWaitTime;
        [NMS(Index = 47)]
        /* 0x284 */ public float ReelHoldTime;
        [NMS(Index = 41)]
        /* 0x288 */ public float RequiredBackCastAngleDegrees;
        [NMS(Index = 42)]
        /* 0x28C */ public float RequiredCastAngleDegrees;
        [NMS(Index = 87)]
        /* 0x290 */ public float SeaHarvesterAverageCatchTimeSeconds;
        [NMS(Index = 68)]
        /* 0x294 */ public float StormThreshold;
        [NMS(Index = 16)]
        /* 0x298 */ public float ThirdPersonLeanMaxAngle;
        [NMS(Index = 17)]
        /* 0x29C */ public float ThirdPersonLeanMidpointAngle;
        [NMS(Index = 15)]
        /* 0x2A0 */ public float ThirdPersonLeanTime;
        [NMS(Index = 43)]
        /* 0x2A4 */ public float VRCastStrength;
        [NMS(Index = 8)]
        /* 0x2A8 */ public bool EnableFirstPersonPitchSpeedScaling;
        [NMS(Index = 4)]
        /* 0x2A9 */ public bool EnableFirstPersonYawPullback;
        [NMS(Index = 1)]
        /* 0x2AA */ public bool EnableFirstPersonYawTurnSpeedScaling;
        [NMS(Index = 13)]
        /* 0x2AB */ public TkCurveType FirstPersonPitchSpeedCurve;
        [NMS(Index = 7)]
        /* 0x2AC */ public TkCurveType FirstPersonPullBackSpeedCurve;
        [NMS(Index = 3)]
        /* 0x2AD */ public TkCurveType FirstPersonTurnSpeedCurve;
        [NMS(Index = 80)]
        /* 0x2AE */ public TkCurveType LineSagCurve;
        [NMS(Index = 71)]
        /* 0x2AF */ public bool LineUsesLineRenderer;
    }
}
