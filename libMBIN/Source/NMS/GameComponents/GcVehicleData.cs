namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6073F88D8DD3CCF, NameHash = 0x357DD91E)]
    public class GcVehicleData : NMSTemplate
    {
        [NMS(Index = 136, Size = 0xA)]
        /* 0x0000 */ public Vector3f[] WheelGrassPushers;
        [NMS(Index = 17, Size = 0xA)]
        /* 0x00A0 */ public Vector3f[] WheelLocs;
        [NMS(Index = 26)]
        /* 0x0140 */ public Vector3f CollDimensions;
        [NMS(Index = 24)]
        /* 0x0150 */ public Vector3f CollOffset;
        [NMS(Index = 25)]
        /* 0x0160 */ public Vector3f ExtraCollOffset;
        [NMS(Index = 27)]
        /* 0x0170 */ public Vector3f InertiaDimensions;
        [NMS(Index = 60)]
        /* 0x0180 */ public Vector3f WheelForwardAngularFactor;
        [NMS(Index = 63)]
        /* 0x0190 */ public Vector3f WheelSideAngularFactor;
        [NMS(Index = 62)]
        /* 0x01A0 */ public Vector3f WheelSuspensionAngularFactor;
        [NMS(Index = 61)]
        /* 0x01B0 */ public Vector3f WheelTurnAngularFactor;
        [NMS(Index = 22, Size = 0xA)]
        /* 0x01C0 */ public NMSString0x10[] SuspensionAnimNames;
        [NMS(Index = 0)]
        /* 0x0260 */ public NMSString0x10 Name;
        [NMS(Index = 81)]
        /* 0x0270 */ public NMSString0x10 SideSkidParticle;
        [NMS(Index = 86)]
        /* 0x0280 */ public NMSString0x10 WheelSpinParticle;
        [NMS(Index = 21, Size = 0xA)]
        /* 0x0290 */ public float[] WheelRadiusMultiplier;
        [NMS(Index = 20, Size = 0xA)]
        /* 0x02B8 */ public float[] WheelRayFakeWidthFactor;
        [NMS(Index = 115)]
        /* 0x02E0 */ public float AudioImpactSpeedMul;
        [NMS(Index = 114)]
        /* 0x02E4 */ public float AudioImpactSpeedThreshold;
        [NMS(Index = 28)]
        /* 0x02E8 */ public float CollRadius;
        [NMS(Index = 137)]
        /* 0x02EC */ public float CreatureMassScale;
        [NMS(Index = 43)]
        /* 0x02F0 */ public float HardStopSpeedThreshold;
        [NMS(Index = 141)]
        /* 0x02F4 */ public float HeadlightIntensity;
        [NMS(Index = 29)]
        /* 0x02F8 */ public float InertiaMul;
        [NMS(Index = 131)]
        /* 0x02FC */ public int NumGrassPushers;
        [NMS(Index = 1)]
        /* 0x0300 */ public int NumWheels;
        [NMS(Index = 83)]
        /* 0x0304 */ public float SideSkidParticleMaxRate;
        [NMS(Index = 85)]
        /* 0x0308 */ public float SideSkidParticleMaxThresh;
        [NMS(Index = 82)]
        /* 0x030C */ public float SideSkidParticleMinRate;
        [NMS(Index = 84)]
        /* 0x0310 */ public float SideSkidParticleMinThresh;
        [NMS(Index = 16)]
        /* 0x0314 */ public float SteeringWheelPushRange;
        [NMS(Index = 15)]
        /* 0x0318 */ public float SteeringWheelSpringMultiplier;
        [NMS(Index = 35)]
        /* 0x031C */ public float TopSpeedForward;
        [NMS(Index = 36)]
        /* 0x0320 */ public float TopSpeedReverse;
        [NMS(Index = 55)]
        /* 0x0324 */ public float TurningWheelForce;
        [NMS(Index = 56)]
        /* 0x0328 */ public float TurningWheelForceDamperVR;
        [NMS(Index = 59)]
        /* 0x032C */ public float TurningWheelFrictionBraking;
        [NMS(Index = 58)]
        /* 0x0330 */ public float TurningWheelFrictionNonBraking;
        [NMS(Index = 57)]
        /* 0x0334 */ public float TurningWheelFrictionOmega;
        [NMS(Index = 11)]
        /* 0x0338 */ public float UnderwaterAlignDir;
        [NMS(Index = 12)]
        /* 0x033C */ public float UnderwaterAlignUp;
        [NMS(Index = 9)]
        /* 0x0340 */ public float UnderwaterEngineDirectionBrake;
        [NMS(Index = 10)]
        /* 0x0344 */ public float UnderwaterEngineDirectionBrakeVertical;
        [NMS(Index = 8)]
        /* 0x0348 */ public float UnderwaterEngineFalloff;
        [NMS(Index = 7)]
        /* 0x034C */ public float UnderwaterEngineMaxSpeed;
        [NMS(Index = 6)]
        /* 0x0350 */ public float UnderwaterEnginePower;
        [NMS(Index = 102)]
        /* 0x0354 */ public float VehicleAngularDampingAerial;
        [NMS(Index = 100)]
        /* 0x0358 */ public float VehicleAngularDampingGround;
        [NMS(Index = 104)]
        /* 0x035C */ public float VehicleAngularDampingWater;
        [NMS(Index = 110)]
        /* 0x0360 */ public float VehicleAudioSideSkidMul;
        [NMS(Index = 111)]
        /* 0x0364 */ public float VehicleAudioSideSkidThreshold;
        [NMS(Index = 108)]
        /* 0x0368 */ public float VehicleAudioSpeedMul;
        [NMS(Index = 112)]
        /* 0x036C */ public float VehicleAudioSpinSkidMul;
        [NMS(Index = 113)]
        /* 0x0370 */ public float VehicleAudioSpinSkidThreshold;
        [NMS(Index = 130)]
        /* 0x0374 */ public float VehicleAudioSuspensionScale;
        [NMS(Index = 129)]
        /* 0x0378 */ public float VehicleAudioSuspensionThreshold;
        [NMS(Index = 109)]
        /* 0x037C */ public float VehicleAudioTorqueMul;
        [NMS(Index = 70)]
        /* 0x0380 */ public float VehicleBoostExtraMaxSpeedAir;
        [NMS(Index = 68)]
        /* 0x0384 */ public float VehicleBoostForce;
        [NMS(Index = 69)]
        /* 0x0388 */ public float VehicleBoostMaxSpeed;
        [NMS(Index = 73)]
        /* 0x038C */ public float VehicleBoostRechargeTime;
        [NMS(Index = 71)]
        /* 0x0390 */ public float VehicleBoostSpeedFalloff;
        [NMS(Index = 72)]
        /* 0x0394 */ public float VehicleBoostTime;
        [NMS(Index = 107)]
        /* 0x0398 */ public float VehicleComCheat;
        [NMS(Index = 64)]
        /* 0x039C */ public float VehicleGravity;
        [NMS(Index = 65)]
        /* 0x03A0 */ public float VehicleGravityWater;
        [NMS(Index = 67)]
        /* 0x03A4 */ public float VehicleJumpAirControlForce;
        [NMS(Index = 78)]
        /* 0x03A8 */ public float VehicleJumpAirMaxTorque;
        [NMS(Index = 77)]
        /* 0x03AC */ public float VehicleJumpAirRotateTimeMax;
        [NMS(Index = 76)]
        /* 0x03B0 */ public float VehicleJumpAirRotateTimeMin;
        [NMS(Index = 74)]
        /* 0x03B4 */ public float VehicleJumpAirRotateXAmount;
        [NMS(Index = 75)]
        /* 0x03B8 */ public float VehicleJumpAirRotateZAmount;
        [NMS(Index = 66)]
        /* 0x03BC */ public float VehicleJumpForce;
        [NMS(Index = 101)]
        /* 0x03C0 */ public float VehicleLinearDampingAerial;
        [NMS(Index = 99)]
        /* 0x03C4 */ public float VehicleLinearDampingGround;
        [NMS(Index = 103)]
        /* 0x03C8 */ public float VehicleLinearDampingWater;
        [NMS(Index = 128)]
        /* 0x03CC */ public float VehicleUnderwaterRotateTime;
        [NMS(Index = 13)]
        /* 0x03D0 */ public float VisualRollAmount;
        [NMS(Index = 14)]
        /* 0x03D4 */ public float VisualRollOffsetY;
        [NMS(Index = 42)]
        /* 0x03D8 */ public float WheelDragginess;
        [NMS(Index = 106)]
        /* 0x03DC */ public float WheelEndHeight;
        [NMS(Index = 45)]
        /* 0x03E0 */ public float WheelFrontFrictionDynamic;
        [NMS(Index = 46)]
        /* 0x03E4 */ public float WheelFrontFrictionDynamicThreshold;
        [NMS(Index = 44)]
        /* 0x03E8 */ public float WheelFrontFrictionOmega;
        [NMS(Index = 47)]
        /* 0x03EC */ public float WheelFrontFrictionStatic;
        [NMS(Index = 48)]
        /* 0x03F0 */ public float WheelFrontFrictionStaticThreshold;
        [NMS(Index = 134)]
        /* 0x03F4 */ public float WheelGrassPusherFrequency;
        [NMS(Index = 135)]
        /* 0x03F8 */ public float WheelGrassPusherReduce;
        [NMS(Index = 132)]
        /* 0x03FC */ public float WheelGrassPusherStrength;
        [NMS(Index = 133)]
        /* 0x0400 */ public float WheelGrassPusherWobble;
        [NMS(Index = 5)]
        /* 0x0404 */ public float WheelGuardAdjustUpwards;
        [NMS(Index = 4)]
        /* 0x0408 */ public float WheelGuardExtraHeight;
        [NMS(Index = 3)]
        /* 0x040C */ public float WheelGuardExtraRadius;
        [NMS(Index = 97)]
        /* 0x0410 */ public float WheelGuardMassScaleMax;
        [NMS(Index = 96)]
        /* 0x0414 */ public float WheelGuardMassScaleMin;
        [NMS(Index = 98)]
        /* 0x0418 */ public float WheelGuardMassScaleMinClamp;
        [NMS(Index = 94)]
        /* 0x041C */ public float WheelGuardPenetrationScaleMax;
        [NMS(Index = 93)]
        /* 0x0420 */ public float WheelGuardPenetrationScaleMin;
        [NMS(Index = 95)]
        /* 0x0424 */ public float WheelGuardPenetrationScaleMinClamp;
        [NMS(Index = 92)]
        /* 0x0428 */ public float WheelGuardVerticalResponseMax;
        [NMS(Index = 91)]
        /* 0x042C */ public float WheelGuardVerticalResponseMin;
        [NMS(Index = 37)]
        /* 0x0430 */ public float WheelMaxAccelForceForward;
        [NMS(Index = 38)]
        /* 0x0434 */ public float WheelMaxAccelForceReverse;
        [NMS(Index = 40)]
        /* 0x0438 */ public float WheelMaxDecelForceBraking;
        [NMS(Index = 39)]
        /* 0x043C */ public float WheelMaxDecelForceNonBraking;
        [NMS(Index = 2)]
        /* 0x0440 */ public float WheelRadius;
        [NMS(Index = 50)]
        /* 0x0444 */ public float WheelSideFrictionDynamic;
        [NMS(Index = 51)]
        /* 0x0448 */ public float WheelSideFrictionDynamicThreshold;
        [NMS(Index = 49)]
        /* 0x044C */ public float WheelSideFrictionOmega;
        [NMS(Index = 52)]
        /* 0x0450 */ public float WheelSideFrictionStatic;
        [NMS(Index = 53)]
        /* 0x0454 */ public float WheelSideFrictionStaticThreshold;
        [NMS(Index = 41)]
        /* 0x0458 */ public float WheelSpinniness;
        [NMS(Index = 88)]
        /* 0x045C */ public float WheelSpinParticleMaxRate;
        [NMS(Index = 90)]
        /* 0x0460 */ public float WheelSpinParticleMaxThresh;
        [NMS(Index = 87)]
        /* 0x0464 */ public float WheelSpinParticleMinRate;
        [NMS(Index = 89)]
        /* 0x0468 */ public float WheelSpinParticleMinThresh;
        [NMS(Index = 105)]
        /* 0x046C */ public float WheelStartHeight;
        [NMS(Index = 34)]
        /* 0x0470 */ public float WheelSuspensionAnimMax;
        [NMS(Index = 33)]
        /* 0x0474 */ public float WheelSuspensionAnimMin;
        [NMS(Index = 32)]
        /* 0x0478 */ public float WheelSuspensionDamping;
        [NMS(Index = 31)]
        /* 0x047C */ public float WheelSuspensionForce;
        [NMS(Index = 30)]
        /* 0x0480 */ public float WheelSuspensionlength;
        [NMS(Index = 140, Size = 0x2)]
        /* 0x0484 */ public NMSString0x100[] CockpitHeadlightNames;
        [NMS(Index = 138, Size = 0x2)]
        /* 0x0684 */ public NMSString0x100[] HeadlightNames;
        [NMS(Index = 139, Size = 0x2)]
        /* 0x0884 */ public NMSString0x100[] VolumetricHeadlightNames;
        [NMS(Index = 18, Size = 0xA)]
        /* 0x0A84 */ public NMSString0x20[] WheelNames;
        [NMS(Index = 19, Size = 0xA)]
        /* 0x0BC4 */ public NMSString0x20[] WheelSuspensionNames;
        [NMS(Index = 117)]
        /* 0x0D04 */ public NMSString0x80 AudioBoostStart;
        [NMS(Index = 118)]
        /* 0x0D84 */ public NMSString0x80 AudioBoostStop;
        [NMS(Index = 119)]
        /* 0x0E04 */ public NMSString0x80 AudioHornStart;
        [NMS(Index = 120)]
        /* 0x0E84 */ public NMSString0x80 AudioHornStop;
        [NMS(Index = 121)]
        /* 0x0F04 */ public NMSString0x80 AudioIdleExterior;
        [NMS(Index = 122)]
        /* 0x0F84 */ public NMSString0x80 AudioImpacts;
        [NMS(Index = 126)]
        /* 0x1004 */ public NMSString0x80 AudioJump;
        [NMS(Index = 123)]
        /* 0x1084 */ public NMSString0x80 AudioStart;
        [NMS(Index = 124)]
        /* 0x1104 */ public NMSString0x80 AudioStop;
        [NMS(Index = 125)]
        /* 0x1184 */ public NMSString0x80 AudioSuspension;
        [NMS(Index = 23)]
        /* 0x1204 */ public bool CustomCollision;
        [NMS(Index = 127)]
        /* 0x1205 */ public bool DriveOnTopOfWater;
        [NMS(Index = 54)]
        /* 0x1206 */ public bool LockVehicleAxis;
        [NMS(Index = 79)]
        /* 0x1207 */ public bool UseBuggySuspensionHack;
        [NMS(Index = 80)]
        /* 0x1208 */ public bool UseRoverWheelHack;
        [NMS(Index = 116)]
        /* 0x1209 */ public bool VehicleAudioSwapSkidAndSpeed;
    }
}
