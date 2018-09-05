namespace libMBIN.Models.Structs.Unfinished
{
    public class GcCharacterGlobals : NMSTemplate
    {
        [NMS(Size = 0x80)]
        /* 0x000 */ public string CharacterFile;
        /* 0x080 */ public GcSeed CharacterSeedOverride;
        /* 0x90 */ public float DontShowCharacterWithinCameraDistance;
        /* 0x94 */ public float CharacterTurnSpeed;
        /* 0x98 */ public float CharacterJetpackTurnSpeed;
        /* 0x9C */ public float CharacterJetpackTurnAimSpeed;
        /* 0xA0 */ public float CharacterTurnAimSpeed;
        /* 0xA4 */ public float CharacterSwimmingTurnSpeed;
        /* 0xA8 */ public float CharacterSwimmingTurnAimSpeed;
        /* 0xAC */ public float FeetShiftOnTurnSpeed;
        /* 0xB0 */ public float FeetShiftOnTurnMaxSpeed;
        /* 0xB4 */ public float MinTurnAngle;
        /* 0xB8 */ public float YawPullSpeed;
        /* 0xBC */ public float GunRotationSpeed;
        /* 0xC0 */ public float AimPitchAnimScale;
        /* 0xC4 */ public float AimYawAnimScale;
        /* 0xC8 */ public float AimPitchInterpSpeed;
        /* 0xCC */ public float MinSwimmingPitchRotation;
        /* 0xD0 */ public float MaxSwimmingPitchRotation;
        /* 0xD4 */ public float MinSwimmingRollRotation;
        /* 0xD8 */ public float MaxSwimmingRollRotation;
        /* 0xDC */ public float SwimmingSmoothTime;
        /* 0xE0 */ public float SwimmingSmoothTimeWithWeapon;
        /* 0xE4 */ public float SwimmingRollSmoothTime;
        /* 0xE8 */ public float SwimmingRollSmoothTimeWithWeapon;
        /* 0xEC */ public float LadderDistanceToAutoMount;
        /* 0xF0 */ public float LadderCooldownAfterBeforeAutoClimb;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0xF4 */ public byte[] PaddingF4;
        [NMS(Size = 0x10)]
        /* 0xF8 */ public string LadderClimbIdle;
        [NMS(Size = 0x10)]
        /* 0x108 */ public string LadderClimbUp;
        [NMS(Size = 0x10)]
        /* 0x118 */ public string LadderClimbDown;
        [NMS(Size = 0x10)]
        /* 0x128 */ public string LadderMountBottom;
        [NMS(Size = 0x10)]
        /* 0x138 */ public string LadderDismountBottom;
        [NMS(Size = 0x10)]
        /* 0x148 */ public string LadderMountTop;
        [NMS(Size = 0x10)]
        /* 0x158 */ public string LadderDismountTop;
        /* 0x168 */ public float SlopeAngleForUphillClimb;
        /* 0x16C */ public float SlopeAngleForDownhillClimb;
        /* 0x170 */ public float SlidingBrake;
        /* 0x174 */ public float SlopeAngleForSlide;
        /* 0x178 */ public float UphillSpeedMultiplier;
        /* 0x17C */ public float TrudgeUphillSpeed;
        /* 0x180 */ public float MaxAnkleRotationAngle;
        /* 0x184 */ public float RotateToFaceSlopeSpeed;
        /* 0x188 */ public float TimeNotOnGroundToBeConsideredInAir;
        /* 0x18C */ public float TimeNotOnGroundToUseFallingCamera;
        /* 0x190 */ public float TimeFallingUntilPanic;
        /* 0x194 */ public float BankingMinimumSpeed;
        /* 0x198 */ public float BankingMaxStrength;
        /* 0x19C */ public float BankingSpeedForMaxStrength;
        /* 0x1A0 */ public float MinimumIdleToJogAnimSpeed;
        /* 0x1A4 */ public float RootedAnimInterpolationTime;
        /* 0x1A8 */ public float IKLegStretchStrength;
        /* 0x1AC */ public float IkBlendStrengthSpeed;
        /* 0x1B0 */ public float FootPlantedTolerance;
        /* 0x1B4 */ public float FootPlantSpring;
        /* 0x1B8 */ public float BlendToNewFeetSpeed;
        /* 0x1BC */ public float TimeAfterDeathRagdollIsEnabledForward;
        /* 0x1C0 */ public float TimeAfterDeathRagdollIsEnabledBackward;
        /* 0x1C4 */ public float TimeAfterDeathRagdollIsEnabledWhenBlocked;
        /* 0x1C8 */ public float RagdollTau;
        /* 0x1CC */ public float RagdollDamping;
        /* 0x1D0 */ public float RagdollConeLimit;
        /* 0x1D4 */ public float RagdollTwistLimit;
        /* 0x1D8 */ public float RagdollMotorFadeStart;
        /* 0x1DC */ public float RagdollMotorFadeEnd;
        /* 0x1E0 */ public float MinStickForIntoJogAnim;
        /* 0x1E4 */ public float SmoothVelocitySpeed;
        /* 0x1E8 */ public float TimeToShowSplashEffect;
        /* 0x1EC */ public float UnderwaterToAirTolerance;
        /* 0x1F0 */ public float WaterBottomSmoothPushUp;
        /* 0x1F4 */ public float WaterBottomSmoothPushUpDepth;
    }
}
