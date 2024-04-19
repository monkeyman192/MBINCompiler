using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0x7F874A3588713672, NameHash = 0x7B6EECDDCAF6F923)]
    public class GcAudioGlobals : NMSTemplate
    {
        /* 0x000 */ public List<float> ByteBeatScaleDegreeProbability;
        /* 0x010 */ public GcAudioNPCDoppler NPCEngines;
        /* 0x064 */ public GcAudio3PointDopplerData DroneDoppler;
        /* 0x070 */ public Vector2f ByteBeatSpeakerMaxAmplitude;
        /* 0x078 */ public Vector2f ByteBeatSpeakerMaxFrequency;
        /* 0x080 */ public Vector2f ByteBeatSpeakerMinFrequency;
        /* 0x088 */ public Vector2f CommsChatterFalloffFreighers;
        /* 0x090 */ public Vector2f CommsChatterFalloffShips;
        /* 0x098 */ public Vector2f ShorelineSenseRadius;
        /* 0x0A0 */ public Vector2f ShorelineSenseUJitter;
        /* 0x0A8 */ public Vector2f ShorelineSenseVJitter;
        /* 0x0B0 */ public float ArmFoleySpeedMultiplier;
        /* 0x0B4 */ public float ArmWhooshFoleyValueTrigger;
        /* 0x0B8 */ public float AtlasStationActiveDistance;
        /* 0x0BC */ public float AuxSendCaveRampDistance;
        /* 0x0C0 */ public float AuxSendOutdoorsRampDistance;
        /* 0x0C4 */ public float ByteBeatBeginAtTonicProbability;
        /* 0x0C8 */ public float ByteBeatChangeNoteProbability;
        /* 0x0CC */ public float ByteBeatCrossfadeTime;
        /* 0x0D0 */ public float ByteBeatDrumMixHigh;
        /* 0x0D4 */ public float ByteBeatDrumMixLow;
        /* 0x0D8 */ public int ByteBeatMaxGeneratingAudio;
        /* 0x0DC */ public int ByteBeatNonSilentAttempts;
        /* 0x0E0 */ public float ByteBeatNonSilentAvgInterpSpeed;
        /* 0x0E4 */ public float ByteBeatNonSilentSDCutoff;
        /* 0x0E8 */ public float ByteBeatNonSilentTime;
        /* 0x0EC */ public float ByteBeatPlayerFadeOut;
        /* 0x0F0 */ public int ByteBeatPlayerNumLoops;
        /* 0x0F4 */ public float ByteBeatSkipNoteProbability;
        /* 0x0F8 */ public float ByteBeatSpeakerVolumeInterSpeed;
        /* 0x0FC */ public float ByteBeatSynthMixHigh;
        /* 0x100 */ public float ByteBeatSynthMixLow;
        /* 0x104 */ public int ByteBeatVisualisationMiniPixelStep;
        /* 0x108 */ public int ByteBeatVisualisationMode;
        /* 0x10C */ public int ByteBeatVisualisationPixelStep;
        /* 0x110 */ public float ByteBeatVisualisationTime;
        /* 0x114 */ public float DistanceReportMax;
        /* 0x118 */ public float DistanceReportMin;
        /* 0x11C */ public float DistanceSquishMaxTravel;
        /* 0x120 */ public float DistanceSquishScaleToListener;
        /* 0x124 */ public float DroneDopplerExtentsFactor;
        /* 0x128 */ public float LadderStepDistance;
        /* 0x12C */ public float MiniStationActiveDistance;
        /* 0x130 */ public float MinSecondsBetweenArmWhooshes;
        /* 0x134 */ public float ObstructionAuxControlWhenHidden;
        /* 0x138 */ public float ObstructionAuxControlWhenVisible;
        /* 0x13C */ public float ObstructionSmoothTime;
        /* 0x140 */ public float ObstructionValueMax;
        /* 0x144 */ public float PlayerDepthUnderwaterMax;
        /* 0x148 */ public float PlayerLowerOffsetEmitterMul;
        /* 0x14C */ public float ShorelineObstructionMul;
        /* 0x150 */ public float ShorelineObstructionSmoothRate;
        /* 0x154 */ public float ShorelineRTPCSmoothRate;
        /* 0x158 */ public float ShorelineSenseBaseU;
        /* 0x15C */ public float ShorelineSenseBlend;
        /* 0x160 */ public float ShorelineSenseProbeDist;
        /* 0x164 */ public float ShorelineSenseStartUp;
        /* 0x168 */ public float ShorelineValidityRate;
        /* 0x16C */ public bool EnableVRSpecificAudio;
        /* 0x16D */ public bool LockListenerMatrix;
        /* 0x16E */ public bool ObstructionEnabled;
        /* 0x16F */ public bool PulseMusicEnabled;
    }
}
