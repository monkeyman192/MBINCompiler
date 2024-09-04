using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0xB81F7CE0CE587578, NameHash = 0x2BDD54A8)]
    public class GcAudioGlobals : NMSTemplate
    {
        [NMS(Index = 34)]
        /* 0x000 */ public List<float> ByteBeatScaleDegreeProbability;
        [NMS(Index = 0)]
        /* 0x010 */ public GcAudioNPCDoppler NPCEngines;
        [NMS(Index = 1)]
        /* 0x064 */ public GcAudio3PointDopplerData DroneDoppler;
        [NMS(Index = 36)]
        /* 0x070 */ public Vector2f ByteBeatSpeakerMaxAmplitude;
        [NMS(Index = 38)]
        /* 0x078 */ public Vector2f ByteBeatSpeakerMaxFrequency;
        [NMS(Index = 37)]
        /* 0x080 */ public Vector2f ByteBeatSpeakerMinFrequency;
        [NMS(Index = 62)]
        /* 0x088 */ public Vector2f CommsChatterFalloffFreighers;
        [NMS(Index = 63)]
        /* 0x090 */ public Vector2f CommsChatterFalloffShips;
        [NMS(Index = 11)]
        /* 0x098 */ public Vector2f ShorelineSenseRadius;
        [NMS(Index = 9)]
        /* 0x0A0 */ public Vector2f ShorelineSenseUJitter;
        [NMS(Index = 10)]
        /* 0x0A8 */ public Vector2f ShorelineSenseVJitter;
        [NMS(Index = 59)]
        /* 0x0B0 */ public float ArmFoleySpeedMultiplier;
        [NMS(Index = 60)]
        /* 0x0B4 */ public float ArmWhooshFoleyValueTrigger;
        [NMS(Index = 45)]
        /* 0x0B8 */ public float AtlasStationActiveDistance;
        [NMS(Index = 2)]
        /* 0x0BC */ public float AuxSendCaveRampDistance;
        [NMS(Index = 3)]
        /* 0x0C0 */ public float AuxSendOutdoorsRampDistance;
        [NMS(Index = 31)]
        /* 0x0C4 */ public float ByteBeatBeginAtTonicProbability;
        [NMS(Index = 32)]
        /* 0x0C8 */ public float ByteBeatChangeNoteProbability;
        [NMS(Index = 22)]
        /* 0x0CC */ public float ByteBeatCrossfadeTime;
        [NMS(Index = 42)]
        /* 0x0D0 */ public float ByteBeatDrumMixHigh;
        [NMS(Index = 41)]
        /* 0x0D4 */ public float ByteBeatDrumMixLow;
        [NMS(Index = 21)]
        /* 0x0D8 */ public int ByteBeatMaxGeneratingAudio;
        [NMS(Index = 27)]
        /* 0x0DC */ public int ByteBeatNonSilentAttempts;
        [NMS(Index = 29)]
        /* 0x0E0 */ public float ByteBeatNonSilentAvgInterpSpeed;
        [NMS(Index = 30)]
        /* 0x0E4 */ public float ByteBeatNonSilentSDCutoff;
        [NMS(Index = 28)]
        /* 0x0E8 */ public float ByteBeatNonSilentTime;
        [NMS(Index = 40)]
        /* 0x0EC */ public float ByteBeatPlayerFadeOut;
        [NMS(Index = 39)]
        /* 0x0F0 */ public int ByteBeatPlayerNumLoops;
        [NMS(Index = 33)]
        /* 0x0F4 */ public float ByteBeatSkipNoteProbability;
        [NMS(Index = 35)]
        /* 0x0F8 */ public float ByteBeatSpeakerVolumeInterSpeed;
        [NMS(Index = 44)]
        /* 0x0FC */ public float ByteBeatSynthMixHigh;
        [NMS(Index = 43)]
        /* 0x100 */ public float ByteBeatSynthMixLow;
        [NMS(Index = 26)]
        /* 0x104 */ public int ByteBeatVisualisationMiniPixelStep;
        [NMS(Index = 24)]
        /* 0x108 */ public int ByteBeatVisualisationMode;
        [NMS(Index = 25)]
        /* 0x10C */ public int ByteBeatVisualisationPixelStep;
        [NMS(Index = 23)]
        /* 0x110 */ public float ByteBeatVisualisationTime;
        [NMS(Index = 18)]
        /* 0x114 */ public float DistanceReportMax;
        [NMS(Index = 17)]
        /* 0x118 */ public float DistanceReportMin;
        [NMS(Index = 20)]
        /* 0x11C */ public float DistanceSquishMaxTravel;
        [NMS(Index = 19)]
        /* 0x120 */ public float DistanceSquishScaleToListener;
        [NMS(Index = 16)]
        /* 0x124 */ public float DroneDopplerExtentsFactor;
        [NMS(Index = 55)]
        /* 0x128 */ public float FishingMusicRampInTime;
        [NMS(Index = 56)]
        /* 0x12C */ public float FishingMusicRampOutTime;
        [NMS(Index = 4)]
        /* 0x130 */ public float LadderStepDistance;
        [NMS(Index = 46)]
        /* 0x134 */ public float MiniStationActiveDistance;
        [NMS(Index = 61)]
        /* 0x138 */ public float MinSecondsBetweenArmWhooshes;
        [NMS(Index = 53)]
        /* 0x13C */ public float ObstructionAuxControlWhenHidden;
        [NMS(Index = 52)]
        /* 0x140 */ public float ObstructionAuxControlWhenVisible;
        [NMS(Index = 50)]
        /* 0x144 */ public float ObstructionSmoothTime;
        [NMS(Index = 51)]
        /* 0x148 */ public float ObstructionValueMax;
        [NMS(Index = 47)]
        /* 0x14C */ public float PlayerDepthUnderwaterMax;
        [NMS(Index = 48)]
        /* 0x150 */ public float PlayerLowerOffsetEmitterMul;
        [NMS(Index = 15)]
        /* 0x154 */ public float ShorelineObstructionMul;
        [NMS(Index = 14)]
        /* 0x158 */ public float ShorelineObstructionSmoothRate;
        [NMS(Index = 13)]
        /* 0x15C */ public float ShorelineRTPCSmoothRate;
        [NMS(Index = 8)]
        /* 0x160 */ public float ShorelineSenseBaseU;
        [NMS(Index = 7)]
        /* 0x164 */ public float ShorelineSenseBlend;
        [NMS(Index = 6)]
        /* 0x168 */ public float ShorelineSenseProbeDist;
        [NMS(Index = 5)]
        /* 0x16C */ public float ShorelineSenseStartUp;
        [NMS(Index = 12)]
        /* 0x170 */ public float ShorelineValidityRate;
        [NMS(Index = 58)]
        /* 0x174 */ public bool EnableVRSpecificAudio;
        [NMS(Index = 57)]
        /* 0x175 */ public bool LockListenerMatrix;
        [NMS(Index = 49)]
        /* 0x176 */ public bool ObstructionEnabled;
        [NMS(Index = 54)]
        /* 0x177 */ public bool PulseMusicEnabled;
    }
}
