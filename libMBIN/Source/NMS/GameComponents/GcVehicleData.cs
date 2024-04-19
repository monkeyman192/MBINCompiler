namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB5249A3FF5B2717C, NameHash = 0x904DB42CF570F4BB)]
    public class GcVehicleData : NMSTemplate
    {
        [NMS(Size = 0xA)]
        /* 0x0000 */ public Vector3f[] WheelGrassPushers;
        [NMS(Size = 0xA)]
        /* 0x00A0 */ public Vector3f[] WheelLocs;
        /* 0x0140 */ public Vector3f CollDimensions;
        /* 0x0150 */ public Vector3f CollOffset;
        /* 0x0160 */ public Vector3f ExtraCollOffset;
        /* 0x0170 */ public Vector3f InertiaDimensions;
        /* 0x0180 */ public Vector3f WheelForwardAngularFactor;
        /* 0x0190 */ public Vector3f WheelSideAngularFactor;
        /* 0x01A0 */ public Vector3f WheelSuspensionAngularFactor;
        /* 0x01B0 */ public Vector3f WheelTurnAngularFactor;
        [NMS(Size = 0xA)]
        /* 0x01C0 */ public NMSString0x10[] SuspensionAnimNames;
        /* 0x0260 */ public NMSString0x10 Name;
        /* 0x0270 */ public NMSString0x10 SideSkidParticle;
        /* 0x0280 */ public NMSString0x10 WheelSpinParticle;
        [NMS(Size = 0xA)]
        /* 0x0290 */ public float[] WheelRadiusMultiplier;
        [NMS(Size = 0xA)]
        /* 0x02B8 */ public float[] WheelRayFakeWidthFactor;
        /* 0x02E0 */ public float AudioImpactSpeedMul;
        /* 0x02E4 */ public float AudioImpactSpeedThreshold;
        /* 0x02E8 */ public float CollRadius;
        /* 0x02EC */ public float CreatureMassScale;
        /* 0x02F0 */ public float HardStopSpeedThreshold;
        /* 0x02F4 */ public float HeadlightIntensity;
        /* 0x02F8 */ public float InertiaMul;
        /* 0x02FC */ public int NumGrassPushers;
        /* 0x0300 */ public int NumWheels;
        /* 0x0304 */ public float SideSkidParticleMaxRate;
        /* 0x0308 */ public float SideSkidParticleMaxThresh;
        /* 0x030C */ public float SideSkidParticleMinRate;
        /* 0x0310 */ public float SideSkidParticleMinThresh;
        /* 0x0314 */ public float SteeringWheelPushRange;
        /* 0x0318 */ public float SteeringWheelSpringMultiplier;
        /* 0x031C */ public float TopSpeedForward;
        /* 0x0320 */ public float TopSpeedReverse;
        /* 0x0324 */ public float TurningWheelForce;
        /* 0x0328 */ public float TurningWheelForceDamperVR;
        /* 0x032C */ public float TurningWheelFrictionBraking;
        /* 0x0330 */ public float TurningWheelFrictionNonBraking;
        /* 0x0334 */ public float TurningWheelFrictionOmega;
        /* 0x0338 */ public float UnderwaterAlignDir;
        /* 0x033C */ public float UnderwaterAlignUp;
        /* 0x0340 */ public float UnderwaterEngineDirectionBrake;
        /* 0x0344 */ public float UnderwaterEngineDirectionBrakeVertical;
        /* 0x0348 */ public float UnderwaterEngineFalloff;
        /* 0x034C */ public float UnderwaterEngineMaxSpeed;
        /* 0x0350 */ public float UnderwaterEnginePower;
        /* 0x0354 */ public float VehicleAngularDampingAerial;
        /* 0x0358 */ public float VehicleAngularDampingGround;
        /* 0x035C */ public float VehicleAngularDampingWater;
        /* 0x0360 */ public float VehicleAudioSideSkidMul;
        /* 0x0364 */ public float VehicleAudioSideSkidThreshold;
        /* 0x0368 */ public float VehicleAudioSpeedMul;
        /* 0x036C */ public float VehicleAudioSpinSkidMul;
        /* 0x0370 */ public float VehicleAudioSpinSkidThreshold;
        /* 0x0374 */ public float VehicleAudioSuspensionScale;
        /* 0x0378 */ public float VehicleAudioSuspensionThreshold;
        /* 0x037C */ public float VehicleAudioTorqueMul;
        /* 0x0380 */ public float VehicleBoostExtraMaxSpeedAir;
        /* 0x0384 */ public float VehicleBoostForce;
        /* 0x0388 */ public float VehicleBoostMaxSpeed;
        /* 0x038C */ public float VehicleBoostRechargeTime;
        /* 0x0390 */ public float VehicleBoostSpeedFalloff;
        /* 0x0394 */ public float VehicleBoostTime;
        /* 0x0398 */ public float VehicleComCheat;
        /* 0x039C */ public float VehicleGravity;
        /* 0x03A0 */ public float VehicleGravityWater;
        /* 0x03A4 */ public float VehicleJumpAirControlForce;
        /* 0x03A8 */ public float VehicleJumpAirMaxTorque;
        /* 0x03AC */ public float VehicleJumpAirRotateTimeMax;
        /* 0x03B0 */ public float VehicleJumpAirRotateTimeMin;
        /* 0x03B4 */ public float VehicleJumpAirRotateXAmount;
        /* 0x03B8 */ public float VehicleJumpAirRotateZAmount;
        /* 0x03BC */ public float VehicleJumpForce;
        /* 0x03C0 */ public float VehicleLinearDampingAerial;
        /* 0x03C4 */ public float VehicleLinearDampingGround;
        /* 0x03C8 */ public float VehicleLinearDampingWater;
        /* 0x03CC */ public float VehicleUnderwaterRotateTime;
        /* 0x03D0 */ public float VisualRollAmount;
        /* 0x03D4 */ public float VisualRollOffsetY;
        /* 0x03D8 */ public float WheelDragginess;
        /* 0x03DC */ public float WheelEndHeight;
        /* 0x03E0 */ public float WheelFrontFrictionDynamic;
        /* 0x03E4 */ public float WheelFrontFrictionDynamicThreshold;
        /* 0x03E8 */ public float WheelFrontFrictionOmega;
        /* 0x03EC */ public float WheelFrontFrictionStatic;
        /* 0x03F0 */ public float WheelFrontFrictionStaticThreshold;
        /* 0x03F4 */ public float WheelGrassPusherFrequency;
        /* 0x03F8 */ public float WheelGrassPusherReduce;
        /* 0x03FC */ public float WheelGrassPusherStrength;
        /* 0x0400 */ public float WheelGrassPusherWobble;
        /* 0x0404 */ public float WheelGuardAdjustUpwards;
        /* 0x0408 */ public float WheelGuardExtraHeight;
        /* 0x040C */ public float WheelGuardExtraRadius;
        /* 0x0410 */ public float WheelGuardMassScaleMax;
        /* 0x0414 */ public float WheelGuardMassScaleMin;
        /* 0x0418 */ public float WheelGuardMassScaleMinClamp;
        /* 0x041C */ public float WheelGuardPenetrationScaleMax;
        /* 0x0420 */ public float WheelGuardPenetrationScaleMin;
        /* 0x0424 */ public float WheelGuardPenetrationScaleMinClamp;
        /* 0x0428 */ public float WheelGuardVerticalResponseMax;
        /* 0x042C */ public float WheelGuardVerticalResponseMin;
        /* 0x0430 */ public float WheelMaxAccelForceForward;
        /* 0x0434 */ public float WheelMaxAccelForceReverse;
        /* 0x0438 */ public float WheelMaxDecelForceBraking;
        /* 0x043C */ public float WheelMaxDecelForceNonBraking;
        /* 0x0440 */ public float WheelRadius;
        /* 0x0444 */ public float WheelSideFrictionDynamic;
        /* 0x0448 */ public float WheelSideFrictionDynamicThreshold;
        /* 0x044C */ public float WheelSideFrictionOmega;
        /* 0x0450 */ public float WheelSideFrictionStatic;
        /* 0x0454 */ public float WheelSideFrictionStaticThreshold;
        /* 0x0458 */ public float WheelSpinniness;
        /* 0x045C */ public float WheelSpinParticleMaxRate;
        /* 0x0460 */ public float WheelSpinParticleMaxThresh;
        /* 0x0464 */ public float WheelSpinParticleMinRate;
        /* 0x0468 */ public float WheelSpinParticleMinThresh;
        /* 0x046C */ public float WheelStartHeight;
        /* 0x0470 */ public float WheelSuspensionAnimMax;
        /* 0x0474 */ public float WheelSuspensionAnimMin;
        /* 0x0478 */ public float WheelSuspensionDamping;
        /* 0x047C */ public float WheelSuspensionForce;
        /* 0x0480 */ public float WheelSuspensionlength;
        [NMS(Size = 0x2)]
        /* 0x0484 */ public NMSString0x100[] CockpitHeadlightNames;
        [NMS(Size = 0x2)]
        /* 0x0684 */ public NMSString0x100[] HeadlightNames;
        [NMS(Size = 0x2)]
        /* 0x0884 */ public NMSString0x100[] VolumetricHeadlightNames;
        [NMS(Size = 0xA)]
        /* 0x0A84 */ public NMSString0x20[] WheelNames;
        [NMS(Size = 0xA)]
        /* 0x0BC4 */ public NMSString0x20[] WheelSuspensionNames;
        /* 0x0D04 */ public NMSString0x80 AudioBoostStart;
        /* 0x0D84 */ public NMSString0x80 AudioBoostStop;
        /* 0x0E04 */ public NMSString0x80 AudioHornStart;
        /* 0x0E84 */ public NMSString0x80 AudioHornStop;
        /* 0x0F04 */ public NMSString0x80 AudioIdleExterior;
        /* 0x0F84 */ public NMSString0x80 AudioImpacts;
        /* 0x1004 */ public NMSString0x80 AudioJump;
        /* 0x1084 */ public NMSString0x80 AudioStart;
        /* 0x1104 */ public NMSString0x80 AudioStop;
        /* 0x1184 */ public NMSString0x80 AudioSuspension;
        /* 0x1204 */ public bool CustomCollision;
        /* 0x1205 */ public bool DriveOnTopOfWater;
        /* 0x1206 */ public bool LockVehicleAxis;
        /* 0x1207 */ public bool UseBuggySuspensionHack;
        /* 0x1208 */ public bool UseRoverWheelHack;
        /* 0x1209 */ public bool VehicleAudioSwapSkidAndSpeed;
    }
}
