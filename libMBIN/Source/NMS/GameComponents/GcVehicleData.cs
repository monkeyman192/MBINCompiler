using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x1030, GUID = 0xAE76290DFDABEA7, NameHash = 0x904DB42CF570F4BB)]
    public class GcVehicleData : NMSTemplate
    {
        /* 0x000 */ public NMSString0x10 Name;
        /* 0x010 */ public int NumWheels;
        /* 0x014 */ public float WheelRadius;
        /* 0x018 */ public float WheelGuardExtraRadius;
        /* 0x01C */ public float WheelGuardExtraHeight;
        /* 0x020 */ public float WheelGuardAdjustUpwards;
        /* 0x024 */ public float UnderwaterEnginePower;
        /* 0x028 */ public float UnderwaterEngineMaxSpeed;
        /* 0x02C */ public float UnderwaterEngineFalloff;
        /* 0x030 */ public float UnderwaterEngineDirectionBrake;
        /* 0x034 */ public float UnderwaterEngineDirectionBrakeVertical;
        /* 0x038 */ public float UnderwaterAlignDir;
        /* 0x03C */ public float UnderwaterAlignUp;
        /* 0x040 */ public float VisualRollAmount;
        /* 0x044 */ public float VisualRollOffsetY;
        /* 0x048 */ public float SteeringWheelSpringMultiplier;
        /* 0x04C */ public float SteeringWheelPushRange;
        [NMS(Size = 0xA)]
        /* 0x050 */ public Vector4f[] WheelLocs;
        [NMS(Size = 0xA)]
        /* 0x0F0 */ public NMSString0x20[] WheelNames;
        [NMS(Size = 0xA)]
        /* 0x230 */ public NMSString0x20[] WheelSuspensionNames;
        [NMS(Size = 0xA)]
        /* 0x370 */ public float[] WheelRayFakeWidthFactor;
        [NMS(Size = 0xA)]
        /* 0x398 */ public float[] WheelRadiusMultiplier;
        [NMS(Size = 0xA)]
        /* 0x3C0 */ public NMSString0x10[] SuspensionAnimNames;
        /* 0x460 */ public bool CustomCollision;
        /* 0x470 */ public Vector3f CollOffset;
        /* 0x480 */ public Vector3f ExtraCollOffset;
        /* 0x490 */ public Vector3f CollDimensions;
        /* 0x4A0 */ public Vector3f InertiaDimensions;
        /* 0x4B0 */ public float CollRadius;
        /* 0x4B4 */ public float InertiaMull;
        /* 0x4B8 */ public float WheelSuspensionlength;
        /* 0x4BC */ public float WheelSuspensionForce;
        /* 0x4C0 */ public float WheelSuspensionDamping;
        /* 0x4C4 */ public float WheelSuspensionAnimMin;
        /* 0x4C8 */ public float WheelSuspensionAnimMax;
        /* 0x4CC */ public float TopSpeedForward;
        /* 0x4D0 */ public float TopSpeedReverse;
        /* 0x4D4 */ public float WheelMaxAccelForceForward;
        /* 0x4D8 */ public float WheelMaxAccelForceReverse;
        /* 0x4DC */ public float WheelMaxDecelForceNonBraking;
        /* 0x4E0 */ public float WheelMaxDecelForceBraking;
        /* 0x4E4 */ public float WheelSpinniness;
        /* 0x4E8 */ public float WheelDragginess;
        /* 0x4EC */ public float HardStopSpeedThreshold;
        /* 0x4F0 */ public float WheelFrontFrictionOmega;
        /* 0x4F4 */ public float WheelFrontFrictionDynamic;
        /* 0x4F8 */ public float WheelFrontFrictionDynamicThreshold;
        /* 0x4FC */ public float WheelFrontFrictionStatic;
        /* 0x500 */ public float WheelFrontFrictionStaticThreshold;
        /* 0x504 */ public float WheelSideFrictionOmega;
        /* 0x508 */ public float WheelSideFrictionDynamic;
        /* 0x50C */ public float WheelSideFrictionDynamicThreshold;
        /* 0x510 */ public float WheelSideFrictionStatic;
        /* 0x514 */ public float WheelSideFrictionStaticThreshold;
        /* 0x518 */ public bool LockVehicleAxis;
        /* 0x51C */ public float TurningWheelForce;
        /* 0x520 */ public float TurningWheelForceVR;
        /* 0x524 */ public float TurningWheelFrictionOmega;
        /* 0x528 */ public float TurningWheelFrictionNonBraking;
        /* 0x52C */ public float TurningWheelFrictionBraking;
        /* 0x530 */ public Vector3f WheelForwardAngularFactor;
        /* 0x540 */ public Vector3f WheelTurnAngularFactor;
        /* 0x550 */ public Vector3f WheelSuspensionAngularFactor;
        /* 0x560 */ public Vector3f WheelSideAngularFactor;
        /* 0x570 */ public float VehicleGravity;
        /* 0x574 */ public float VehicleGravityWater;
        /* 0x578 */ public float VehicleJumpForce;
        /* 0x57C */ public float VehicleJumpAirControlForce;
        /* 0x580 */ public float VehicleBoostForce;
        /* 0x584 */ public float VehicleBoostMaxSpeed;
        /* 0x588 */ public float VehicleBoostExtraMaxSpeedAir;
        /* 0x58C */ public float VehicleBoostSpeedFalloff;
        /* 0x590 */ public float VehicleBoostTime;
        /* 0x594 */ public float VehicleBoostRechargeTime;
        /* 0x598 */ public float VehicleJumpAirRotateXAmount;
        /* 0x59C */ public float VehicleJumpAirRotateZAmount;
        /* 0x5A0 */ public float VehicleJumpAirRotateTimeMin;
        /* 0x5A4 */ public float VehicleJumpAirRotateTimeMax;
        /* 0x5A8 */ public float VehicleJumpAirMaxTorque;
        /* 0x5AC */ public bool UseBuggySuspensionHack;
        /* 0x5AD */ public bool UseRoverWheelHack;
        [NMS(Size = 0x2, Ignore = true)]
        /* 0x5AE */ public byte[] Padding5AE;
        /* 0x5B0 */ public NMSString0x10 SideSkidParticle;
        /* 0x5C0 */ public float SideSkidParticleMinRate;
        /* 0x5C4 */ public float SideSkidParticleMaxRate;
        /* 0x5C8 */ public float SideSkidParticleMinThresh;
        /* 0x5CC */ public float SideSkidParticleMaxThresh;
        /* 0x5D0 */ public NMSString0x10 WheelSpinParticle;
        /* 0x5E0 */ public float WheelSpinParticleMinRate;
        /* 0x5E4 */ public float WheelSpinParticleMaxRate;
        /* 0x5E8 */ public float WheelSpinParticleMinThresh;
        /* 0x5EC */ public float WheelSpinParticleMaxThresh;
        /* 0x5F0 */ public float WheelGuardVerticalResponseMin;
        /* 0x5F4 */ public float WheelGuardVerticalResponseMax;
        /* 0x5F8 */ public float WheelGuardPenetrationScaleMin;
        /* 0x5FC */ public float WheelGuardPenetrationScaleMax;
        /* 0x600 */ public float WheelGuardPenetrationScaleMinClamp;
        /* 0x604 */ public float WheelGuardMassScaleMin;
        /* 0x608 */ public float WheelGuardMassScaleMax;
        /* 0x60C */ public float WheelGuardMassScaleMinClamp;
        /* 0x610 */ public float VehicleLinearDampingGround;
        /* 0x614 */ public float VehicleAngularDampingGround;
        /* 0x618 */ public float VehicleLinearDampingAerial;
        /* 0x61C */ public float VehicleAngularDampingAerial;
        /* 0x620 */ public float VehicleLinearDampingWater;
        /* 0x624 */ public float VehicleAngularDampingWater;
        /* 0x628 */ public float WheelStartHeight;
        /* 0x62C */ public float WheelEndHeight;
        /* 0x630 */ public float VehicleComCheat;
        /* 0x634 */ public float VehicleAudioSpeedMul;
        /* 0x638 */ public float VehicleAudioTorqueMul;
        /* 0x63C */ public float VehicleAudioSideSkidMul;
        /* 0x640 */ public float VehicleAudioSideSkidThreshold;
        /* 0x644 */ public float VehicleAudioSpinSkidMul;
        /* 0x648 */ public float VehicleAudioSpinSkidThreshold;
        /* 0x64C */ public float AudioImpactSpeedThreshold;
        /* 0x650 */ public float AudioImpactSpeedMul;
        /* 0x654 */ public bool VehicleAudioSwapSkidAndSpeed;
        /* 0x655 */ public NMSString0x80 AudioBoostStart;
        /* 0x6D5 */ public NMSString0x80 AudioBoostStop;
        /* 0x755 */ public NMSString0x80 AudioHornStart;
        /* 0x7D5 */ public NMSString0x80 AudioHornStop;
        /* 0x855 */ public NMSString0x80 AudioIdleExterior;
        /* 0x8D5 */ public NMSString0x80 AudioImpacts;
        /* 0x955 */ public NMSString0x80 AudioStart;
        /* 0x9D5 */ public NMSString0x80 AudioStop;
        /* 0xA55 */ public NMSString0x80 AudioSuspension;
        /* 0xAD5 */ public NMSString0x80 AudioJump;
        /* 0xB55 */ public bool DriveOnTopOfWater;
        /* 0xB58 */ public float VehicleUnderwaterRotateTime;
        /* 0xB5C */ public float VehicleAudioSuspensionThreshold;
        /* 0xB60 */ public float VehicleAudioSuspensionScale;
        /* 0xB64 */ public int NumGrassPushers;
        /* 0xB68 */ public float WheelGrassPusherStrength;
        /* 0xB6C */ public float WheelGrassPusherWobble;
        /* 0xB70 */ public float WheelGrassPusherFrequency;
        /* 0xB74 */ public float WheelGrassPusherReduce;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0xB78 */ public byte[] PaddingB78;
        [NMS(Size = 0xA)]
        /* 0xB80 */ public Vector4f[] WheelGrassPushers;
        /* 0xC20 */ public float CreatureMassScale;
        [NMS(Size = 0x2)]
        /* 0xC24 */ public NMSString0x100[] HeadlightNames;
        [NMS(Size = 0x2)]
        /* 0xE24 */ public NMSString0x100[] CockpitHeadlightNames;
        /* 0x1024 */ public float HeadlightIntensity;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x1028 */ public byte[] EndPadding;
    }
}
