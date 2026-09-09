using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0x74BAF35344387D69, NameHash = 0x72EA4972)]
    public class GcCharacterGlobals : NMSTemplate
    {
        [NMS(Index = 14)]
        /* 0x000 */ public GcFilename CharacterFile;
        [NMS(Index = 15)]
        /* 0x010 */ public GcSeed CharacterSeedOverride;
        [NMS(Index = 54)]
        /* 0x020 */ public NMSString0x10 LadderClimbDown;
        [NMS(Index = 52)]
        /* 0x030 */ public NMSString0x10 LadderClimbIdle;
        [NMS(Index = 53)]
        /* 0x040 */ public NMSString0x10 LadderClimbUp;
        [NMS(Index = 56)]
        /* 0x050 */ public NMSString0x10 LadderDismountBottom;
        [NMS(Index = 58)]
        /* 0x060 */ public NMSString0x10 LadderDismountTop;
        [NMS(Index = 55)]
        /* 0x070 */ public NMSString0x10 LadderMountBottom;
        [NMS(Index = 57)]
        /* 0x080 */ public NMSString0x10 LadderMountTop;
        [NMS(Index = 2)]
        /* 0x090 */ public NMSString0x10 NPCStaffPropTag;
        [NMS(Index = 9)]
        /* 0x0A0 */ public NMSString0x10 WaterEffectBodyID;
        [NMS(Index = 11)]
        /* 0x0B0 */ public NMSString0x10 WaterEffectLeftHandID;
        [NMS(Index = 10)]
        /* 0x0C0 */ public NMSString0x10 WaterEffectRightHandID;
        [NMS(Index = 31)]
        /* 0x0D0 */ public float AimPitchAnimScale;
        [NMS(Index = 33)]
        /* 0x0D4 */ public float AimPitchInterpSpeed;
        [NMS(Index = 32)]
        /* 0x0D8 */ public float AimYawAnimScale;
        [NMS(Index = 71)]
        /* 0x0DC */ public float BankingMaxStrength;
        [NMS(Index = 70)]
        /* 0x0E0 */ public float BankingMinimumSpeed;
        [NMS(Index = 72)]
        /* 0x0E4 */ public float BankingSpeedForMaxStrength;
        [NMS(Index = 79)]
        /* 0x0E8 */ public float BlendToNewFeetSpeed;
        [NMS(Index = 20)]
        /* 0x0EC */ public float CharacterJetpackTurnAimSpeed;
        [NMS(Index = 19)]
        /* 0x0F0 */ public float CharacterJetpackTurnSpeed;
        [NMS(Index = 12)]
        /* 0x0F4 */ public float CharacterRotationOffsetY;
        [NMS(Index = 13)]
        /* 0x0F8 */ public float CharacterRoughHeadHeight;
        [NMS(Index = 18)]
        /* 0x0FC */ public float CharacterRunTurnSpeed;
        [NMS(Index = 23)]
        /* 0x100 */ public float CharacterSwimmingTurnAimSpeed;
        [NMS(Index = 22)]
        /* 0x104 */ public float CharacterSwimmingTurnSpeed;
        [NMS(Index = 21)]
        /* 0x108 */ public float CharacterTurnAimSpeed;
        [NMS(Index = 17)]
        /* 0x10C */ public float CharacterTurnSpeed;
        [NMS(Index = 16)]
        /* 0x110 */ public float DontShowCharacterWithinCameraDistance;
        [NMS(Index = 27)]
        /* 0x114 */ public float FeetShiftOnTurnMaxSpeed;
        [NMS(Index = 26)]
        /* 0x118 */ public float FeetShiftOnTurnSpeed;
        [NMS(Index = 77)]
        /* 0x11C */ public float FootPlantedTolerance;
        [NMS(Index = 78)]
        /* 0x120 */ public float FootPlantSpring;
        [NMS(Index = 1)]
        /* 0x124 */ public float GravityGunWeaponHoldXRotationDegrees;
        [NMS(Index = 30)]
        /* 0x128 */ public float GunRotationSpeed;
        [NMS(Index = 0)]
        /* 0x12C */ public float HoldWeaponAsPropXRotationDegrees;
        [NMS(Index = 76)]
        /* 0x130 */ public float IkBlendStrengthSpeed;
        [NMS(Index = 75)]
        /* 0x134 */ public float IKLegStretchStrength;
        [NMS(Index = 37)]
        /* 0x138 */ public float JetpackSwimmingPitchRotation;
        [NMS(Index = 51)]
        /* 0x13C */ public float LadderCooldownAfterBeforeAutoClimb;
        [NMS(Index = 50)]
        /* 0x140 */ public float LadderDistanceToAutoMount;
        [NMS(Index = 65)]
        /* 0x144 */ public float MaxAnkleRotationAngle;
        [NMS(Index = 35)]
        /* 0x148 */ public float MaxSwimmingPitchRotation;
        [NMS(Index = 40)]
        /* 0x14C */ public float MaxSwimmingRollRotation;
        [NMS(Index = 73)]
        /* 0x150 */ public float MinimumIdleToJogAnimSpeed;
        [NMS(Index = 89)]
        /* 0x154 */ public float MinStickForIntoJogAnim;
        [NMS(Index = 34)]
        /* 0x158 */ public float MinSwimmingPitchRotation;
        [NMS(Index = 39)]
        /* 0x15C */ public float MinSwimmingRollRotation;
        [NMS(Index = 28)]
        /* 0x160 */ public float MinTurnAngle;
        [NMS(Index = 136)]
        /* 0x164 */ public float NPCActiveListenChance;
        [NMS(Index = 110)]
        /* 0x168 */ public float NPCAnimSpeedMax;
        [NMS(Index = 109)]
        /* 0x16C */ public float NPCAnimSpeedMin;
        [NMS(Index = 122)]
        /* 0x170 */ public float NPCArriveDist;
        [NMS(Index = 111)]
        /* 0x174 */ public float NPCBehaviourTimeModifier;
        [NMS(Index = 168)]
        /* 0x178 */ public float NPCBlockedDestRadius;
        [NMS(Index = 131)]
        /* 0x17C */ public float NPCCamoScanRevealTime;
        [NMS(Index = 130)]
        /* 0x180 */ public float NPCCamoWipeEffectTime;
        [NMS(Index = 127)]
        /* 0x184 */ public float NPCDecelerateStrength;
        [NMS(Index = 180)]
        /* 0x188 */ public float NPCDisplayThoughtsMaxDistance;
        [NMS(Index = 179)]
        /* 0x18C */ public float NPCDisplayThoughtsMaxDuration;
        [NMS(Index = 182)]
        /* 0x190 */ public float NPCDisplayThoughtsProbability;
        [NMS(Index = 181)]
        /* 0x194 */ public float NPCDisplayThoughtsRefreshInterval;
        [NMS(Index = 133)]
        /* 0x198 */ public float NPCFastStaticTurnAngle;
        [NMS(Index = 170)]
        /* 0x19C */ public float NPCFlavourIdleTimeMax;
        [NMS(Index = 169)]
        /* 0x1A0 */ public float NPCFlavourIdleTimeMin;
        [NMS(Index = 99)]
        /* 0x1A4 */ public GcNPCPropType NPCForceProp;
        [NMS(Index = 185)]
        /* 0x1A8 */ public float NPCHackMoveUpToStopFallingThoughFloor;
        [NMS(Index = 105)]
        /* 0x1AC */ public float NPCIKBodyWeightNormal;
        [NMS(Index = 104)]
        /* 0x1B0 */ public float NPCIKBodyWeightNormalGek;
        [NMS(Index = 106)]
        /* 0x1B4 */ public float NPCIKBodyWeightSeated;
        [NMS(Index = 123)]
        /* 0x1B8 */ public float NPCIncreasedSteeringDist;
        [NMS(Index = 145)]
        /* 0x1BC */ public float NPCLookAtTerminateAngle;
        [NMS(Index = 137)]
        /* 0x1C0 */ public float NPCLookAtThingChance;
        [NMS(Index = 140)]
        /* 0x1C4 */ public float NPCLookAtThingTimeMax;
        [NMS(Index = 139)]
        /* 0x1C8 */ public float NPCLookAtThingTimeMin;
        [NMS(Index = 142)]
        /* 0x1CC */ public float NPCLookAwayTimeMax;
        [NMS(Index = 141)]
        /* 0x1D0 */ public float NPCLookAwayTimeMin;
        [NMS(Index = 149)]
        /* 0x1D4 */ public float NPCMaxFreighterInteractionSearchDist;
        [NMS(Index = 148)]
        /* 0x1D8 */ public float NPCMaxInteractionSearchDist;
        [NMS(Index = 143)]
        /* 0x1DC */ public float NPCMaxLookAtAngleMoving;
        [NMS(Index = 144)]
        /* 0x1E0 */ public float NPCMaxLookAtAngleStatic;
        [NMS(Index = 165)]
        /* 0x1E4 */ public float NPCMaxRandomNavPathMaxIndoorOffset;
        [NMS(Index = 167)]
        /* 0x1E8 */ public float NPCMaxRandomNavPathMaxOutdoorOffset;
        [NMS(Index = 164)]
        /* 0x1EC */ public float NPCMaxRandomNavPathMinIndoorOffset;
        [NMS(Index = 166)]
        /* 0x1F0 */ public float NPCMaxRandomNavPathMinOutdoorOffset;
        [NMS(Index = 150)]
        /* 0x1F4 */ public float NPCMaxSettlementInteractionSearchDist;
        [NMS(Index = 135)]
        /* 0x1F8 */ public float NPCMaxStaticTurnSpeed;
        [NMS(Index = 125)]
        /* 0x1FC */ public float NPCMaxTurnSpeed;
        [NMS(Index = 147)]
        /* 0x200 */ public float NPCMinInteractionSearchDist;
        [NMS(Index = 132)]
        /* 0x204 */ public float NPCMinStaticTurnAngle;
        [NMS(Index = 124)]
        /* 0x208 */ public float NPCMinTurnSpeed;
        [NMS(Index = 126)]
        /* 0x20C */ public float NPCMinTurnSpeedMech;
        [NMS(Index = 171)]
        /* 0x210 */ public float NPCMoodIdleDelayChance;
        [NMS(Index = 172)]
        /* 0x214 */ public float NPCMoodIdleLowIntensityChance;
        [NMS(Index = 116)]
        /* 0x218 */ public int NPCNumNavFailuresUntilNoPhysFallback;
        [NMS(Index = 152)]
        /* 0x21C */ public float NPCPerceptionRadius;
        [NMS(Index = 115)]
        /* 0x220 */ public float NPCPermittedNavigationDelayFactor;
        [NMS(Index = 184)]
        /* 0x224 */ public float NPCPOISelectionForActiveGameTableMultiplier;
        [NMS(Index = 183)]
        /* 0x228 */ public float NPCPOISelectionNearbyNPCBaseMultiplier;
        [NMS(Index = 100)]
        /* 0x22C */ public float NPCPropScaleTime;
        [NMS(Index = 102)]
        /* 0x230 */ public float NPCReactCooldown;
        [NMS(Index = 101)]
        /* 0x234 */ public float NPCReactionChance;
        [NMS(Index = 175)]
        /* 0x238 */ public float NPCReactToPlayerPresenceDist;
        [NMS(Index = 177)]
        /* 0x23C */ public float NPCReactToPlayerPresenceGloablCooldown;
        [NMS(Index = 176)]
        /* 0x240 */ public float NPCReactToPlayerPresenceIndividualCooldown;
        [NMS(Index = 178)]
        /* 0x244 */ public float NPCReactToPlayerPresenceStaticTimer;
        [NMS(Index = 120)]
        /* 0x248 */ public float NPCRunSpeed;
        [NMS(Index = 121)]
        /* 0x24C */ public float NPCRunSpeedGek;
        [NMS(Index = 3)]
        /* 0x250 */ public float NPCScalingMaxRandomVariance;
        [NMS(Index = 146)]
        /* 0x254 */ public float NPCSeatedLookAtLateralReduction;
        [NMS(Index = 134)]
        /* 0x258 */ public float NPCSlowStaticTurnAngle;
        [NMS(Index = 107)]
        /* 0x25C */ public float NPCSpineAdjustGek;
        [NMS(Index = 108)]
        /* 0x260 */ public float NPCSpineAdjustVykeen;
        [NMS(Index = 113)]
        /* 0x264 */ public float NPCStaticDistance;
        [NMS(Index = 114)]
        /* 0x268 */ public float NPCStaticTimeUntilFail;
        [NMS(Index = 128)]
        /* 0x26C */ public float NPCStaticTurnTime;
        [NMS(Index = 155)]
        /* 0x270 */ public float NPCSteeringAvoidStrength;
        [NMS(Index = 159)]
        /* 0x274 */ public float NPCSteeringCollisionAvoidAngle;
        [NMS(Index = 160)]
        /* 0x278 */ public float NPCSteeringCollisionAvoidStrength;
        [NMS(Index = 158)]
        /* 0x27C */ public float NPCSteeringComingTowardsDegrees;
        [NMS(Index = 154)]
        /* 0x280 */ public float NPCSteeringFollowStrength;
        [NMS(Index = 153)]
        /* 0x284 */ public float NPCSteeringObstacleAvoidStrength;
        [NMS(Index = 156)]
        /* 0x288 */ public float NPCSteeringRadius;
        [NMS(Index = 162)]
        /* 0x28C */ public float NPCSteeringRayLength;
        [NMS(Index = 163)]
        /* 0x290 */ public float NPCSteeringRaySphereSize;
        [NMS(Index = 161)]
        /* 0x294 */ public float NPCSteeringRaySpread;
        [NMS(Index = 157)]
        /* 0x298 */ public float NPCSteeringRepelDist;
        [NMS(Index = 151)]
        /* 0x29C */ public float NPCSteeringSpringTime;
        [NMS(Index = 129)]
        /* 0x2A0 */ public float NPCTeleportEffectTime;
        [NMS(Index = 118)]
        /* 0x2A4 */ public float NPCWalkSpeed;
        [NMS(Index = 119)]
        /* 0x2A8 */ public float NPCWalkSpeedGek;
        [NMS(Index = 117)]
        /* 0x2AC */ public float NPCWalkSpeedMech;
        [NMS(Index = 103)]
        /* 0x2B0 */ public float NPCWithScanEventReactCooldown;
        [NMS(Index = 173)]
        /* 0x2B4 */ public float NPCWithScanEventReactToPlayerPresenceDist;
        [NMS(Index = 174)]
        /* 0x2B8 */ public float NPCWithScanEventReactToPlayerPresenceIndividualCooldown;
        [NMS(Index = 4)]
        /* 0x2BC */ public float PitchTest;
        [NMS(Index = 85)]
        /* 0x2C0 */ public float RagdollConeLimit;
        [NMS(Index = 84)]
        /* 0x2C4 */ public float RagdollDamping;
        [NMS(Index = 88)]
        /* 0x2C8 */ public float RagdollMotorFadeEnd;
        [NMS(Index = 87)]
        /* 0x2CC */ public float RagdollMotorFadeStart;
        [NMS(Index = 83)]
        /* 0x2D0 */ public float RagdollTau;
        [NMS(Index = 86)]
        /* 0x2D4 */ public float RagdollTwistLimit;
        [NMS(Index = 24)]
        /* 0x2D8 */ public float RocketBootsLandedTurnSpeed;
        [NMS(Index = 25)]
        /* 0x2DC */ public float RocketBootsTurnSpeed;
        [NMS(Index = 5)]
        /* 0x2E0 */ public float RollTest;
        [NMS(Index = 74)]
        /* 0x2E4 */ public float RootedAnimInterpolationTime;
        [NMS(Index = 66)]
        /* 0x2E8 */ public float RotateToFaceSlopeSpeed;
        [NMS(Index = 38)]
        /* 0x2EC */ public float RoughSeaIdleSwimmingPitchRotation;
        [NMS(Index = 96)]
        /* 0x2F0 */ public float SitPostureChangeTimeMax;
        [NMS(Index = 95)]
        /* 0x2F4 */ public float SitPostureChangeTimeMin;
        [NMS(Index = 61)]
        /* 0x2F8 */ public float SlidingBrake;
        [NMS(Index = 60)]
        /* 0x2FC */ public float SlopeAngleForDownhillClimb;
        [NMS(Index = 62)]
        /* 0x300 */ public float SlopeAngleForSlide;
        [NMS(Index = 59)]
        /* 0x304 */ public float SlopeAngleForUphillClimb;
        [NMS(Index = 90)]
        /* 0x308 */ public float SmoothVelocitySpeed;
        [NMS(Index = 46)]
        /* 0x30C */ public float SpacewalkWeaponLeanPitchRotation;
        [NMS(Index = 49)]
        /* 0x310 */ public float SpacewalkWeaponLeanSmoothTime;
        [NMS(Index = 48)]
        /* 0x314 */ public float SpacewalkWeaponLeanSpeedMax;
        [NMS(Index = 47)]
        /* 0x318 */ public float SpacewalkWeaponLeanSpeedMin;
        [NMS(Index = 36)]
        /* 0x31C */ public float SwimmingPitchRotationSurfaceExtra;
        [NMS(Index = 44)]
        /* 0x320 */ public float SwimmingRollSmoothTime;
        [NMS(Index = 45)]
        /* 0x324 */ public float SwimmingRollSmoothTimeWithWeapon;
        [NMS(Index = 42)]
        /* 0x328 */ public float SwimmingSmoothTime;
        [NMS(Index = 41)]
        /* 0x32C */ public float SwimmingSmoothTimeMin;
        [NMS(Index = 43)]
        /* 0x330 */ public float SwimmingSmoothTimeWithWeapon;
        [NMS(Index = 81)]
        /* 0x334 */ public float TimeAfterDeathRagdollIsEnabledBackward;
        [NMS(Index = 80)]
        /* 0x338 */ public float TimeAfterDeathRagdollIsEnabledForward;
        [NMS(Index = 82)]
        /* 0x33C */ public float TimeAfterDeathRagdollIsEnabledWhenBlocked;
        [NMS(Index = 69)]
        /* 0x340 */ public float TimeFallingUntilPanic;
        [NMS(Index = 67)]
        /* 0x344 */ public float TimeNotOnGroundToBeConsideredInAir;
        [NMS(Index = 68)]
        /* 0x348 */ public float TimeNotOnGroundToUseFallingCamera;
        [NMS(Index = 91)]
        /* 0x34C */ public float TimeToShowSplashEffect;
        [NMS(Index = 64)]
        /* 0x350 */ public float TrudgeUphillSpeed;
        [NMS(Index = 92)]
        /* 0x354 */ public float UnderwaterToAirTolerance;
        [NMS(Index = 63)]
        /* 0x358 */ public float UphillSpeedMultiplier;
        [NMS(Index = 93)]
        /* 0x35C */ public float WaterBottomSmoothPushUp;
        [NMS(Index = 94)]
        /* 0x360 */ public float WaterBottomSmoothPushUpDepth;
        [NMS(Index = 6)]
        /* 0x364 */ public float WaterEffectFadeSpring;
        [NMS(Index = 7)]
        /* 0x368 */ public float WaterEffectSpeedFadeMax;
        [NMS(Index = 8)]
        /* 0x36C */ public float WaterEffectSpeedFadeMin;
        [NMS(Index = 29)]
        /* 0x370 */ public float YawPullSpeed;
        [NMS(Index = 112)]
        /* 0x374 */ public bool NPCBehaviourInfo;
        [NMS(Index = 98)]
        /* 0x375 */ public bool NPCLightsAlwaysOn;
        [NMS(Index = 138)]
        /* 0x376 */ public bool NPCLookAtEnabled;
        [NMS(Index = 97)]
        /* 0x377 */ public bool NPCUseBehaviourTree;
    }
}
