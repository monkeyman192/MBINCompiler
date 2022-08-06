using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0x916D68D153BCF764, NameHash = 0x7B6EECDDCAF6F923)]
    public class GcAudioGlobals : NMSTemplate
    {
        /* 0x000 */ public GcAudioNPCDoppler NPCEngines;
        /* 0x054 */ public GcAudio3PointDopplerData DroneDoppler;
        /* 0x060 */ public float AuxSendCaveRampDistance;
        /* 0x064 */ public float AuxSendOutdoorsRampDistance;
        /* 0x068 */ public float LadderStepDistance;
        /* 0x06C */ public float ShorelineSenseStartUp;
        /* 0x070 */ public float ShorelineSenseProbeDist;
        /* 0x074 */ public float ShorelineSenseBlend;
        /* 0x078 */ public float ShorelineSenseBaseU;
        /* 0x07C */ public Vector2f ShorelineSenseUJitter;
        /* 0x084 */ public Vector2f ShorelineSenseVJitter;
        /* 0x08C */ public Vector2f ShorelineSenseRadius;
        /* 0x094 */ public float ShorelineValidityRate;
        /* 0x098 */ public float ShorelineRTPCSmoothRate;
        /* 0x09C */ public float ShorelineObstructionSmoothRate;
        /* 0x0A0 */ public float ShorelineObstructionMul;
        /* 0x0A4 */ public float DroneDopplerExtentsFactor;
        /* 0x0A8 */ public float DistanceReportMin;
        /* 0x0AC */ public float DistanceReportMax;
        /* 0x0B0 */ public float DistanceSquishScaleToListener;
        /* 0x0B4 */ public float DistanceSquishMaxTravel;
        /* 0x0B8 */ public int ByteBeatMaxGeneratingAudio;
        /* 0x0BC */ public float ByteBeatCrossfadeTime;
        /* 0x0C0 */ public float ByteBeatVisualisationTime;
        /* 0x0C4 */ public int ByteBeatVisualisationMode;
        /* 0x0C8 */ public int ByteBeatVisualisationPixelStep;
        /* 0x0CC */ public int ByteBeatVisualisationMiniPixelStep;
        /* 0x0D0 */ public int ByteBeatNonSilentAttempts;
        /* 0x0D4 */ public float ByteBeatNonSilentTime;
        /* 0x0D8 */ public float ByteBeatNonSilentAvgInterpSpeed;
        /* 0x0DC */ public float ByteBeatNonSilentSDCutoff;
        /* 0x0E0 */ public float ByteBeatBeginAtTonicProbability;
        /* 0x0E4 */ public float ByteBeatChangeNoteProbability;
        /* 0x0E8 */ public float ByteBeatSkipNoteProbability;
        /* 0x0F0 */ public List<float> ByteBeatScaleDegreeProbability;
        /* 0x100 */ public float ByteBeatSpeakerVolumeInterSpeed;
        /* 0x104 */ public Vector2f ByteBeatSpeakerMaxAmplitude;
        /* 0x10C */ public Vector2f ByteBeatSpeakerMinFrequency;
        /* 0x114 */ public Vector2f ByteBeatSpeakerMaxFrequency;
        /* 0x11C */ public int ByteBeatPlayerNumLoops;
        /* 0x120 */ public float ByteBeatPlayerFadeOut;
        /* 0x124 */ public float ByteBeatDrumMixLow;
        /* 0x128 */ public float ByteBeatDrumMixHigh;
        /* 0x12C */ public float ByteBeatSynthMixLow;
        /* 0x130 */ public float ByteBeatSynthMixHigh;
        /* 0x134 */ public float AtlasStationActiveDistance;
        /* 0x138 */ public float MiniStationActiveDistance;
        /* 0x13C */ public float PlayerDepthUnderwaterMax;
        /* 0x140 */ public float PlayerLowerOffsetEmitterMul;
        /* 0x144 */ public bool ObstructionEnabled;
        /* 0x148 */ public float ObstructionSmoothTime;
        /* 0x14C */ public float ObstructionValueMax;
        /* 0x150 */ public float ObstructionAuxControlWhenVisible;
        /* 0x154 */ public float ObstructionAuxControlWhenHidden;
        /* 0x158 */ public bool PulseMusicEnabled;
        /* 0x159 */ public bool LockListenerMatrix;
        /* 0x15A */ public bool EnableVRSpecificAudio;
        /* 0x15C */ public float ArmFoleySpeedMultiplier;
        /* 0x160 */ public float ArmWhooshFoleyValueTrigger;
        /* 0x164 */ public float MinSecondsBetweenArmWhooshes;
        /* 0x168 */ public Vector2f CommsChatterFalloffFreighers;
        /* 0x170 */ public Vector2f CommsChatterFalloffShips;
    }
}
