using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0xF67D4B807A70DFDA, NameHash = 0xFE7187F)]
    public class GcCameraGlobals : NMSTemplate
    {
        [NMS(Index = 386)]
        /* 0x0000 */ public TkModelRendererData CameraCreatureCustomiseBack;
        [NMS(Index = 382)]
        /* 0x00C0 */ public TkModelRendererData CameraCreatureCustomiseDefault;
        [NMS(Index = 385)]
        /* 0x0180 */ public TkModelRendererData CameraCreatureCustomiseFront;
        [NMS(Index = 383)]
        /* 0x0240 */ public TkModelRendererData CameraCreatureCustomiseLeft;
        [NMS(Index = 384)]
        /* 0x0300 */ public TkModelRendererData CameraCreatureCustomiseRight;
        [NMS(Index = 380)]
        /* 0x03C0 */ public TkModelRendererData CameraNPCShipInteraction;
        [NMS(Index = 381)]
        /* 0x0480 */ public TkModelRendererData CameraNPCShopInteraction;
        [NMS(Index = 13)]
        /* 0x0540 */ public TkModelRendererData FreighterCustomisationStandardCamera;
        [NMS(Index = 14)]
        /* 0x0600 */ public TkModelRendererData FreighterCustomisationStandardCameraAlt;
        [NMS(Index = 329, Size = 0x9, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x06C0 */ public Vector3f[] FirstPersonCamOffset;
        [NMS(Index = 223)]
        /* 0x0750 */ public GcCameraFreeSettings BaseBuildingFreeCameraSettings;
        [NMS(Index = 224)]
        /* 0x0790 */ public GcCameraFreeSettings ShipConstructionFreeCameraSettings;
        [NMS(Index = 225)]
        /* 0x07D0 */ public GcCameraFreeSettings StationExteriorFreeCameraSettings;
        [NMS(Index = 144)]
        /* 0x0810 */ public Vector3f BuildableShipMaxSizeCameraOffset;
        [NMS(Index = 146)]
        /* 0x0820 */ public Vector3f BuildableShipMaxSizeForCamera;
        [NMS(Index = 145)]
        /* 0x0830 */ public Vector3f BuildableShipMinSizeForCamera;
        [NMS(Index = 222)]
        /* 0x0840 */ public Vector3f BuildingModeInitialOffset;
        [NMS(Index = 330)]
        /* 0x0850 */ public Vector3f FirstPersonInShipCamOffset;
        [NMS(Index = 164)]
        /* 0x0860 */ public Vector3f InteractionHailingFocusOffset;
        [NMS(Index = 154)]
        /* 0x0870 */ public Vector3f InteractionOffset;
        [NMS(Index = 162)]
        /* 0x0880 */ public Vector3f InteractionOffsetCronus;
        [NMS(Index = 159)]
        /* 0x0890 */ public Vector3f InteractionOffsetDefault;
        [NMS(Index = 155)]
        /* 0x08A0 */ public Vector3f InteractionOffsetExtraVR;
        [NMS(Index = 156)]
        /* 0x08B0 */ public Vector3f InteractionOffsetExtraVRSeated;
        [NMS(Index = 160)]
        /* 0x08C0 */ public Vector3f InteractionOffsetGek;
        [NMS(Index = 165)]
        /* 0x08D0 */ public Vector3f InteractionOffsetRecruitment;
        [NMS(Index = 161)]
        /* 0x08E0 */ public Vector3f InteractionOffsetSpiderman;
        [NMS(Index = 163)]
        /* 0x08F0 */ public Vector3f InteractionShipFocusOffset;
        [NMS(Index = 36)]
        /* 0x0900 */ public Colour MiniportalFlashColour;
        [NMS(Index = 152)]
        /* 0x0910 */ public Vector3f ModelViewOffset;
        [NMS(Index = 313)]
        /* 0x0920 */ public Vector3f OffsetCamOffset;
        [NMS(Index = 314)]
        /* 0x0930 */ public Vector3f OffsetCamRotation;
        [NMS(Index = 190)]
        /* 0x0940 */ public Vector3f OffsetForFleetInteraction;
        [NMS(Index = 191)]
        /* 0x0950 */ public Vector3f OffsetForFrigateInteraction;
        [NMS(Index = 220)]
        /* 0x0960 */ public Vector3f PhotoModeShipOffset;
        [NMS(Index = 221)]
        /* 0x0970 */ public Vector3f PhotoModeVRFPOffset;
        [NMS(Index = 157)]
        /* 0x0980 */ public Vector3f ShopInteractionOffsetExtraVR;
        [NMS(Index = 158)]
        /* 0x0990 */ public Vector3f ShopInteractionOffsetExtraVRSeated;
        [NMS(Index = 42)]
        /* 0x09A0 */ public Colour VehicleExitFlashColour;
        [NMS(Index = 39)]
        /* 0x09B0 */ public Colour VRGravityChangeFlashColour;
        [NMS(Index = 140)]
        /* 0x09C0 */ public GcCameraFollowSettings AlienShipFollowCam;
        [NMS(Index = 127)]
        /* 0x0AD0 */ public GcCameraFollowSettings BikeFollowCam;
        [NMS(Index = 123)]
        /* 0x0BE0 */ public GcCameraFollowSettings BuggyFollowCam;
        [NMS(Index = 147)]
        /* 0x0CF0 */ public GcCameraFollowSettings BuildingIndoorsCam;
        [NMS(Index = 148)]
        /* 0x0E00 */ public GcCameraFollowSettings BuildingOutdoorsCam;
        [NMS(Index = 149)]
        /* 0x0F10 */ public GcCameraFollowSettings BuildingUnderwaterCam;
        [NMS(Index = 99)]
        /* 0x1020 */ public GcCameraFollowSettings CharacterAbandCam;
        [NMS(Index = 98)]
        /* 0x1130 */ public GcCameraFollowSettings CharacterAbandCombatCam;
        [NMS(Index = 101)]
        /* 0x1240 */ public GcCameraFollowSettings CharacterAirborneCam;
        [NMS(Index = 106)]
        /* 0x1350 */ public GcCameraFollowSettings CharacterAirborneCombatCam;
        [NMS(Index = 91)]
        /* 0x1460 */ public GcCameraFollowSettings CharacterCombatCam;
        [NMS(Index = 96)]
        /* 0x1570 */ public GcCameraFollowSettings CharacterCorvetteBuildCam;
        [NMS(Index = 95)]
        /* 0x1680 */ public GcCameraFollowSettings CharacterCorvetteCam;
        [NMS(Index = 105)]
        /* 0x1790 */ public GcCameraFollowSettings CharacterFallingCam;
        [NMS(Index = 93)]
        /* 0x18A0 */ public GcCameraFollowSettings CharacterFishingCam;
        [NMS(Index = 115)]
        /* 0x19B0 */ public GcCameraFollowSettings CharacterGrabbedCam;
        [NMS(Index = 94)]
        /* 0x1AC0 */ public GcCameraFollowSettings CharacterIndoorCam;
        [NMS(Index = 102)]
        /* 0x1BD0 */ public GcCameraFollowSettings CharacterMeleeBoostCam;
        [NMS(Index = 92)]
        /* 0x1CE0 */ public GcCameraFollowSettings CharacterMiningCam;
        [NMS(Index = 100)]
        /* 0x1DF0 */ public GcCameraFollowSettings CharacterNexusCam;
        [NMS(Index = 117)]
        /* 0x1F00 */ public GcCameraFollowSettings CharacterRideCam;
        [NMS(Index = 120)]
        /* 0x2010 */ public GcCameraFollowSettings CharacterRideCamHuge;
        [NMS(Index = 119)]
        /* 0x2120 */ public GcCameraFollowSettings CharacterRideCamLarge;
        [NMS(Index = 118)]
        /* 0x2230 */ public GcCameraFollowSettings CharacterRideCamMedium;
        [NMS(Index = 103)]
        /* 0x2340 */ public GcCameraFollowSettings CharacterRocketBootsCam;
        [NMS(Index = 104)]
        /* 0x2450 */ public GcCameraFollowSettings CharacterRocketBootsChargeCam;
        [NMS(Index = 90)]
        /* 0x2560 */ public GcCameraFollowSettings CharacterRunCam;
        [NMS(Index = 116)]
        /* 0x2670 */ public GcCameraFollowSettings CharacterSitCam;
        [NMS(Index = 107)]
        /* 0x2780 */ public GcCameraFollowSettings CharacterSpaceCam;
        [NMS(Index = 112)]
        /* 0x2890 */ public GcCameraFollowSettings CharacterSpacewalkCombatCam;
        [NMS(Index = 108)]
        /* 0x29A0 */ public GcCameraFollowSettings CharacterSteepSlopeCam;
        [NMS(Index = 109)]
        /* 0x2AB0 */ public GcCameraFollowSettings CharacterSurfaceWaterCam;
        [NMS(Index = 89)]
        /* 0x2BC0 */ public GcCameraFollowSettings CharacterUnarmedCam;
        [NMS(Index = 97)]
        /* 0x2CD0 */ public GcCameraFollowSettings CharacterUndergroundCam;
        [NMS(Index = 110)]
        /* 0x2DE0 */ public GcCameraFollowSettings CharacterUnderwaterCam;
        [NMS(Index = 111)]
        /* 0x2EF0 */ public GcCameraFollowSettings CharacterUnderwaterCombatCam;
        [NMS(Index = 114)]
        /* 0x3000 */ public GcCameraFollowSettings CharacterUnderwaterJetpackAscentCam;
        [NMS(Index = 113)]
        /* 0x3110 */ public GcCameraFollowSettings CharacterUnderwaterJetpackCam;
        [NMS(Index = 142)]
        /* 0x3220 */ public GcCameraFollowSettings CorvetteFollowCam;
        [NMS(Index = 135)]
        /* 0x3330 */ public GcCameraFollowSettings DropshipFollowCam;
        [NMS(Index = 130)]
        /* 0x3440 */ public GcCameraFollowSettings FlatbedFollowCam;
        [NMS(Index = 124)]
        /* 0x3550 */ public GcCameraFollowSettings HovercraftFollowCam;
        [NMS(Index = 132)]
        /* 0x3660 */ public GcCameraFollowSettings MechCombatCam;
        [NMS(Index = 18)]
        /* 0x3770 */ public GcCameraFollowSettings MechFirstPersonCam;
        [NMS(Index = 131)]
        /* 0x3880 */ public GcCameraFollowSettings MechFollowCam;
        [NMS(Index = 133)]
        /* 0x3990 */ public GcCameraFollowSettings MechJetpackCam;
        [NMS(Index = 141)]
        /* 0x3AA0 */ public GcCameraFollowSettings RobotShipFollowCam;
        [NMS(Index = 137)]
        /* 0x3BB0 */ public GcCameraFollowSettings RoyalShipFollowCam;
        [NMS(Index = 138)]
        /* 0x3CC0 */ public GcCameraFollowSettings SailShipFollowCam;
        [NMS(Index = 139)]
        /* 0x3DD0 */ public GcCameraFollowSettings ScienceShipFollowCam;
        [NMS(Index = 136)]
        /* 0x3EE0 */ public GcCameraFollowSettings ShuttleFollowCam;
        [NMS(Index = 134)]
        /* 0x3FF0 */ public GcCameraFollowSettings SpaceshipFollowCam;
        [NMS(Index = 125)]
        /* 0x4100 */ public GcCameraFollowSettings SubmarineFollowCam;
        [NMS(Index = 126)]
        /* 0x4210 */ public GcCameraFollowSettings SubmarineFollowCamSurface;
        [NMS(Index = 143)]
        /* 0x4320 */ public GcCameraFollowSettings SwarmDroneFollowCam;
        [NMS(Index = 129)]
        /* 0x4430 */ public GcCameraFollowSettings TruckFollowCam;
        [NMS(Index = 17)]
        /* 0x4540 */ public GcCameraFollowSettings VehicleCam;
        [NMS(Index = 16)]
        /* 0x4650 */ public GcCameraFollowSettings VehicleCamHmd;
        [NMS(Index = 128)]
        /* 0x4760 */ public GcCameraFollowSettings WheeledBikeFollowCam;
        [NMS(Index = 375)]
        /* 0x4870 */ public GcCameraAnimationData AmbientCameraAnimations;
        [NMS(Index = 376)]
        /* 0x4890 */ public TkModelResource AmbientDroneAnimations;
        [NMS(Index = 9)]
        /* 0x48B0 */ public List<GcCameraAerialViewDataTableEntry> AerialViewDataTable;
        [NMS(Index = 377)]
        /* 0x48C0 */ public GcFilename CameraAmbientAnimationsData;
        [NMS(Index = 15)]
        /* 0x48D0 */ public List<GcCameraFollowSettings> Cameras;
        [NMS(Index = 288)]
        /* 0x48E0 */ public List<GcCameraShakeData> CameraShakeTable;
        [NMS(Index = 388)]
        /* 0x48F0 */ public List<Vector3f> SavedCameraFacing;
        [NMS(Index = 387)]
        /* 0x4900 */ public List<TkBigPosData> SavedCameraPositions;
        [NMS(Index = 390)]
        /* 0x4910 */ public GcCameraWarpSettings CorvetteWarpSettings;
        [NMS(Index = 391)]
        /* 0x4964 */ public GcCameraWarpSettings FreighterWarpSettings;
        [NMS(Index = 392)]
        /* 0x49B8 */ public GcCameraWarpSettings PirateFreighterWarpSettings;
        [NMS(Index = 389)]
        /* 0x4A0C */ public GcCameraWarpSettings WarpSettings;
        [NMS(Index = 6)]
        /* 0x4A60 */ public GcCameraFocusBuildingControlSettings FocusBuildingModeDistanceControlSettings;
        [NMS(Index = 4)]
        /* 0x4A80 */ public GcCameraFocusBuildingControlSettings FocusBuildingModePitchControlSettings;
        [NMS(Index = 7)]
        /* 0x4AA0 */ public GcCameraFocusBuildingControlSettings FocusBuildingModePlanarControlSettings;
        [NMS(Index = 8)]
        /* 0x4AC0 */ public GcCameraFocusBuildingControlSettings FocusBuildingModeVerticalControlSettings;
        [NMS(Index = 5)]
        /* 0x4AE0 */ public GcCameraFocusBuildingControlSettings FocusBuildingModeYawControlSettings;
        [NMS(Index = 153)]
        /* 0x4B00 */ public Vector2f ModelViewFocusOffset;
        [NMS(Index = 195)]
        /* 0x4B08 */ public Vector2f PitchForFrigateInteraction;
        [NMS(Index = 196)]
        /* 0x4B10 */ public Vector2f RotationForFrigateInteraction;
        [NMS(Index = 233)]
        /* 0x4B18 */ public float AerialViewBackTime;
        [NMS(Index = 234)]
        /* 0x4B1C */ public float AerialViewBlendTime;
        [NMS(Index = 230)]
        /* 0x4B20 */ public float AerialViewDownDistance;
        [NMS(Index = 231)]
        /* 0x4B24 */ public float AerialViewPause;
        [NMS(Index = 232)]
        /* 0x4B28 */ public float AerialViewStartTime;
        [NMS(Index = 60)]
        /* 0x4B2C */ public float BinocularFlashStrength;
        [NMS(Index = 59)]
        /* 0x4B30 */ public float BinocularFlashTime;
        [NMS(Index = 291)]
        /* 0x4B34 */ public float BobAmount;
        [NMS(Index = 289)]
        /* 0x4B38 */ public float BobAmountAbandFreighter;
        [NMS(Index = 292)]
        /* 0x4B3C */ public float BobFactor;
        [NMS(Index = 290)]
        /* 0x4B40 */ public float BobFactorAbandFreighter;
        [NMS(Index = 293)]
        /* 0x4B44 */ public float BobFocus;
        [NMS(Index = 297)]
        /* 0x4B48 */ public float BobFwdAmount;
        [NMS(Index = 295)]
        /* 0x4B4C */ public float BobRollAmount;
        [NMS(Index = 294)]
        /* 0x4B50 */ public float BobRollFactor;
        [NMS(Index = 296)]
        /* 0x4B54 */ public float BobRollOffset;
        [NMS(Index = 226)]
        /* 0x4B58 */ public float BuildingModeMaxDistance;
        [NMS(Index = 379)]
        /* 0x4B5C */ public float CameraAmbientAutoSwitchMaxTime;
        [NMS(Index = 378)]
        /* 0x4B60 */ public float CameraAmbientAutoSwitchMinTime;
        [NMS(Index = 298)]
        /* 0x4B64 */ public float CamSeed1;
        [NMS(Index = 299)]
        /* 0x4B68 */ public float CamSeed2;
        [NMS(Index = 302)]
        /* 0x4B6C */ public float CamWander1Amplitude;
        [NMS(Index = 300)]
        /* 0x4B70 */ public float CamWander1Phase;
        [NMS(Index = 303)]
        /* 0x4B74 */ public float CamWander2Amplitude;
        [NMS(Index = 301)]
        /* 0x4B78 */ public float CamWander2Phase;
        [NMS(Index = 321)]
        /* 0x4B7C */ public float CharCamAutoDirStartTime;
        [NMS(Index = 324)]
        /* 0x4B80 */ public float CharCamDeflectSpeed;
        [NMS(Index = 316)]
        /* 0x4B84 */ public float CharCamFocusHeight;
        [NMS(Index = 319)]
        /* 0x4B88 */ public float CharCamHeight;
        [NMS(Index = 322)]
        /* 0x4B8C */ public float CharCamLookOffset;
        [NMS(Index = 323)]
        /* 0x4B90 */ public float CharCamLookOffsetFactor;
        [NMS(Index = 317)]
        /* 0x4B94 */ public float CharCamMaxDistance;
        [NMS(Index = 318)]
        /* 0x4B98 */ public float CharCamMinDistance;
        [NMS(Index = 325)]
        /* 0x4B9C */ public float CharCamMinSpeed;
        [NMS(Index = 320)]
        /* 0x4BA0 */ public float CharCamOffsetTime;
        [NMS(Index = 326)]
        /* 0x4BA4 */ public float CharCamRightStickX;
        [NMS(Index = 327)]
        /* 0x4BA8 */ public float CharCamRightStickY;
        [NMS(Index = 331)]
        /* 0x4BAC */ public float CloseFactorSpring;
        [NMS(Index = 372)]
        /* 0x4BB0 */ public float CreatureInteractionCamSpring;
        [NMS(Index = 359)]
        /* 0x4BB4 */ public float CreatureInteractionDistMulMax;
        [NMS(Index = 358)]
        /* 0x4BB8 */ public float CreatureInteractionDistMulMin;
        [NMS(Index = 366)]
        /* 0x4BBC */ public float CreatureInteractionDownhillPitchTransfer;
        [NMS(Index = 371)]
        /* 0x4BC0 */ public float CreatureInteractionFoVMax;
        [NMS(Index = 370)]
        /* 0x4BC4 */ public float CreatureInteractionFoVMin;
        [NMS(Index = 369)]
        /* 0x4BC8 */ public float CreatureInteractionFoVSplitSize;
        [NMS(Index = 373)]
        /* 0x4BCC */ public float CreatureInteractionHeadHeightSpring;
        [NMS(Index = 365)]
        /* 0x4BD0 */ public float CreatureInteractionMaxDownhillPitchAroundPlayer;
        [NMS(Index = 367)]
        /* 0x4BD4 */ public float CreatureInteractionMaxUphillPitchAroundPlayer;
        [NMS(Index = 355)]
        /* 0x4BD8 */ public float CreatureInteractionMinDist;
        [NMS(Index = 364)]
        /* 0x4BDC */ public float CreatureInteractionPitchMax;
        [NMS(Index = 363)]
        /* 0x4BE0 */ public float CreatureInteractionPitchMin;
        [NMS(Index = 362)]
        /* 0x4BE4 */ public float CreatureInteractionPitchSplit;
        [NMS(Index = 357)]
        /* 0x4BE8 */ public float CreatureInteractionPushCameraDownAmount;
        [NMS(Index = 356)]
        /* 0x4BEC */ public float CreatureInteractionPushCameraDownForCreatureBiggerThan;
        [NMS(Index = 368)]
        /* 0x4BF0 */ public float CreatureInteractionUphillPitchTransfer;
        [NMS(Index = 361)]
        /* 0x4BF4 */ public float CreatureInteractionYawMax;
        [NMS(Index = 360)]
        /* 0x4BF8 */ public float CreatureInteractionYawMin;
        [NMS(Index = 354)]
        /* 0x4BFC */ public float CreatureSizeMax;
        [NMS(Index = 353)]
        /* 0x4C00 */ public float CreatureSizeMin;
        [NMS(Index = 280)]
        /* 0x4C04 */ public float DebugAICamAt;
        [NMS(Index = 279)]
        /* 0x4C08 */ public float DebugAICamUp;
        [NMS(Index = 306)]
        /* 0x4C0C */ public float DebugCameraFastFactor;
        [NMS(Index = 308)]
        /* 0x4C10 */ public float DebugCameraHeightForAccelerateBegin;
        [NMS(Index = 310)]
        /* 0x4C14 */ public float DebugCameraHeightForAccelerateEnd;
        [NMS(Index = 311)]
        /* 0x4C18 */ public float DebugCameraMaxSpeed;
        [NMS(Index = 305)]
        /* 0x4C1C */ public float DebugCameraSlowFactor;
        [NMS(Index = 307)]
        /* 0x4C20 */ public float DebugCameraSpaceFastFactor;
        [NMS(Index = 309)]
        /* 0x4C24 */ public float DebugCameraSpeedAtPlanetThreshold;
        [NMS(Index = 277)]
        /* 0x4C28 */ public float DebugMoveCamHeight;
        [NMS(Index = 276)]
        /* 0x4C2C */ public float DebugMoveCamSpeed;
        [NMS(Index = 28)]
        /* 0x4C30 */ public float DebugPlanetJumpFarHeight;
        [NMS(Index = 27)]
        /* 0x4C34 */ public float DebugPlanetJumpNearHeight;
        [NMS(Index = 304)]
        /* 0x4C38 */ public float DebugSpaceStationTeleportOffset;
        [NMS(Index = 187)]
        /* 0x4C3C */ public float DistanceForFleetInteraction;
        [NMS(Index = 188)]
        /* 0x4C40 */ public float DistanceForFrigateInteraction;
        [NMS(Index = 189)]
        /* 0x4C44 */ public float DistanceForFrigatePurchaseInteraction;
        [NMS(Index = 328)]
        /* 0x4C48 */ public float FirstPersonCamHeight;
        [NMS(Index = 332)]
        /* 0x4C4C */ public float FirstPersonFoV;
        [NMS(Index = 286)]
        /* 0x4C50 */ public float FirstPersonSlerpAway;
        [NMS(Index = 287)]
        /* 0x4C54 */ public float FirstPersonSlerpTowards;
        [NMS(Index = 336)]
        /* 0x4C58 */ public float FirstPersonZoom1FoV;
        [NMS(Index = 337)]
        /* 0x4C5C */ public float FirstPersonZoom2FoV;
        [NMS(Index = 192)]
        /* 0x4C60 */ public float FleetUIOrbitRate;
        [NMS(Index = 194)]
        /* 0x4C64 */ public float FleetUIVerticalMotionAmplitude;
        [NMS(Index = 193)]
        /* 0x4C68 */ public float FleetUIVerticalMotionDuration;
        [NMS(Index = 58)]
        /* 0x4C6C */ public float FlybyInVehicleDamper;
        [NMS(Index = 54)]
        /* 0x4C70 */ public float FlybyMinRange;
        [NMS(Index = 56)]
        /* 0x4C74 */ public float FlybyMinRelativeSpeed;
        [NMS(Index = 55)]
        /* 0x4C78 */ public float FlybyRange;
        [NMS(Index = 57)]
        /* 0x4C7C */ public float FlybyRelativeSpeedRange;
        [NMS(Index = 3)]
        /* 0x4C80 */ public float FocusBuildingModeMaxFOV;
        [NMS(Index = 2)]
        /* 0x4C84 */ public float FocusBuildingModeMinFOV;
        [NMS(Index = 1)]
        /* 0x4C88 */ public float FocusBuildingModeStartDistance;
        [NMS(Index = 351)]
        /* 0x4C8C */ public float FoVAdjust;
        [NMS(Index = 348)]
        /* 0x4C90 */ public float FoVSpring;
        [NMS(Index = 349)]
        /* 0x4C94 */ public float FoVSpringSights;
        [NMS(Index = 350)]
        /* 0x4C98 */ public float FoVSpringSightsPassive;
        [NMS(Index = 181)]
        /* 0x4C9C */ public float FrigateCaptainLateralShiftAmount;
        [NMS(Index = 150)]
        /* 0x4CA0 */ public float FrontendModelCameraSpringTime;
        [NMS(Index = 23)]
        /* 0x4CA4 */ public float HmdEyeExtraTurnAngle;
        [NMS(Index = 25)]
        /* 0x4CA8 */ public float HmdEyeExtraTurnHeadAngleRange;
        [NMS(Index = 24)]
        /* 0x4CAC */ public float HmdEyeExtraTurnMinHeadAngle;
        [NMS(Index = 22)]
        /* 0x4CB0 */ public float HmdEyeLookAngle;
        [NMS(Index = 284)]
        /* 0x4CB4 */ public float IndoorCamShakeDamper;
        [NMS(Index = 167)]
        /* 0x4CB8 */ public float InteractionHeadHeightCronus;
        [NMS(Index = 166)]
        /* 0x4CBC */ public float InteractionHeadHeightDefault;
        [NMS(Index = 168)]
        /* 0x4CC0 */ public float InteractionHeadHeightGek;
        [NMS(Index = 170)]
        /* 0x4CC4 */ public float InteractionHeadHeightSpiderman;
        [NMS(Index = 169)]
        /* 0x4CC8 */ public float InteractionHeadHeightVykeen;
        [NMS(Index = 174)]
        /* 0x4CCC */ public float InteractionHeadPosHeightAdjust;
        [NMS(Index = 177)]
        /* 0x4CD0 */ public float InteractionHeadPosHeightAdjustCronus;
        [NMS(Index = 176)]
        /* 0x4CD4 */ public float InteractionHeadPosHeightAdjustSpiderman;
        [NMS(Index = 175)]
        /* 0x4CD8 */ public float InteractionHeadPosHeightAdjustVykeen;
        [NMS(Index = 197)]
        /* 0x4CDC */ public float InteractionModeBlendTime;
        [NMS(Index = 198)]
        /* 0x4CE0 */ public float InteractionModeFocusCamBlend;
        [NMS(Index = 199)]
        /* 0x4CE4 */ public float InteractionModeFoV;
        [NMS(Index = 173)]
        /* 0x4CE8 */ public float InteractionPitchAdjustDeadZone;
        [NMS(Index = 172)]
        /* 0x4CEC */ public float InteractionPitchAdjustStrength;
        [NMS(Index = 171)]
        /* 0x4CF0 */ public float InteractionPitchAdjustTime;
        [NMS(Index = 185)]
        /* 0x4CF4 */ public float LocalMissionBoardLateralShiftAmount;
        [NMS(Index = 63)]
        /* 0x4CF8 */ public float MaxCreatureRidingYaw;
        [NMS(Index = 62)]
        /* 0x4CFC */ public float MaxFirstPersonCameraPitch;
        [NMS(Index = 87)]
        /* 0x4D00 */ public float MechCameraArmShootOffsetY;
        [NMS(Index = 88)]
        /* 0x4D04 */ public float MechCameraCombatFakeSpeed;
        [NMS(Index = 86)]
        /* 0x4D08 */ public float MechCameraExtraYPostLandingBlendTime;
        [NMS(Index = 85)]
        /* 0x4D0C */ public float MechCameraNoExtraYTimeAfterLand;
        [NMS(Index = 244)]
        /* 0x4D10 */ public float MechCamSpringStrengthMax;
        [NMS(Index = 243)]
        /* 0x4D14 */ public float MechCamSpringStrengthMin;
        [NMS(Index = 228)]
        /* 0x4D18 */ public float MeleeBoostedFoV;
        [NMS(Index = 229)]
        /* 0x4D1C */ public float MeleeFoV;
        [NMS(Index = 61)]
        /* 0x4D20 */ public float MinFirstPersonCameraPitch;
        [NMS(Index = 201)]
        /* 0x4D24 */ public float MinInteractFocusAngle;
        [NMS(Index = 35)]
        /* 0x4D28 */ public float MiniportalFlashStrength;
        [NMS(Index = 34)]
        /* 0x4D2C */ public float MiniportalFlashTime;
        [NMS(Index = 273)]
        /* 0x4D30 */ public float ModelViewDefaultPitch;
        [NMS(Index = 274)]
        /* 0x4D34 */ public float ModelViewDefaultYaw;
        [NMS(Index = 270)]
        /* 0x4D38 */ public float ModelViewDistSpeed;
        [NMS(Index = 151)]
        /* 0x4D3C */ public float ModelViewFlashTime;
        [NMS(Index = 202)]
        /* 0x4D40 */ public float ModelViewInterpTime;
        [NMS(Index = 272)]
        /* 0x4D44 */ public float ModelViewMaxDist;
        [NMS(Index = 271)]
        /* 0x4D48 */ public float ModelViewMinDist;
        [NMS(Index = 269)]
        /* 0x4D4C */ public float ModelViewMouseMoveSpeed;
        [NMS(Index = 268)]
        /* 0x4D50 */ public float ModelViewMouseRotateSnapStrength;
        [NMS(Index = 267)]
        /* 0x4D54 */ public float ModelViewMouseRotateSpeed;
        [NMS(Index = 266)]
        /* 0x4D58 */ public float ModelViewRotateSpeed;
        [NMS(Index = 265)]
        /* 0x4D5C */ public float MouseSensitivity;
        [NMS(Index = 285)]
        /* 0x4D60 */ public float NoControlCamShakeDamper;
        [NMS(Index = 184)]
        /* 0x4D64 */ public float NPCTradeLateralShiftAmount;
        [NMS(Index = 186)]
        /* 0x4D68 */ public float NPCTradeLateralShiftTime;
        [NMS(Index = 315)]
        /* 0x4D6C */ public float ObjectFocusTime;
        [NMS(Index = 312)]
        /* 0x4D70 */ public float OffsetCamFOV;
        [NMS(Index = 12)]
        /* 0x4D74 */ public float OffsetCombatCameraHorizontalAngle;
        [NMS(Index = 282)]
        /* 0x4D78 */ public float PainShakeTime;
        [NMS(Index = 216)]
        /* 0x4D7C */ public float PhotoModeCollisionRadius;
        [NMS(Index = 218)]
        /* 0x4D80 */ public float PhotoModeFlashDuration;
        [NMS(Index = 219)]
        /* 0x4D84 */ public float PhotoModeFlashIntensity;
        [NMS(Index = 212)]
        /* 0x4D88 */ public float PhotoModeMaxDistance;
        [NMS(Index = 215)]
        /* 0x4D8C */ public float PhotoModeMaxDistanceClampBuffer;
        [NMS(Index = 214)]
        /* 0x4D90 */ public float PhotoModeMaxDistanceClampForce;
        [NMS(Index = 213)]
        /* 0x4D94 */ public float PhotoModeMaxDistanceSpace;
        [NMS(Index = 210)]
        /* 0x4D98 */ public float PhotoModeMoveSpeed;
        [NMS(Index = 217)]
        /* 0x4D9C */ public float PhotoModeRollSpeed;
        [NMS(Index = 211)]
        /* 0x4DA0 */ public float PhotoModeTurnSpeed;
        [NMS(Index = 209)]
        /* 0x4DA4 */ public float PhotoModeVelocitySmoothTime;
        [NMS(Index = 182)]
        /* 0x4DA8 */ public float PilotDetailsLateralShiftAmount;
        [NMS(Index = 183)]
        /* 0x4DAC */ public float RecruitmentLateralShiftAmount;
        [NMS(Index = 19)]
        /* 0x4DB0 */ public float RevealedNPCHeadOffset;
        [NMS(Index = 227)]
        /* 0x4DB4 */ public float RunningFoVAdjust;
        [NMS(Index = 0)]
        /* 0x4DB8 */ public float ScanCameraLookAtTime;
        [NMS(Index = 10)]
        /* 0x4DBC */ public float SClassLandingShakeMultiplier;
        [NMS(Index = 240)]
        /* 0x4DC0 */ public float ScreenshotBackDistance;
        [NMS(Index = 238)]
        /* 0x4DC4 */ public float ScreenshotBendDownAmount;
        [NMS(Index = 237)]
        /* 0x4DC8 */ public float ScreenshotHorizonFaceFactor;
        [NMS(Index = 236)]
        /* 0x4DCC */ public float ScreenshotHorizonHeight;
        [NMS(Index = 241)]
        /* 0x4DD0 */ public float ScreenshotInTime;
        [NMS(Index = 242)]
        /* 0x4DD4 */ public float ScreenshotOutTime;
        [NMS(Index = 239)]
        /* 0x4DD8 */ public float ScreenshotRightDistance;
        [NMS(Index = 200)]
        /* 0x4DDC */ public float ShipBuilderFoV;
        [NMS(Index = 264)]
        /* 0x4DE0 */ public float ShipCamAimFOV;
        [NMS(Index = 246)]
        /* 0x4DE4 */ public float ShipCamFastSpringStrengthMax;
        [NMS(Index = 245)]
        /* 0x4DE8 */ public float ShipCamFastSpringStrengthMin;
        [NMS(Index = 252)]
        /* 0x4DEC */ public float ShipCamLookInterp;
        [NMS(Index = 253)]
        /* 0x4DF0 */ public float ShipCamMinReturnTime;
        [NMS(Index = 260)]
        /* 0x4DF4 */ public float ShipCamMotionInterp;
        [NMS(Index = 259)]
        /* 0x4DF8 */ public float ShipCamMotionMaxLagPitchAngle;
        [NMS(Index = 258)]
        /* 0x4DFC */ public float ShipCamMotionMaxLagTurnAngle;
        [NMS(Index = 256)]
        /* 0x4E00 */ public float ShipCamMotionPitch;
        [NMS(Index = 257)]
        /* 0x4E04 */ public float ShipCamMotionPitchMod;
        [NMS(Index = 255)]
        /* 0x4E08 */ public float ShipCamMotionTurn;
        [NMS(Index = 250)]
        /* 0x4E0C */ public float ShipCamPitch;
        [NMS(Index = 251)]
        /* 0x4E10 */ public float ShipCamPitchMod;
        [NMS(Index = 254)]
        /* 0x4E14 */ public float ShipCamReturnTime;
        [NMS(Index = 262)]
        /* 0x4E18 */ public float ShipCamRollAmountMax;
        [NMS(Index = 261)]
        /* 0x4E1C */ public float ShipCamRollAmountMin;
        [NMS(Index = 263)]
        /* 0x4E20 */ public float ShipCamRollSpeedScaler;
        [NMS(Index = 248)]
        /* 0x4E24 */ public float ShipCamSpringStrengthMax;
        [NMS(Index = 247)]
        /* 0x4E28 */ public float ShipCamSpringStrengthMin;
        [NMS(Index = 249)]
        /* 0x4E2C */ public float ShipCamTurn;
        [NMS(Index = 51)]
        /* 0x4E30 */ public float ShipFirstPersonBlendOffset;
        [NMS(Index = 50)]
        /* 0x4E34 */ public float ShipFirstPersonBlendTime;
        [NMS(Index = 344)]
        /* 0x4E38 */ public float ShipFoVBoost;
        [NMS(Index = 340)]
        /* 0x4E3C */ public float ShipFoVMax;
        [NMS(Index = 343)]
        /* 0x4E40 */ public float ShipFoVMax3rdPerson;
        [NMS(Index = 338)]
        /* 0x4E44 */ public float ShipFoVMin;
        [NMS(Index = 339)]
        /* 0x4E48 */ public float ShipFoVMin2;
        [NMS(Index = 342)]
        /* 0x4E4C */ public float ShipFoVMin3rdPerson;
        [NMS(Index = 345)]
        /* 0x4E50 */ public float ShipFoVMiniJump;
        [NMS(Index = 346)]
        /* 0x4E54 */ public float ShipFoVSpring;
        [NMS(Index = 347)]
        /* 0x4E58 */ public float ShipMiniJumpFoVSpring;
        [NMS(Index = 283)]
        /* 0x4E5C */ public float ShipShakeDamper;
        [NMS(Index = 47)]
        /* 0x4E60 */ public float ShipThirdPersonBlendOffset;
        [NMS(Index = 49)]
        /* 0x4E64 */ public float ShipThirdPersonBlendOutOffset;
        [NMS(Index = 48)]
        /* 0x4E68 */ public float ShipThirdPersonBlendOutTime;
        [NMS(Index = 45)]
        /* 0x4E6C */ public float ShipThirdPersonBlendTime;
        [NMS(Index = 46)]
        /* 0x4E70 */ public float ShipThirdPersonBlendWithOffsetTime;
        [NMS(Index = 53)]
        /* 0x4E74 */ public float ShipThirdPersonEnterBlendOffset;
        [NMS(Index = 52)]
        /* 0x4E78 */ public float ShipThirdPersonEnterBlendTime;
        [NMS(Index = 341)]
        /* 0x4E7C */ public float ShipWarpFoV;
        [NMS(Index = 20)]
        /* 0x4E80 */ public float SpecialVehicleMouseRecentreTime;
        [NMS(Index = 21)]
        /* 0x4E84 */ public float SpecialVehicleMouseRecentreWeaponTime;
        [NMS(Index = 32)]
        /* 0x4E88 */ public float ThirdPersonAfterIntroCamBlendTime;
        [NMS(Index = 203)]
        /* 0x4E8C */ public float ThirdPersonBlendInTime;
        [NMS(Index = 204)]
        /* 0x4E90 */ public float ThirdPersonBlendOutTime;
        [NMS(Index = 121)]
        /* 0x4E94 */ public float ThirdPersonCameraChangeBlendTime;
        [NMS(Index = 122)]
        /* 0x4E98 */ public float ThirdPersonCameraChangeMinimumBlend;
        [NMS(Index = 66)]
        /* 0x4E9C */ public float ThirdPersonCloseDistance;
        [NMS(Index = 67)]
        /* 0x4EA0 */ public float ThirdPersonCloseDistanceX;
        [NMS(Index = 65)]
        /* 0x4EA4 */ public float ThirdPersonClosePitch;
        [NMS(Index = 205)]
        /* 0x4EA8 */ public float ThirdPersonCollisionPushOffsetReducerStart;
        [NMS(Index = 206)]
        /* 0x4EAC */ public float ThirdPersonCollisionPushOffsetReducerVehicleRearAngle;
        [NMS(Index = 335)]
        /* 0x4EB0 */ public float ThirdPersonCombatFoV;
        [NMS(Index = 74)]
        /* 0x4EB4 */ public float ThirdPersonDownhillAdjustMaxAngle;
        [NMS(Index = 78)]
        /* 0x4EB8 */ public float ThirdPersonDownhillAdjustMaxAnglePrime;
        [NMS(Index = 73)]
        /* 0x4EBC */ public float ThirdPersonDownhillAdjustMinAngle;
        [NMS(Index = 77)]
        /* 0x4EC0 */ public float ThirdPersonDownhillAdjustMinAnglePrime;
        [NMS(Index = 72)]
        /* 0x4EC4 */ public float ThirdPersonDownhillAdjustSpringTimeMax;
        [NMS(Index = 71)]
        /* 0x4EC8 */ public float ThirdPersonDownhillAdjustSpringTimeMin;
        [NMS(Index = 333)]
        /* 0x4ECC */ public float ThirdPersonFoV;
        [NMS(Index = 207)]
        /* 0x4ED0 */ public float ThirdPersonOffsetSpringTime;
        [NMS(Index = 68)]
        /* 0x4ED4 */ public float ThirdPersonRotationBackAdjustAngleMax;
        [NMS(Index = 64)]
        /* 0x4ED8 */ public float ThirdPersonRotationBackAdjustAngleMin;
        [NMS(Index = 33)]
        /* 0x4EDC */ public float ThirdPersonSkipIntroCamBlendTime;
        [NMS(Index = 82)]
        /* 0x4EE0 */ public float ThirdPersonUphillAdjustCrossSlopeMaxAngle;
        [NMS(Index = 81)]
        /* 0x4EE4 */ public float ThirdPersonUphillAdjustCrossSlopeMinAngle;
        [NMS(Index = 76)]
        /* 0x4EE8 */ public float ThirdPersonUphillAdjustMaxAngle;
        [NMS(Index = 80)]
        /* 0x4EEC */ public float ThirdPersonUphillAdjustMaxAnglePrime;
        [NMS(Index = 75)]
        /* 0x4EF0 */ public float ThirdPersonUphillAdjustMinAngle;
        [NMS(Index = 79)]
        /* 0x4EF4 */ public float ThirdPersonUphillAdjustMinAnglePrime;
        [NMS(Index = 70)]
        /* 0x4EF8 */ public float ThirdPersonUphillAdjustSpringTimeMax;
        [NMS(Index = 69)]
        /* 0x4EFC */ public float ThirdPersonUphillAdjustSpringTimeMin;
        [NMS(Index = 29)]
        /* 0x4F00 */ public float TogglePerspectiveBlendTime;
        [NMS(Index = 31)]
        /* 0x4F04 */ public float UnderwaterCameraExtraVertOffset;
        [NMS(Index = 180)]
        /* 0x4F08 */ public float VehicleCameraVertRotationLimitBlendTime;
        [NMS(Index = 179)]
        /* 0x4F0C */ public float VehicleCameraVertRotationMax;
        [NMS(Index = 178)]
        /* 0x4F10 */ public float VehicleCameraVertRotationMin;
        [NMS(Index = 41)]
        /* 0x4F14 */ public float VehicleExitFlashStrength;
        [NMS(Index = 40)]
        /* 0x4F18 */ public float VehicleExitFlashTime;
        [NMS(Index = 334)]
        /* 0x4F1C */ public float VehicleFirstPersonFoV;
        [NMS(Index = 43)]
        /* 0x4F20 */ public float VehicleFirstToThirdExitOffsetY;
        [NMS(Index = 44)]
        /* 0x4F24 */ public float VehicleFirstToThirdExitOffsetZ;
        [NMS(Index = 84)]
        /* 0x4F28 */ public float VehicleThirdPersonShootOffsetBlendOutTime;
        [NMS(Index = 83)]
        /* 0x4F2C */ public float VehicleThirdPersonShootOffsetReturnTime;
        [NMS(Index = 38)]
        /* 0x4F30 */ public float VRGravityChangeMaxFlashTime;
        [NMS(Index = 37)]
        /* 0x4F34 */ public float VRGravityChangeMinFlashTime;
        [NMS(Index = 281)]
        /* 0x4F38 */ public float VRShakeMultiplier;
        [NMS(Index = 235)]
        /* 0x4F3C */ public TkCurveType AerialViewCurve;
        [NMS(Index = 352)]
        /* 0x4F3D */ public bool CreatureInteractionInterpolateDuringHold;
        [NMS(Index = 278)]
        /* 0x4F3E */ public bool DebugAICam;
        [NMS(Index = 275)]
        /* 0x4F3F */ public bool DebugMoveCam;
        [NMS(Index = 374)]
        /* 0x4F40 */ public bool FollowDrawCamProbes;
        [NMS(Index = 30)]
        /* 0x4F41 */ public bool LockFollowSpring;
        [NMS(Index = 208)]
        /* 0x4F42 */ public bool MaxBob;
        [NMS(Index = 11)]
        /* 0x4F43 */ public bool OffsetCombatCameraHorizontal;
        [NMS(Index = 26)]
        /* 0x4F44 */ public bool PauseThirdPersonCamInPause;
    }
}
