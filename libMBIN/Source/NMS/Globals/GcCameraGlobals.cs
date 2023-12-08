using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0x9735EEE7C2BF7221, NameHash = 0xA826BCA4D4C3DFE3)]
    public class GcCameraGlobals : NMSTemplate
    {
        /* 0x0000 */ public float ScanCameraLookAtTime;
        /* 0x0008 */ public List<GcCameraAerialViewDataTableEntry> AerialViewDataTable;
        /* 0x0018 */ public float SClassLandingShakeMultiplier;
        /* 0x001C */ public bool OffsetCombatCameraHorizontal;
        /* 0x0020 */ public float OffsetCombatCameraHorizontalAngle;
        /* 0x0030 */ public TkModelRendererData FreighterCustomisationStandardCamera;
        /* 0x00F0 */ public TkModelRendererData FreighterCustomisationStandardCameraAlt;
        /* 0x01B0 */ public List<GcCameraFollowSettings> Cameras;
        /* 0x01C0 */ public GcCameraFollowSettings VehicleCamHmd;
        /* 0x02B8 */ public GcCameraFollowSettings VehicleCam;
        /* 0x03B0 */ public GcCameraFollowSettings MechFirstPersonCam;
        /* 0x04A8 */ public float RevealedNPCHeadOffset;
        /* 0x04AC */ public float SpecialVehicleMouseRecentreTime;
        /* 0x04B0 */ public float SpecialVehicleMouseRecentreWeaponTime;
        /* 0x04B4 */ public float HmdEyeLookAngle;
        /* 0x04B8 */ public float HmdEyeExtraTurnAngle;
        /* 0x04BC */ public float HmdEyeExtraTurnMinHeadAngle;
        /* 0x04C0 */ public float HmdEyeExtraTurnHeadAngleRange;
        /* 0x04C4 */ public bool PauseThirdPersonCamInPause;
        /* 0x04C8 */ public float DebugPlanetJumpNearHeight;
        /* 0x04CC */ public float DebugPlanetJumpFarHeight;
        /* 0x04D0 */ public float TogglePerspectiveBlendTime;
        /* 0x04D4 */ public bool LockFollowSpring;
        /* 0x04D8 */ public float UnderwaterCameraSurfaceOffset;
        /* 0x04DC */ public float UnderwaterCameraVertRotationForExtraOffsetMin;
        /* 0x04E0 */ public float UnderwaterCameraVertRotationForExtraOffsetMax;
        /* 0x04E4 */ public float UnderwaterCameraExtraVertOffset;
        /* 0x04E8 */ public float ThirdPersonAfterIntroCamBlendTime;
        /* 0x04EC */ public float ThirdPersonSkipIntroCamBlendTime;
        /* 0x04F0 */ public float MiniportalFlashTime;
        /* 0x04F4 */ public float MiniportalFlashStrength;
        /* 0x0500 */ public Colour MiniportalFlashColour;
        /* 0x0510 */ public float VehicleExitFlashTime;
        /* 0x0514 */ public float VehicleExitFlashStrength;
        /* 0x0520 */ public Colour VehicleExitFlashColour;
        /* 0x0530 */ public float VehicleFirstToThirdExitOffsetY;
        /* 0x0534 */ public float VehicleFirstToThirdExitOffsetZ;
        /* 0x0538 */ public float ShipThirdPersonBlendTime;
        /* 0x053C */ public float ShipThirdPersonBlendWithOffsetTime;
        /* 0x0540 */ public float ShipThirdPersonBlendOffset;
        /* 0x0544 */ public float ShipThirdPersonBlendOutTime;
        /* 0x0548 */ public float ShipThirdPersonBlendOutOffset;
        /* 0x054C */ public float ShipFirstPersonBlendTime;
        /* 0x0550 */ public float ShipFirstPersonBlendOffset;
        /* 0x0554 */ public float ShipThirdPersonEnterBlendTime;
        /* 0x0558 */ public float ShipThirdPersonEnterBlendOffset;
        /* 0x055C */ public float FlybyMinRange;
        /* 0x0560 */ public float FlybyRange;
        /* 0x0564 */ public float FlybyMinRelativeSpeed;
        /* 0x0568 */ public float FlybyRelativeSpeedRange;
        /* 0x056C */ public float FlybyInVehicleDamper;
        /* 0x0570 */ public float BinocularFlashTime;
        /* 0x0574 */ public float BinocularFlashStrength;
        /* 0x0578 */ public float MinFirstPersonCameraPitch;
        /* 0x057C */ public float MaxFirstPersonCameraPitch;
        /* 0x0580 */ public float MaxCreatureRidingYaw;
        /* 0x0584 */ public float ThirdPersonRotationBackAdjustAngleMin;
        /* 0x0588 */ public float ThirdPersonClosePitch;
        /* 0x058C */ public float ThirdPersonCloseDistance;
        /* 0x0590 */ public float ThirdPersonCloseDistanceX;
        /* 0x0594 */ public float ThirdPersonRotationBackAdjustAngleMax;
        /* 0x0598 */ public float ThirdPersonUphillAdjustSpringTimeMin;
        /* 0x059C */ public float ThirdPersonUphillAdjustSpringTimeMax;
        /* 0x05A0 */ public float ThirdPersonDownhillAdjustSpringTimeMin;
        /* 0x05A4 */ public float ThirdPersonDownhillAdjustSpringTimeMax;
        /* 0x05A8 */ public float ThirdPersonDownhillAdjustMinAngle;
        /* 0x05AC */ public float ThirdPersonDownhillAdjustMaxAngle;
        /* 0x05B0 */ public float ThirdPersonUphillAdjustMinAngle;
        /* 0x05B4 */ public float ThirdPersonUphillAdjustMaxAngle;
        /* 0x05B8 */ public float ThirdPersonDownhillAdjustMinAnglePrime;
        /* 0x05BC */ public float ThirdPersonDownhillAdjustMaxAnglePrime;
        /* 0x05C0 */ public float ThirdPersonUphillAdjustMinAnglePrime;
        /* 0x05C4 */ public float ThirdPersonUphillAdjustMaxAnglePrime;
        /* 0x05C8 */ public float ThirdPersonUphillAdjustCrossSlopeMinAngle;
        /* 0x05CC */ public float ThirdPersonUphillAdjustCrossSlopeMaxAngle;
        /* 0x05D0 */ public float VehicleThirdPersonShootOffsetReturnTime;
        /* 0x05D4 */ public float VehicleThirdPersonShootOffsetBlendOutTime;
        /* 0x05D8 */ public float MechCameraNoExtraYTimeAfterLand;
        /* 0x05DC */ public float MechCameraExtraYPostLandingBlendTime;
        /* 0x05E0 */ public float MechCameraArmShootOffsetY;
        /* 0x05E4 */ public float MechCameraCombatFakeSpeed;
        /* 0x05E8 */ public GcCameraFollowSettings CharacterUnarmedCam;
        /* 0x06E0 */ public GcCameraFollowSettings CharacterRunCam;
        /* 0x07D8 */ public GcCameraFollowSettings CharacterCombatCam;
        /* 0x08D0 */ public GcCameraFollowSettings CharacterMiningCam;
        /* 0x09C8 */ public GcCameraFollowSettings CharacterIndoorCam;
        /* 0x0AC0 */ public GcCameraFollowSettings CharacterAbandCombatCam;
        /* 0x0BB8 */ public GcCameraFollowSettings CharacterAbandCam;
        /* 0x0CB0 */ public GcCameraFollowSettings CharacterNexusCam;
        /* 0x0DA8 */ public GcCameraFollowSettings CharacterAirborneCam;
        /* 0x0EA0 */ public GcCameraFollowSettings CharacterMeleeBoostCam;
        /* 0x0F98 */ public GcCameraFollowSettings CharacterRocketBootsCam;
        /* 0x1090 */ public GcCameraFollowSettings CharacterRocketBootsChargeCam;
        /* 0x1188 */ public GcCameraFollowSettings CharacterFallingCam;
        /* 0x1280 */ public GcCameraFollowSettings CharacterAirborneCombatCam;
        /* 0x1378 */ public GcCameraFollowSettings CharacterSpaceCam;
        /* 0x1470 */ public GcCameraFollowSettings CharacterSteepSlopeCam;
        /* 0x1568 */ public GcCameraFollowSettings CharacterUnderwaterCam;
        /* 0x1660 */ public GcCameraFollowSettings CharacterUnderwaterCombatCam;
        /* 0x1758 */ public GcCameraFollowSettings CharacterUnderwaterJetpackCam;
        /* 0x1850 */ public GcCameraFollowSettings CharacterGrabbedCam;
        /* 0x1948 */ public GcCameraFollowSettings CharacterSitCam;
        /* 0x1A40 */ public GcCameraFollowSettings CharacterRideCam;
        /* 0x1B38 */ public GcCameraFollowSettings CharacterRideCamMedium;
        /* 0x1C30 */ public GcCameraFollowSettings CharacterRideCamLarge;
        /* 0x1D28 */ public GcCameraFollowSettings CharacterRideCamHuge;
        /* 0x1E20 */ public float ThirdPersonCameraChangeBlendTime;
        /* 0x1E24 */ public float ThirdPersonCameraChangeMinimumBlend;
        /* 0x1E28 */ public GcCameraFollowSettings BuggyFollowCam;
        /* 0x1F20 */ public GcCameraFollowSettings HovercraftFollowCam;
        /* 0x2018 */ public GcCameraFollowSettings SubmarineFollowCam;
        /* 0x2110 */ public GcCameraFollowSettings BikeFollowCam;
        /* 0x2208 */ public GcCameraFollowSettings WheeledBikeFollowCam;
        /* 0x2300 */ public GcCameraFollowSettings TruckFollowCam;
        /* 0x23F8 */ public GcCameraFollowSettings MechFollowCam;
        /* 0x24F0 */ public GcCameraFollowSettings MechCombatCam;
        /* 0x25E8 */ public GcCameraFollowSettings MechJetpackCam;
        /* 0x26E0 */ public GcCameraFollowSettings SpaceshipFollowCam;
        /* 0x27D8 */ public GcCameraFollowSettings DropshipFollowCam;
        /* 0x28D0 */ public GcCameraFollowSettings ShuttleFollowCam;
        /* 0x29C8 */ public GcCameraFollowSettings RoyalShipFollowCam;
        /* 0x2AC0 */ public GcCameraFollowSettings SailShipFollowCam;
        /* 0x2BB8 */ public GcCameraFollowSettings ScienceShipFollowCam;
        /* 0x2CB0 */ public GcCameraFollowSettings AlienShipFollowCam;
        /* 0x2DA8 */ public GcCameraFollowSettings RobotShipFollowCam;
        /* 0x2EA0 */ public GcCameraFollowSettings BuildingIndoorsCam;
        /* 0x2F98 */ public GcCameraFollowSettings BuildingOutdoorsCam;
        /* 0x3090 */ public GcCameraFollowSettings BuildingUnderwaterCam;
        /* 0x3188 */ public float FrontendModelCameraSpringTime;
        /* 0x318C */ public float ModelViewFlashTime;
        /* 0x3190 */ public Vector3f ModelViewOffset;
        /* 0x31A0 */ public Vector2f ModelViewFocusOffset;
        /* 0x31B0 */ public Vector3f InteractionOffset;
        /* 0x31C0 */ public Vector3f InteractionOffsetExtraVR;
        /* 0x31D0 */ public Vector3f InteractionOffsetExtraVRSeated;
        /* 0x31E0 */ public Vector3f ShopInteractionOffsetExtraVR;
        /* 0x31F0 */ public Vector3f ShopInteractionOffsetExtraVRSeated;
        /* 0x3200 */ public Vector3f InteractionOffsetDefault;
        /* 0x3210 */ public Vector3f InteractionOffsetGek;
        /* 0x3220 */ public Vector3f InteractionOffsetSpiderman;
        /* 0x3230 */ public Vector3f InteractionShipFocusOffset;
        /* 0x3240 */ public Vector3f InteractionHailingFocusOffset;
        /* 0x3250 */ public Vector3f InteractionOffsetRecruitment;
        /* 0x3260 */ public float InteractionHeadHeightDefault;
        /* 0x3264 */ public float InteractionHeadHeightGek;
        /* 0x3268 */ public float InteractionHeadHeightVykeen;
        /* 0x326C */ public float InteractionHeadHeightSpiderman;
        /* 0x3270 */ public float InteractionPitchAdjustTime;
        /* 0x3274 */ public float InteractionPitchAdjustStrength;
        /* 0x3278 */ public float InteractionPitchAdjustDeadZone;
        /* 0x327C */ public float InteractionHeadPosHeightAdjust;
        /* 0x3280 */ public float InteractionHeadPosHeightAdjustVykeen;
        /* 0x3284 */ public float InteractionHeadPosHeightAdjustSpiderman;
        /* 0x3288 */ public float FrigateCaptainLateralShiftAmount;
        /* 0x328C */ public float PilotDetailsLateralShiftAmount;
        /* 0x3290 */ public float RecruitmentLateralShiftAmount;
        /* 0x3294 */ public float NPCTradeLateralShiftAmount;
        /* 0x3298 */ public float LocalMissionBoardLateralShiftAmount;
        /* 0x329C */ public float NPCTradeLateralShiftTime;
        /* 0x32A0 */ public float DistanceForFleetInteraction;
        /* 0x32A4 */ public float DistanceForFrigateInteraction;
        /* 0x32A8 */ public float DistanceForFrigatePurchaseInteraction;
        /* 0x32B0 */ public Vector3f OffsetForFleetInteraction;
        /* 0x32C0 */ public Vector3f OffsetForFrigateInteraction;
        /* 0x32D0 */ public float FleetUIOrbitRate;
        /* 0x32D4 */ public float FleetUIVerticalMotionDuration;
        /* 0x32D8 */ public float FleetUIVerticalMotionAmplitude;
        /* 0x32DC */ public Vector2f PitchForFrigateInteraction;
        /* 0x32E4 */ public Vector2f RotationForFrigateInteraction;
        /* 0x32EC */ public float InteractionModeBlendTime;
        /* 0x32F0 */ public float InteractionModeFocusCamBlend;
        /* 0x32F4 */ public float InteractionModeFoV;
        /* 0x32F8 */ public float MinInteractFocusAngle;
        /* 0x32FC */ public float ModelViewInterpTime;
        /* 0x3300 */ public float ThirdPersonBlendInTime;
        /* 0x3304 */ public float ThirdPersonBlendOutTime;
        /* 0x3308 */ public float ThirdPersonCollisionPushOffsetReducerStart;
        /* 0x330C */ public float ThirdPersonOffsetSpringTime;
        /* 0x3310 */ public bool MaxBob;
        /* 0x3314 */ public float PhotoModeVelocitySmoothTime;
        /* 0x3318 */ public float PhotoModeMoveSpeed;
        /* 0x331C */ public float PhotoModeTurnSpeed;
        /* 0x3320 */ public float PhotoModeMaxDistance;
        /* 0x3324 */ public float PhotoModeMaxDistanceSpace;
        /* 0x3328 */ public float PhotoModeMaxDistanceClampForce;
        /* 0x332C */ public float PhotoModeMaxDistanceClampBuffer;
        /* 0x3330 */ public float PhotoModeCollisionRadius;
        /* 0x3334 */ public float PhotoModeRollSpeed;
        /* 0x3338 */ public float PhotoModeFlashDuration;
        /* 0x333C */ public float PhotoModeFlashIntensity;
        /* 0x3340 */ public Vector3f PhotoModeShipOffset;
        /* 0x3350 */ public Vector3f PhotoModeVRFPOffset;
        /* 0x3360 */ public Vector3f BuildingModeInitialOffset;
        /* 0x3370 */ public float BuildingModeMaxDistance;
        /* 0x3374 */ public float RunningFoVAdjust;
        /* 0x3378 */ public float MeleeBoostedFoV;
        /* 0x337C */ public float MeleeFoV;
        /* 0x3380 */ public float AerialViewDownDistance;
        /* 0x3384 */ public float AerialViewPause;
        /* 0x3388 */ public float AerialViewStartTime;
        /* 0x338C */ public float AerialViewBackTime;
        /* 0x3390 */ public float AerialViewBlendTime;
        /* 0x3394 */ public TkCurveType AerialViewCurve;
        /* 0x3398 */ public float ScreenshotHorizonHeight;
        /* 0x339C */ public float ScreenshotHorizonFaceFactor;
        /* 0x33A0 */ public float ScreenshotBendDownAmount;
        /* 0x33A4 */ public float ScreenshotRightDistance;
        /* 0x33A8 */ public float ScreenshotBackDistance;
        /* 0x33AC */ public float ScreenshotInTime;
        /* 0x33B0 */ public float ScreenshotOutTime;
        /* 0x33B4 */ public float MechCamSpringStrengthMin;
        /* 0x33B8 */ public float MechCamSpringStrengthMax;
        /* 0x33BC */ public float ShipCamSpringStrengthMin;
        /* 0x33C0 */ public float ShipCamSpringStrengthMax;
        /* 0x33C4 */ public float ShipCamTurn;
        /* 0x33C8 */ public float ShipCamPitch;
        /* 0x33CC */ public float ShipCamPitchMod;
        /* 0x33D0 */ public float ShipCamLookInterp;
        /* 0x33D4 */ public float ShipCamMinReturnTime;
        /* 0x33D8 */ public float ShipCamReturnTime;
        /* 0x33DC */ public float ShipCamMotionTurn;
        /* 0x33E0 */ public float ShipCamMotionPitch;
        /* 0x33E4 */ public float ShipCamMotionPitchMod;
        /* 0x33E8 */ public float ShipCamMotionMaxLagTurnAngle;
        /* 0x33EC */ public float ShipCamMotionMaxLagPitchAngle;
        /* 0x33F0 */ public float ShipCamMotionInterp;
        /* 0x33F4 */ public float ShipCamRollAmountMin;
        /* 0x33F8 */ public float ShipCamRollAmountMax;
        /* 0x33FC */ public float ShipCamRollSpeedScaler;
        /* 0x3400 */ public float ShipCamAimFOV;
        /* 0x3404 */ public float MouseSensitivity;
        /* 0x3408 */ public float ModelViewRotateSpeed;
        /* 0x340C */ public float ModelViewMouseRotateSpeed;
        /* 0x3410 */ public float ModelViewMouseRotateSnapStrength;
        /* 0x3414 */ public float ModelViewMouseMoveSpeed;
        /* 0x3418 */ public float ModelViewDistSpeed;
        /* 0x341C */ public float ModelViewMinDist;
        /* 0x3420 */ public float ModelViewMaxDist;
        /* 0x3424 */ public float ModelViewDefaultPitch;
        /* 0x3428 */ public float ModelViewDefaultYaw;
        /* 0x342C */ public bool DebugMoveCam;
        /* 0x3430 */ public float DebugMoveCamSpeed;
        /* 0x3434 */ public float DebugMoveCamHeight;
        /* 0x3438 */ public bool DebugAICam;
        /* 0x343C */ public float DebugAICamUp;
        /* 0x3440 */ public float DebugAICamAt;
        /* 0x3444 */ public float VRShakeMultiplier;
        /* 0x3448 */ public float PainShakeTime;
        /* 0x344C */ public float ShipShakeDamper;
        /* 0x3450 */ public float IndoorCamShakeDamper;
        /* 0x3454 */ public float FirstPersonSlerpAway;
        /* 0x3458 */ public float FirstPersonSlerpTowards;
        /* 0x3460 */ public List<GcCameraShakeData> CameraShakeTable;
        /* 0x3470 */ public float BobAmountAbandFreighter;
        /* 0x3474 */ public float BobFactorAbandFreighter;
        /* 0x3478 */ public float BobAmount;
        /* 0x347C */ public float BobFactor;
        /* 0x3480 */ public float BobFocus;
        /* 0x3484 */ public float BobRollFactor;
        /* 0x3488 */ public float BobRollAmount;
        /* 0x348C */ public float BobRollOffset;
        /* 0x3490 */ public float BobFwdAmount;
        /* 0x3494 */ public float CamSeed1;
        /* 0x3498 */ public float CamSeed2;
        /* 0x349C */ public float CamWander1Phase;
        /* 0x34A0 */ public float CamWander2Phase;
        /* 0x34A4 */ public float CamWander1Amplitude;
        /* 0x34A8 */ public float CamWander2Amplitude;
        /* 0x34AC */ public float DebugSpaceStationTeleportOffset;
        /* 0x34B0 */ public float DebugCameraSlowFactor;
        /* 0x34B4 */ public float DebugCameraFastFactor;
        /* 0x34B8 */ public float DebugCameraSpaceFastFactor;
        /* 0x34BC */ public float DebugCameraHeightForAccelerateBegin;
        /* 0x34C0 */ public float DebugCameraSpeedAtPlanetThreshold;
        /* 0x34C4 */ public float DebugCameraHeightForAccelerateEnd;
        /* 0x34C8 */ public float DebugCameraMaxSpeed;
        /* 0x34CC */ public float OffsetCamFOV;
        /* 0x34D0 */ public Vector3f OffsetCamOffset;
        /* 0x34E0 */ public Vector3f OffsetCamRotation;
        /* 0x34F0 */ public float ObjectFocusTime;
        /* 0x34F4 */ public float CharCamFocusHeight;
        /* 0x34F8 */ public float CharCamMaxDistance;
        /* 0x34FC */ public float CharCamMinDistance;
        /* 0x3500 */ public float CharCamHeight;
        /* 0x3504 */ public float CharCamOffsetTime;
        /* 0x3508 */ public float CharCamAutoDirStartTime;
        /* 0x350C */ public float CharCamLookOffset;
        /* 0x3510 */ public float CharCamLookOffsetFactor;
        /* 0x3514 */ public float CharCamDeflectSpeed;
        /* 0x3518 */ public float CharCamMinSpeed;
        /* 0x351C */ public float CharCamRightStickX;
        /* 0x3520 */ public float CharCamRightStickY;
        /* 0x3524 */ public float FirstPersonCamHeight;
        [NMS(Size = 0x9, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x3530 */ public Vector3f[] FirstPersonCamOffset;
        /* 0x35C0 */ public Vector3f FirstPersonInShipCamOffset;
        /* 0x35D0 */ public float CloseFactorSpring;
        /* 0x35D4 */ public float FirstPersonFoV;
        /* 0x35D8 */ public float ThirdPersonFoV;
        /* 0x35DC */ public float ThirdPersonCombatFoV;
        /* 0x35E0 */ public float FirstPersonZoom1FoV;
        /* 0x35E4 */ public float FirstPersonZoom2FoV;
        /* 0x35E8 */ public float ShipFoVMin;
        /* 0x35EC */ public float ShipFoVMin2;
        /* 0x35F0 */ public float ShipFoVMax;
        /* 0x35F4 */ public float ShipWarpFoV;
        /* 0x35F8 */ public float ShipFoVMin3rdPerson;
        /* 0x35FC */ public float ShipFoVMax3rdPerson;
        /* 0x3600 */ public float ShipFoVBoost;
        /* 0x3604 */ public float ShipFoVMiniJump;
        /* 0x3608 */ public float ShipFoVSpring;
        /* 0x360C */ public float ShipMiniJumpFoVSpring;
        /* 0x3610 */ public float FoVSpring;
        /* 0x3614 */ public float FoVSpringSights;
        /* 0x3618 */ public float FoVSpringSightsPassive;
        /* 0x361C */ public float FoVAdjust;
        /* 0x3620 */ public bool CreatureInteractionInterpolateDuringHold;
        /* 0x3624 */ public float CreatureSizeMin;
        /* 0x3628 */ public float CreatureSizeMax;
        /* 0x362C */ public float CreatureInteractionMinDist;
        /* 0x3630 */ public float CreatureInteractionPushCameraDownForCreatureBiggerThan;
        /* 0x3634 */ public float CreatureInteractionPushCameraDownAmount;
        /* 0x3638 */ public float CreatureInteractionDistMulMin;
        /* 0x363C */ public float CreatureInteractionDistMulMax;
        /* 0x3640 */ public float CreatureInteractionYawMin;
        /* 0x3644 */ public float CreatureInteractionYawMax;
        /* 0x3648 */ public float CreatureInteractionPitchSplit;
        /* 0x364C */ public float CreatureInteractionPitchMin;
        /* 0x3650 */ public float CreatureInteractionPitchMax;
        /* 0x3654 */ public float CreatureInteractionMaxDownhillPitchAroundPlayer;
        /* 0x3658 */ public float CreatureInteractionDownhillPitchTransfer;
        /* 0x365C */ public float CreatureInteractionMaxUphillPitchAroundPlayer;
        /* 0x3660 */ public float CreatureInteractionUphillPitchTransfer;
        /* 0x3664 */ public float CreatureInteractionFoVSplitSize;
        /* 0x3668 */ public float CreatureInteractionFoVMin;
        /* 0x366C */ public float CreatureInteractionFoVMax;
        /* 0x3670 */ public float CreatureInteractionCamSpring;
        /* 0x3674 */ public float CreatureInteractionHeadHeightSpring;
        /* 0x3678 */ public bool FollowDrawCamProbes;
        /* 0x367C */ public GcCameraAnimationData AmbientCameraAnimations;
        /* 0x3700 */ public TkModelResource AmbientDroneAnimations;
        /* 0x3784 */ public NMSString0x80 CameraAmbientAnimationsData;
        /* 0x3804 */ public float CameraAmbientAutoSwitchMinTime;
        /* 0x3808 */ public float CameraAmbientAutoSwitchMaxTime;
        /* 0x3810 */ public TkModelRendererData CameraNPCShipInteraction;
        /* 0x38D0 */ public TkModelRendererData CameraNPCShopInteraction;
        /* 0x3990 */ public TkModelRendererData CameraCreatureCustomiseDefault;
        /* 0x3A50 */ public TkModelRendererData CameraCreatureCustomiseLeft;
        /* 0x3B10 */ public TkModelRendererData CameraCreatureCustomiseRight;
        /* 0x3BD0 */ public TkModelRendererData CameraCreatureCustomiseFront;
        /* 0x3C90 */ public TkModelRendererData CameraCreatureCustomiseBack;
        /* 0x3D50 */ public List<TkPhysRelVectorData> SavedCameraPositions;
        /* 0x3D60 */ public List<Vector3f> SavedCameraFacing;
        /* 0x3D70 */ public GcCameraWarpSettings WarpSettings;
        /* 0x3DC4 */ public GcCameraWarpSettings FreighterWarpSettings;
    }
}
