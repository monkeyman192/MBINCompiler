using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0xFA3D29B653B0B0FF, NameHash = 0xFE7187F)]
    public class GcCameraGlobals : NMSTemplate
    {
        [NMS(Index = 360)]
        /* 0x0000 */ public TkModelRendererData CameraCreatureCustomiseBack;
        [NMS(Index = 356)]
        /* 0x00B0 */ public TkModelRendererData CameraCreatureCustomiseDefault;
        [NMS(Index = 359)]
        /* 0x0160 */ public TkModelRendererData CameraCreatureCustomiseFront;
        [NMS(Index = 357)]
        /* 0x0210 */ public TkModelRendererData CameraCreatureCustomiseLeft;
        [NMS(Index = 358)]
        /* 0x02C0 */ public TkModelRendererData CameraCreatureCustomiseRight;
        [NMS(Index = 354)]
        /* 0x0370 */ public TkModelRendererData CameraNPCShipInteraction;
        [NMS(Index = 355)]
        /* 0x0420 */ public TkModelRendererData CameraNPCShopInteraction;
        [NMS(Index = 13)]
        /* 0x04D0 */ public TkModelRendererData FreighterCustomisationStandardCamera;
        [NMS(Index = 14)]
        /* 0x0580 */ public TkModelRendererData FreighterCustomisationStandardCameraAlt;
        [NMS(Index = 304, Size = 0x9, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x0630 */ public Vector3f[] FirstPersonCamOffset;
        [NMS(Index = 202)]
        /* 0x06C0 */ public Vector3f BuildingModeInitialOffset;
        [NMS(Index = 305)]
        /* 0x06D0 */ public Vector3f FirstPersonInShipCamOffset;
        [NMS(Index = 150)]
        /* 0x06E0 */ public Vector3f InteractionHailingFocusOffset;
        [NMS(Index = 141)]
        /* 0x06F0 */ public Vector3f InteractionOffset;
        [NMS(Index = 146)]
        /* 0x0700 */ public Vector3f InteractionOffsetDefault;
        [NMS(Index = 142)]
        /* 0x0710 */ public Vector3f InteractionOffsetExtraVR;
        [NMS(Index = 143)]
        /* 0x0720 */ public Vector3f InteractionOffsetExtraVRSeated;
        [NMS(Index = 147)]
        /* 0x0730 */ public Vector3f InteractionOffsetGek;
        [NMS(Index = 151)]
        /* 0x0740 */ public Vector3f InteractionOffsetRecruitment;
        [NMS(Index = 148)]
        /* 0x0750 */ public Vector3f InteractionOffsetSpiderman;
        [NMS(Index = 149)]
        /* 0x0760 */ public Vector3f InteractionShipFocusOffset;
        [NMS(Index = 39)]
        /* 0x0770 */ public Colour MiniportalFlashColour;
        [NMS(Index = 139)]
        /* 0x0780 */ public Vector3f ModelViewOffset;
        [NMS(Index = 288)]
        /* 0x0790 */ public Vector3f OffsetCamOffset;
        [NMS(Index = 289)]
        /* 0x07A0 */ public Vector3f OffsetCamRotation;
        [NMS(Index = 171)]
        /* 0x07B0 */ public Vector3f OffsetForFleetInteraction;
        [NMS(Index = 172)]
        /* 0x07C0 */ public Vector3f OffsetForFrigateInteraction;
        [NMS(Index = 200)]
        /* 0x07D0 */ public Vector3f PhotoModeShipOffset;
        [NMS(Index = 201)]
        /* 0x07E0 */ public Vector3f PhotoModeVRFPOffset;
        [NMS(Index = 144)]
        /* 0x07F0 */ public Vector3f ShopInteractionOffsetExtraVR;
        [NMS(Index = 145)]
        /* 0x0800 */ public Vector3f ShopInteractionOffsetExtraVRSeated;
        [NMS(Index = 42)]
        /* 0x0810 */ public Colour VehicleExitFlashColour;
        [NMS(Index = 132)]
        /* 0x0820 */ public GcCameraFollowSettings AlienShipFollowCam;
        [NMS(Index = 120)]
        /* 0x0910 */ public GcCameraFollowSettings BikeFollowCam;
        [NMS(Index = 117)]
        /* 0x0A00 */ public GcCameraFollowSettings BuggyFollowCam;
        [NMS(Index = 134)]
        /* 0x0AF0 */ public GcCameraFollowSettings BuildingIndoorsCam;
        [NMS(Index = 135)]
        /* 0x0BE0 */ public GcCameraFollowSettings BuildingOutdoorsCam;
        [NMS(Index = 136)]
        /* 0x0CD0 */ public GcCameraFollowSettings BuildingUnderwaterCam;
        [NMS(Index = 96)]
        /* 0x0DC0 */ public GcCameraFollowSettings CharacterAbandCam;
        [NMS(Index = 95)]
        /* 0x0EB0 */ public GcCameraFollowSettings CharacterAbandCombatCam;
        [NMS(Index = 98)]
        /* 0x0FA0 */ public GcCameraFollowSettings CharacterAirborneCam;
        [NMS(Index = 103)]
        /* 0x1090 */ public GcCameraFollowSettings CharacterAirborneCombatCam;
        [NMS(Index = 91)]
        /* 0x1180 */ public GcCameraFollowSettings CharacterCombatCam;
        [NMS(Index = 102)]
        /* 0x1270 */ public GcCameraFollowSettings CharacterFallingCam;
        [NMS(Index = 93)]
        /* 0x1360 */ public GcCameraFollowSettings CharacterFishingCam;
        [NMS(Index = 109)]
        /* 0x1450 */ public GcCameraFollowSettings CharacterGrabbedCam;
        [NMS(Index = 94)]
        /* 0x1540 */ public GcCameraFollowSettings CharacterIndoorCam;
        [NMS(Index = 99)]
        /* 0x1630 */ public GcCameraFollowSettings CharacterMeleeBoostCam;
        [NMS(Index = 92)]
        /* 0x1720 */ public GcCameraFollowSettings CharacterMiningCam;
        [NMS(Index = 97)]
        /* 0x1810 */ public GcCameraFollowSettings CharacterNexusCam;
        [NMS(Index = 111)]
        /* 0x1900 */ public GcCameraFollowSettings CharacterRideCam;
        [NMS(Index = 114)]
        /* 0x19F0 */ public GcCameraFollowSettings CharacterRideCamHuge;
        [NMS(Index = 113)]
        /* 0x1AE0 */ public GcCameraFollowSettings CharacterRideCamLarge;
        [NMS(Index = 112)]
        /* 0x1BD0 */ public GcCameraFollowSettings CharacterRideCamMedium;
        [NMS(Index = 100)]
        /* 0x1CC0 */ public GcCameraFollowSettings CharacterRocketBootsCam;
        [NMS(Index = 101)]
        /* 0x1DB0 */ public GcCameraFollowSettings CharacterRocketBootsChargeCam;
        [NMS(Index = 90)]
        /* 0x1EA0 */ public GcCameraFollowSettings CharacterRunCam;
        [NMS(Index = 110)]
        /* 0x1F90 */ public GcCameraFollowSettings CharacterSitCam;
        [NMS(Index = 104)]
        /* 0x2080 */ public GcCameraFollowSettings CharacterSpaceCam;
        [NMS(Index = 105)]
        /* 0x2170 */ public GcCameraFollowSettings CharacterSteepSlopeCam;
        [NMS(Index = 89)]
        /* 0x2260 */ public GcCameraFollowSettings CharacterUnarmedCam;
        [NMS(Index = 106)]
        /* 0x2350 */ public GcCameraFollowSettings CharacterUnderwaterCam;
        [NMS(Index = 107)]
        /* 0x2440 */ public GcCameraFollowSettings CharacterUnderwaterCombatCam;
        [NMS(Index = 108)]
        /* 0x2530 */ public GcCameraFollowSettings CharacterUnderwaterJetpackCam;
        [NMS(Index = 127)]
        /* 0x2620 */ public GcCameraFollowSettings DropshipFollowCam;
        [NMS(Index = 118)]
        /* 0x2710 */ public GcCameraFollowSettings HovercraftFollowCam;
        [NMS(Index = 124)]
        /* 0x2800 */ public GcCameraFollowSettings MechCombatCam;
        [NMS(Index = 18)]
        /* 0x28F0 */ public GcCameraFollowSettings MechFirstPersonCam;
        [NMS(Index = 123)]
        /* 0x29E0 */ public GcCameraFollowSettings MechFollowCam;
        [NMS(Index = 125)]
        /* 0x2AD0 */ public GcCameraFollowSettings MechJetpackCam;
        [NMS(Index = 133)]
        /* 0x2BC0 */ public GcCameraFollowSettings RobotShipFollowCam;
        [NMS(Index = 129)]
        /* 0x2CB0 */ public GcCameraFollowSettings RoyalShipFollowCam;
        [NMS(Index = 130)]
        /* 0x2DA0 */ public GcCameraFollowSettings SailShipFollowCam;
        [NMS(Index = 131)]
        /* 0x2E90 */ public GcCameraFollowSettings ScienceShipFollowCam;
        [NMS(Index = 128)]
        /* 0x2F80 */ public GcCameraFollowSettings ShuttleFollowCam;
        [NMS(Index = 126)]
        /* 0x3070 */ public GcCameraFollowSettings SpaceshipFollowCam;
        [NMS(Index = 119)]
        /* 0x3160 */ public GcCameraFollowSettings SubmarineFollowCam;
        [NMS(Index = 122)]
        /* 0x3250 */ public GcCameraFollowSettings TruckFollowCam;
        [NMS(Index = 17)]
        /* 0x3340 */ public GcCameraFollowSettings VehicleCam;
        [NMS(Index = 16)]
        /* 0x3430 */ public GcCameraFollowSettings VehicleCamHmd;
        [NMS(Index = 121)]
        /* 0x3520 */ public GcCameraFollowSettings WheeledBikeFollowCam;
        [NMS(Index = 349)]
        /* 0x3610 */ public GcCameraAnimationData AmbientCameraAnimations;
        [NMS(Index = 350)]
        /* 0x3628 */ public TkModelResource AmbientDroneAnimations;
        [NMS(Index = 9)]
        /* 0x3640 */ public List<GcCameraAerialViewDataTableEntry> AerialViewDataTable;
        [NMS(Index = 351)]
        /* 0x3650 */ public VariableSizeString CameraAmbientAnimationsData;
        [NMS(Index = 15)]
        /* 0x3660 */ public List<GcCameraFollowSettings> Cameras;
        [NMS(Index = 263)]
        /* 0x3670 */ public List<GcCameraShakeData> CameraShakeTable;
        [NMS(Index = 362)]
        /* 0x3680 */ public List<Vector3f> SavedCameraFacing;
        [NMS(Index = 361)]
        /* 0x3690 */ public List<TkPhysRelVectorData> SavedCameraPositions;
        [NMS(Index = 364)]
        /* 0x36A0 */ public GcCameraWarpSettings FreighterWarpSettings;
        [NMS(Index = 365)]
        /* 0x36F4 */ public GcCameraWarpSettings PirateFreighterWarpSettings;
        [NMS(Index = 363)]
        /* 0x3748 */ public GcCameraWarpSettings WarpSettings;
        [NMS(Index = 6)]
        /* 0x379C */ public GcCameraFocusBuildingControlSettings FocusBuildingModeDistanceControlSettings;
        [NMS(Index = 4)]
        /* 0x37BC */ public GcCameraFocusBuildingControlSettings FocusBuildingModePitchControlSettings;
        [NMS(Index = 7)]
        /* 0x37DC */ public GcCameraFocusBuildingControlSettings FocusBuildingModePlanarControlSettings;
        [NMS(Index = 8)]
        /* 0x37FC */ public GcCameraFocusBuildingControlSettings FocusBuildingModeVerticalControlSettings;
        [NMS(Index = 5)]
        /* 0x381C */ public GcCameraFocusBuildingControlSettings FocusBuildingModeYawControlSettings;
        [NMS(Index = 140)]
        /* 0x383C */ public Vector2f ModelViewFocusOffset;
        [NMS(Index = 176)]
        /* 0x3844 */ public Vector2f PitchForFrigateInteraction;
        [NMS(Index = 177)]
        /* 0x384C */ public Vector2f RotationForFrigateInteraction;
        [NMS(Index = 210)]
        /* 0x3854 */ public float AerialViewBackTime;
        [NMS(Index = 211)]
        /* 0x3858 */ public float AerialViewBlendTime;
        [NMS(Index = 207)]
        /* 0x385C */ public float AerialViewDownDistance;
        [NMS(Index = 208)]
        /* 0x3860 */ public float AerialViewPause;
        [NMS(Index = 209)]
        /* 0x3864 */ public float AerialViewStartTime;
        [NMS(Index = 60)]
        /* 0x3868 */ public float BinocularFlashStrength;
        [NMS(Index = 59)]
        /* 0x386C */ public float BinocularFlashTime;
        [NMS(Index = 266)]
        /* 0x3870 */ public float BobAmount;
        [NMS(Index = 264)]
        /* 0x3874 */ public float BobAmountAbandFreighter;
        [NMS(Index = 267)]
        /* 0x3878 */ public float BobFactor;
        [NMS(Index = 265)]
        /* 0x387C */ public float BobFactorAbandFreighter;
        [NMS(Index = 268)]
        /* 0x3880 */ public float BobFocus;
        [NMS(Index = 272)]
        /* 0x3884 */ public float BobFwdAmount;
        [NMS(Index = 270)]
        /* 0x3888 */ public float BobRollAmount;
        [NMS(Index = 269)]
        /* 0x388C */ public float BobRollFactor;
        [NMS(Index = 271)]
        /* 0x3890 */ public float BobRollOffset;
        [NMS(Index = 203)]
        /* 0x3894 */ public float BuildingModeMaxDistance;
        [NMS(Index = 353)]
        /* 0x3898 */ public float CameraAmbientAutoSwitchMaxTime;
        [NMS(Index = 352)]
        /* 0x389C */ public float CameraAmbientAutoSwitchMinTime;
        [NMS(Index = 273)]
        /* 0x38A0 */ public float CamSeed1;
        [NMS(Index = 274)]
        /* 0x38A4 */ public float CamSeed2;
        [NMS(Index = 277)]
        /* 0x38A8 */ public float CamWander1Amplitude;
        [NMS(Index = 275)]
        /* 0x38AC */ public float CamWander1Phase;
        [NMS(Index = 278)]
        /* 0x38B0 */ public float CamWander2Amplitude;
        [NMS(Index = 276)]
        /* 0x38B4 */ public float CamWander2Phase;
        [NMS(Index = 296)]
        /* 0x38B8 */ public float CharCamAutoDirStartTime;
        [NMS(Index = 299)]
        /* 0x38BC */ public float CharCamDeflectSpeed;
        [NMS(Index = 291)]
        /* 0x38C0 */ public float CharCamFocusHeight;
        [NMS(Index = 294)]
        /* 0x38C4 */ public float CharCamHeight;
        [NMS(Index = 297)]
        /* 0x38C8 */ public float CharCamLookOffset;
        [NMS(Index = 298)]
        /* 0x38CC */ public float CharCamLookOffsetFactor;
        [NMS(Index = 292)]
        /* 0x38D0 */ public float CharCamMaxDistance;
        [NMS(Index = 293)]
        /* 0x38D4 */ public float CharCamMinDistance;
        [NMS(Index = 300)]
        /* 0x38D8 */ public float CharCamMinSpeed;
        [NMS(Index = 295)]
        /* 0x38DC */ public float CharCamOffsetTime;
        [NMS(Index = 301)]
        /* 0x38E0 */ public float CharCamRightStickX;
        [NMS(Index = 302)]
        /* 0x38E4 */ public float CharCamRightStickY;
        [NMS(Index = 306)]
        /* 0x38E8 */ public float CloseFactorSpring;
        [NMS(Index = 346)]
        /* 0x38EC */ public float CreatureInteractionCamSpring;
        [NMS(Index = 333)]
        /* 0x38F0 */ public float CreatureInteractionDistMulMax;
        [NMS(Index = 332)]
        /* 0x38F4 */ public float CreatureInteractionDistMulMin;
        [NMS(Index = 340)]
        /* 0x38F8 */ public float CreatureInteractionDownhillPitchTransfer;
        [NMS(Index = 345)]
        /* 0x38FC */ public float CreatureInteractionFoVMax;
        [NMS(Index = 344)]
        /* 0x3900 */ public float CreatureInteractionFoVMin;
        [NMS(Index = 343)]
        /* 0x3904 */ public float CreatureInteractionFoVSplitSize;
        [NMS(Index = 347)]
        /* 0x3908 */ public float CreatureInteractionHeadHeightSpring;
        [NMS(Index = 339)]
        /* 0x390C */ public float CreatureInteractionMaxDownhillPitchAroundPlayer;
        [NMS(Index = 341)]
        /* 0x3910 */ public float CreatureInteractionMaxUphillPitchAroundPlayer;
        [NMS(Index = 329)]
        /* 0x3914 */ public float CreatureInteractionMinDist;
        [NMS(Index = 338)]
        /* 0x3918 */ public float CreatureInteractionPitchMax;
        [NMS(Index = 337)]
        /* 0x391C */ public float CreatureInteractionPitchMin;
        [NMS(Index = 336)]
        /* 0x3920 */ public float CreatureInteractionPitchSplit;
        [NMS(Index = 331)]
        /* 0x3924 */ public float CreatureInteractionPushCameraDownAmount;
        [NMS(Index = 330)]
        /* 0x3928 */ public float CreatureInteractionPushCameraDownForCreatureBiggerThan;
        [NMS(Index = 342)]
        /* 0x392C */ public float CreatureInteractionUphillPitchTransfer;
        [NMS(Index = 335)]
        /* 0x3930 */ public float CreatureInteractionYawMax;
        [NMS(Index = 334)]
        /* 0x3934 */ public float CreatureInteractionYawMin;
        [NMS(Index = 328)]
        /* 0x3938 */ public float CreatureSizeMax;
        [NMS(Index = 327)]
        /* 0x393C */ public float CreatureSizeMin;
        [NMS(Index = 255)]
        /* 0x3940 */ public float DebugAICamAt;
        [NMS(Index = 254)]
        /* 0x3944 */ public float DebugAICamUp;
        [NMS(Index = 281)]
        /* 0x3948 */ public float DebugCameraFastFactor;
        [NMS(Index = 283)]
        /* 0x394C */ public float DebugCameraHeightForAccelerateBegin;
        [NMS(Index = 285)]
        /* 0x3950 */ public float DebugCameraHeightForAccelerateEnd;
        [NMS(Index = 286)]
        /* 0x3954 */ public float DebugCameraMaxSpeed;
        [NMS(Index = 280)]
        /* 0x3958 */ public float DebugCameraSlowFactor;
        [NMS(Index = 282)]
        /* 0x395C */ public float DebugCameraSpaceFastFactor;
        [NMS(Index = 284)]
        /* 0x3960 */ public float DebugCameraSpeedAtPlanetThreshold;
        [NMS(Index = 252)]
        /* 0x3964 */ public float DebugMoveCamHeight;
        [NMS(Index = 251)]
        /* 0x3968 */ public float DebugMoveCamSpeed;
        [NMS(Index = 28)]
        /* 0x396C */ public float DebugPlanetJumpFarHeight;
        [NMS(Index = 27)]
        /* 0x3970 */ public float DebugPlanetJumpNearHeight;
        [NMS(Index = 279)]
        /* 0x3974 */ public float DebugSpaceStationTeleportOffset;
        [NMS(Index = 168)]
        /* 0x3978 */ public float DistanceForFleetInteraction;
        [NMS(Index = 169)]
        /* 0x397C */ public float DistanceForFrigateInteraction;
        [NMS(Index = 170)]
        /* 0x3980 */ public float DistanceForFrigatePurchaseInteraction;
        [NMS(Index = 303)]
        /* 0x3984 */ public float FirstPersonCamHeight;
        [NMS(Index = 307)]
        /* 0x3988 */ public float FirstPersonFoV;
        [NMS(Index = 261)]
        /* 0x398C */ public float FirstPersonSlerpAway;
        [NMS(Index = 262)]
        /* 0x3990 */ public float FirstPersonSlerpTowards;
        [NMS(Index = 310)]
        /* 0x3994 */ public float FirstPersonZoom1FoV;
        [NMS(Index = 311)]
        /* 0x3998 */ public float FirstPersonZoom2FoV;
        [NMS(Index = 173)]
        /* 0x399C */ public float FleetUIOrbitRate;
        [NMS(Index = 175)]
        /* 0x39A0 */ public float FleetUIVerticalMotionAmplitude;
        [NMS(Index = 174)]
        /* 0x39A4 */ public float FleetUIVerticalMotionDuration;
        [NMS(Index = 58)]
        /* 0x39A8 */ public float FlybyInVehicleDamper;
        [NMS(Index = 54)]
        /* 0x39AC */ public float FlybyMinRange;
        [NMS(Index = 56)]
        /* 0x39B0 */ public float FlybyMinRelativeSpeed;
        [NMS(Index = 55)]
        /* 0x39B4 */ public float FlybyRange;
        [NMS(Index = 57)]
        /* 0x39B8 */ public float FlybyRelativeSpeedRange;
        [NMS(Index = 3)]
        /* 0x39BC */ public float FocusBuildingModeMaxFOV;
        [NMS(Index = 2)]
        /* 0x39C0 */ public float FocusBuildingModeMinFOV;
        [NMS(Index = 1)]
        /* 0x39C4 */ public float FocusBuildingModeStartDistance;
        [NMS(Index = 325)]
        /* 0x39C8 */ public float FoVAdjust;
        [NMS(Index = 322)]
        /* 0x39CC */ public float FoVSpring;
        [NMS(Index = 323)]
        /* 0x39D0 */ public float FoVSpringSights;
        [NMS(Index = 324)]
        /* 0x39D4 */ public float FoVSpringSightsPassive;
        [NMS(Index = 162)]
        /* 0x39D8 */ public float FrigateCaptainLateralShiftAmount;
        [NMS(Index = 137)]
        /* 0x39DC */ public float FrontendModelCameraSpringTime;
        [NMS(Index = 23)]
        /* 0x39E0 */ public float HmdEyeExtraTurnAngle;
        [NMS(Index = 25)]
        /* 0x39E4 */ public float HmdEyeExtraTurnHeadAngleRange;
        [NMS(Index = 24)]
        /* 0x39E8 */ public float HmdEyeExtraTurnMinHeadAngle;
        [NMS(Index = 22)]
        /* 0x39EC */ public float HmdEyeLookAngle;
        [NMS(Index = 259)]
        /* 0x39F0 */ public float IndoorCamShakeDamper;
        [NMS(Index = 152)]
        /* 0x39F4 */ public float InteractionHeadHeightDefault;
        [NMS(Index = 153)]
        /* 0x39F8 */ public float InteractionHeadHeightGek;
        [NMS(Index = 155)]
        /* 0x39FC */ public float InteractionHeadHeightSpiderman;
        [NMS(Index = 154)]
        /* 0x3A00 */ public float InteractionHeadHeightVykeen;
        [NMS(Index = 159)]
        /* 0x3A04 */ public float InteractionHeadPosHeightAdjust;
        [NMS(Index = 161)]
        /* 0x3A08 */ public float InteractionHeadPosHeightAdjustSpiderman;
        [NMS(Index = 160)]
        /* 0x3A0C */ public float InteractionHeadPosHeightAdjustVykeen;
        [NMS(Index = 178)]
        /* 0x3A10 */ public float InteractionModeBlendTime;
        [NMS(Index = 179)]
        /* 0x3A14 */ public float InteractionModeFocusCamBlend;
        [NMS(Index = 180)]
        /* 0x3A18 */ public float InteractionModeFoV;
        [NMS(Index = 158)]
        /* 0x3A1C */ public float InteractionPitchAdjustDeadZone;
        [NMS(Index = 157)]
        /* 0x3A20 */ public float InteractionPitchAdjustStrength;
        [NMS(Index = 156)]
        /* 0x3A24 */ public float InteractionPitchAdjustTime;
        [NMS(Index = 166)]
        /* 0x3A28 */ public float LocalMissionBoardLateralShiftAmount;
        [NMS(Index = 63)]
        /* 0x3A2C */ public float MaxCreatureRidingYaw;
        [NMS(Index = 62)]
        /* 0x3A30 */ public float MaxFirstPersonCameraPitch;
        [NMS(Index = 87)]
        /* 0x3A34 */ public float MechCameraArmShootOffsetY;
        [NMS(Index = 88)]
        /* 0x3A38 */ public float MechCameraCombatFakeSpeed;
        [NMS(Index = 86)]
        /* 0x3A3C */ public float MechCameraExtraYPostLandingBlendTime;
        [NMS(Index = 85)]
        /* 0x3A40 */ public float MechCameraNoExtraYTimeAfterLand;
        [NMS(Index = 221)]
        /* 0x3A44 */ public float MechCamSpringStrengthMax;
        [NMS(Index = 220)]
        /* 0x3A48 */ public float MechCamSpringStrengthMin;
        [NMS(Index = 205)]
        /* 0x3A4C */ public float MeleeBoostedFoV;
        [NMS(Index = 206)]
        /* 0x3A50 */ public float MeleeFoV;
        [NMS(Index = 61)]
        /* 0x3A54 */ public float MinFirstPersonCameraPitch;
        [NMS(Index = 182)]
        /* 0x3A58 */ public float MinInteractFocusAngle;
        [NMS(Index = 38)]
        /* 0x3A5C */ public float MiniportalFlashStrength;
        [NMS(Index = 37)]
        /* 0x3A60 */ public float MiniportalFlashTime;
        [NMS(Index = 248)]
        /* 0x3A64 */ public float ModelViewDefaultPitch;
        [NMS(Index = 249)]
        /* 0x3A68 */ public float ModelViewDefaultYaw;
        [NMS(Index = 245)]
        /* 0x3A6C */ public float ModelViewDistSpeed;
        [NMS(Index = 138)]
        /* 0x3A70 */ public float ModelViewFlashTime;
        [NMS(Index = 183)]
        /* 0x3A74 */ public float ModelViewInterpTime;
        [NMS(Index = 247)]
        /* 0x3A78 */ public float ModelViewMaxDist;
        [NMS(Index = 246)]
        /* 0x3A7C */ public float ModelViewMinDist;
        [NMS(Index = 244)]
        /* 0x3A80 */ public float ModelViewMouseMoveSpeed;
        [NMS(Index = 243)]
        /* 0x3A84 */ public float ModelViewMouseRotateSnapStrength;
        [NMS(Index = 242)]
        /* 0x3A88 */ public float ModelViewMouseRotateSpeed;
        [NMS(Index = 241)]
        /* 0x3A8C */ public float ModelViewRotateSpeed;
        [NMS(Index = 240)]
        /* 0x3A90 */ public float MouseSensitivity;
        [NMS(Index = 260)]
        /* 0x3A94 */ public float NoControlCamShakeDamper;
        [NMS(Index = 165)]
        /* 0x3A98 */ public float NPCTradeLateralShiftAmount;
        [NMS(Index = 167)]
        /* 0x3A9C */ public float NPCTradeLateralShiftTime;
        [NMS(Index = 290)]
        /* 0x3AA0 */ public float ObjectFocusTime;
        [NMS(Index = 287)]
        /* 0x3AA4 */ public float OffsetCamFOV;
        [NMS(Index = 12)]
        /* 0x3AA8 */ public float OffsetCombatCameraHorizontalAngle;
        [NMS(Index = 257)]
        /* 0x3AAC */ public float PainShakeTime;
        [NMS(Index = 196)]
        /* 0x3AB0 */ public float PhotoModeCollisionRadius;
        [NMS(Index = 198)]
        /* 0x3AB4 */ public float PhotoModeFlashDuration;
        [NMS(Index = 199)]
        /* 0x3AB8 */ public float PhotoModeFlashIntensity;
        [NMS(Index = 192)]
        /* 0x3ABC */ public float PhotoModeMaxDistance;
        [NMS(Index = 195)]
        /* 0x3AC0 */ public float PhotoModeMaxDistanceClampBuffer;
        [NMS(Index = 194)]
        /* 0x3AC4 */ public float PhotoModeMaxDistanceClampForce;
        [NMS(Index = 193)]
        /* 0x3AC8 */ public float PhotoModeMaxDistanceSpace;
        [NMS(Index = 190)]
        /* 0x3ACC */ public float PhotoModeMoveSpeed;
        [NMS(Index = 197)]
        /* 0x3AD0 */ public float PhotoModeRollSpeed;
        [NMS(Index = 191)]
        /* 0x3AD4 */ public float PhotoModeTurnSpeed;
        [NMS(Index = 189)]
        /* 0x3AD8 */ public float PhotoModeVelocitySmoothTime;
        [NMS(Index = 163)]
        /* 0x3ADC */ public float PilotDetailsLateralShiftAmount;
        [NMS(Index = 164)]
        /* 0x3AE0 */ public float RecruitmentLateralShiftAmount;
        [NMS(Index = 19)]
        /* 0x3AE4 */ public float RevealedNPCHeadOffset;
        [NMS(Index = 204)]
        /* 0x3AE8 */ public float RunningFoVAdjust;
        [NMS(Index = 0)]
        /* 0x3AEC */ public float ScanCameraLookAtTime;
        [NMS(Index = 10)]
        /* 0x3AF0 */ public float SClassLandingShakeMultiplier;
        [NMS(Index = 217)]
        /* 0x3AF4 */ public float ScreenshotBackDistance;
        [NMS(Index = 215)]
        /* 0x3AF8 */ public float ScreenshotBendDownAmount;
        [NMS(Index = 214)]
        /* 0x3AFC */ public float ScreenshotHorizonFaceFactor;
        [NMS(Index = 213)]
        /* 0x3B00 */ public float ScreenshotHorizonHeight;
        [NMS(Index = 218)]
        /* 0x3B04 */ public float ScreenshotInTime;
        [NMS(Index = 219)]
        /* 0x3B08 */ public float ScreenshotOutTime;
        [NMS(Index = 216)]
        /* 0x3B0C */ public float ScreenshotRightDistance;
        [NMS(Index = 181)]
        /* 0x3B10 */ public float ShipBuilderFoV;
        [NMS(Index = 239)]
        /* 0x3B14 */ public float ShipCamAimFOV;
        [NMS(Index = 227)]
        /* 0x3B18 */ public float ShipCamLookInterp;
        [NMS(Index = 228)]
        /* 0x3B1C */ public float ShipCamMinReturnTime;
        [NMS(Index = 235)]
        /* 0x3B20 */ public float ShipCamMotionInterp;
        [NMS(Index = 234)]
        /* 0x3B24 */ public float ShipCamMotionMaxLagPitchAngle;
        [NMS(Index = 233)]
        /* 0x3B28 */ public float ShipCamMotionMaxLagTurnAngle;
        [NMS(Index = 231)]
        /* 0x3B2C */ public float ShipCamMotionPitch;
        [NMS(Index = 232)]
        /* 0x3B30 */ public float ShipCamMotionPitchMod;
        [NMS(Index = 230)]
        /* 0x3B34 */ public float ShipCamMotionTurn;
        [NMS(Index = 225)]
        /* 0x3B38 */ public float ShipCamPitch;
        [NMS(Index = 226)]
        /* 0x3B3C */ public float ShipCamPitchMod;
        [NMS(Index = 229)]
        /* 0x3B40 */ public float ShipCamReturnTime;
        [NMS(Index = 237)]
        /* 0x3B44 */ public float ShipCamRollAmountMax;
        [NMS(Index = 236)]
        /* 0x3B48 */ public float ShipCamRollAmountMin;
        [NMS(Index = 238)]
        /* 0x3B4C */ public float ShipCamRollSpeedScaler;
        [NMS(Index = 223)]
        /* 0x3B50 */ public float ShipCamSpringStrengthMax;
        [NMS(Index = 222)]
        /* 0x3B54 */ public float ShipCamSpringStrengthMin;
        [NMS(Index = 224)]
        /* 0x3B58 */ public float ShipCamTurn;
        [NMS(Index = 51)]
        /* 0x3B5C */ public float ShipFirstPersonBlendOffset;
        [NMS(Index = 50)]
        /* 0x3B60 */ public float ShipFirstPersonBlendTime;
        [NMS(Index = 318)]
        /* 0x3B64 */ public float ShipFoVBoost;
        [NMS(Index = 314)]
        /* 0x3B68 */ public float ShipFoVMax;
        [NMS(Index = 317)]
        /* 0x3B6C */ public float ShipFoVMax3rdPerson;
        [NMS(Index = 312)]
        /* 0x3B70 */ public float ShipFoVMin;
        [NMS(Index = 313)]
        /* 0x3B74 */ public float ShipFoVMin2;
        [NMS(Index = 316)]
        /* 0x3B78 */ public float ShipFoVMin3rdPerson;
        [NMS(Index = 319)]
        /* 0x3B7C */ public float ShipFoVMiniJump;
        [NMS(Index = 320)]
        /* 0x3B80 */ public float ShipFoVSpring;
        [NMS(Index = 321)]
        /* 0x3B84 */ public float ShipMiniJumpFoVSpring;
        [NMS(Index = 258)]
        /* 0x3B88 */ public float ShipShakeDamper;
        [NMS(Index = 47)]
        /* 0x3B8C */ public float ShipThirdPersonBlendOffset;
        [NMS(Index = 49)]
        /* 0x3B90 */ public float ShipThirdPersonBlendOutOffset;
        [NMS(Index = 48)]
        /* 0x3B94 */ public float ShipThirdPersonBlendOutTime;
        [NMS(Index = 45)]
        /* 0x3B98 */ public float ShipThirdPersonBlendTime;
        [NMS(Index = 46)]
        /* 0x3B9C */ public float ShipThirdPersonBlendWithOffsetTime;
        [NMS(Index = 53)]
        /* 0x3BA0 */ public float ShipThirdPersonEnterBlendOffset;
        [NMS(Index = 52)]
        /* 0x3BA4 */ public float ShipThirdPersonEnterBlendTime;
        [NMS(Index = 315)]
        /* 0x3BA8 */ public float ShipWarpFoV;
        [NMS(Index = 20)]
        /* 0x3BAC */ public float SpecialVehicleMouseRecentreTime;
        [NMS(Index = 21)]
        /* 0x3BB0 */ public float SpecialVehicleMouseRecentreWeaponTime;
        [NMS(Index = 35)]
        /* 0x3BB4 */ public float ThirdPersonAfterIntroCamBlendTime;
        [NMS(Index = 184)]
        /* 0x3BB8 */ public float ThirdPersonBlendInTime;
        [NMS(Index = 185)]
        /* 0x3BBC */ public float ThirdPersonBlendOutTime;
        [NMS(Index = 115)]
        /* 0x3BC0 */ public float ThirdPersonCameraChangeBlendTime;
        [NMS(Index = 116)]
        /* 0x3BC4 */ public float ThirdPersonCameraChangeMinimumBlend;
        [NMS(Index = 66)]
        /* 0x3BC8 */ public float ThirdPersonCloseDistance;
        [NMS(Index = 67)]
        /* 0x3BCC */ public float ThirdPersonCloseDistanceX;
        [NMS(Index = 65)]
        /* 0x3BD0 */ public float ThirdPersonClosePitch;
        [NMS(Index = 186)]
        /* 0x3BD4 */ public float ThirdPersonCollisionPushOffsetReducerStart;
        [NMS(Index = 309)]
        /* 0x3BD8 */ public float ThirdPersonCombatFoV;
        [NMS(Index = 74)]
        /* 0x3BDC */ public float ThirdPersonDownhillAdjustMaxAngle;
        [NMS(Index = 78)]
        /* 0x3BE0 */ public float ThirdPersonDownhillAdjustMaxAnglePrime;
        [NMS(Index = 73)]
        /* 0x3BE4 */ public float ThirdPersonDownhillAdjustMinAngle;
        [NMS(Index = 77)]
        /* 0x3BE8 */ public float ThirdPersonDownhillAdjustMinAnglePrime;
        [NMS(Index = 72)]
        /* 0x3BEC */ public float ThirdPersonDownhillAdjustSpringTimeMax;
        [NMS(Index = 71)]
        /* 0x3BF0 */ public float ThirdPersonDownhillAdjustSpringTimeMin;
        [NMS(Index = 308)]
        /* 0x3BF4 */ public float ThirdPersonFoV;
        [NMS(Index = 187)]
        /* 0x3BF8 */ public float ThirdPersonOffsetSpringTime;
        [NMS(Index = 68)]
        /* 0x3BFC */ public float ThirdPersonRotationBackAdjustAngleMax;
        [NMS(Index = 64)]
        /* 0x3C00 */ public float ThirdPersonRotationBackAdjustAngleMin;
        [NMS(Index = 36)]
        /* 0x3C04 */ public float ThirdPersonSkipIntroCamBlendTime;
        [NMS(Index = 82)]
        /* 0x3C08 */ public float ThirdPersonUphillAdjustCrossSlopeMaxAngle;
        [NMS(Index = 81)]
        /* 0x3C0C */ public float ThirdPersonUphillAdjustCrossSlopeMinAngle;
        [NMS(Index = 76)]
        /* 0x3C10 */ public float ThirdPersonUphillAdjustMaxAngle;
        [NMS(Index = 80)]
        /* 0x3C14 */ public float ThirdPersonUphillAdjustMaxAnglePrime;
        [NMS(Index = 75)]
        /* 0x3C18 */ public float ThirdPersonUphillAdjustMinAngle;
        [NMS(Index = 79)]
        /* 0x3C1C */ public float ThirdPersonUphillAdjustMinAnglePrime;
        [NMS(Index = 70)]
        /* 0x3C20 */ public float ThirdPersonUphillAdjustSpringTimeMax;
        [NMS(Index = 69)]
        /* 0x3C24 */ public float ThirdPersonUphillAdjustSpringTimeMin;
        [NMS(Index = 29)]
        /* 0x3C28 */ public float TogglePerspectiveBlendTime;
        [NMS(Index = 34)]
        /* 0x3C2C */ public float UnderwaterCameraExtraVertOffset;
        [NMS(Index = 31)]
        /* 0x3C30 */ public float UnderwaterCameraSurfaceOffset;
        [NMS(Index = 33)]
        /* 0x3C34 */ public float UnderwaterCameraVertRotationForExtraOffsetMax;
        [NMS(Index = 32)]
        /* 0x3C38 */ public float UnderwaterCameraVertRotationForExtraOffsetMin;
        [NMS(Index = 41)]
        /* 0x3C3C */ public float VehicleExitFlashStrength;
        [NMS(Index = 40)]
        /* 0x3C40 */ public float VehicleExitFlashTime;
        [NMS(Index = 43)]
        /* 0x3C44 */ public float VehicleFirstToThirdExitOffsetY;
        [NMS(Index = 44)]
        /* 0x3C48 */ public float VehicleFirstToThirdExitOffsetZ;
        [NMS(Index = 84)]
        /* 0x3C4C */ public float VehicleThirdPersonShootOffsetBlendOutTime;
        [NMS(Index = 83)]
        /* 0x3C50 */ public float VehicleThirdPersonShootOffsetReturnTime;
        [NMS(Index = 256)]
        /* 0x3C54 */ public float VRShakeMultiplier;
        [NMS(Index = 212)]
        /* 0x3C58 */ public TkCurveType AerialViewCurve;
        [NMS(Index = 326)]
        /* 0x3C59 */ public bool CreatureInteractionInterpolateDuringHold;
        [NMS(Index = 253)]
        /* 0x3C5A */ public bool DebugAICam;
        [NMS(Index = 250)]
        /* 0x3C5B */ public bool DebugMoveCam;
        [NMS(Index = 348)]
        /* 0x3C5C */ public bool FollowDrawCamProbes;
        [NMS(Index = 30)]
        /* 0x3C5D */ public bool LockFollowSpring;
        [NMS(Index = 188)]
        /* 0x3C5E */ public bool MaxBob;
        [NMS(Index = 11)]
        /* 0x3C5F */ public bool OffsetCombatCameraHorizontal;
        [NMS(Index = 26)]
        /* 0x3C60 */ public bool PauseThirdPersonCamInPause;
    }
}
