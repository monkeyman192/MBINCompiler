namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2243E97296DF3C45, NameHash = 0xC402725B)]
    public class GcMoveableObjectComponentData : NMSTemplate
    {
        [NMS(Index = 10)]
        /* 0x000 */ public Vector3f GravGunGrabRotationTarget;
        [NMS(Index = 34)]
        /* 0x010 */ public NMSString0x20A TipLocIdGrab;
        [NMS(Index = 36)]
        /* 0x030 */ public NMSString0x20A TipLocIdGrabNoTech;
        [NMS(Index = 37)]
        /* 0x050 */ public NMSString0x20A TipLocIdGrabShoot;
        [NMS(Index = 38)]
        /* 0x070 */ public NMSString0x20A TipLocIdGrabShootCycle;
        [NMS(Index = 35)]
        /* 0x090 */ public NMSString0x20A TipLocIdGrabUnequipped;
        [NMS(Index = 5)]
        /* 0x0B0 */ public NMSString0x10 DefaultCollisionEffect;
        [NMS(Index = 26)]
        /* 0x0C0 */ public GcFilename ReplicationScene;
        [NMS(Index = 6)]
        /* 0x0D0 */ public NMSString0x10 TerrainCollisionEffect;
        [NMS(Index = 7)]
        /* 0x0E0 */ public float Cooldown;
        [NMS(Index = 25)]
        /* 0x0E4 */ public float DroneImpactDamageModifier;
        [NMS(Index = 24)]
        /* 0x0E8 */ public float DroneImpactStrengthModifier;
        [NMS(Index = 11)]
        /* 0x0EC */ public float EnergyRequiredToGrab;
        [NMS(Index = 8)]
        /* 0x0F0 */ public float GlobalCooldown;
        [NMS(Index = 14)]
        /* 0x0F4 */ public float GravGunGrabDragRotationMultiplier;
        [NMS(Index = 16)]
        /* 0x0F8 */ public float GravGunGrabFreeRotationDampingMultiplier;
        [NMS(Index = 15)]
        /* 0x0FC */ public float GravGunGrabMaxAngularSpeedMultiplier;
        [NMS(Index = 17)]
        /* 0x100 */ public float GravGunGrabPositionSpringMultiplier;
        [NMS(Index = 13)]
        /* 0x104 */ public float GravGunGrabRotationBobTorqueMultiplier;
        [NMS(Index = 18)]
        /* 0x108 */ public float GravGunHoldOffset;
        [NMS(Index = 20)]
        /* 0x10C */ public float GravGunHoldOffsetSide;
        [NMS(Index = 19)]
        /* 0x110 */ public float GravGunHoldOffsetUp;
        [NMS(Index = 30)]
        /* 0x114 */ public float ImmediateMeltdownChance;
        [NMS(Index = 4)]
        /* 0x118 */ public float MaxImpactScale;
        [NMS(Index = 1)]
        /* 0x11C */ public float MaxImpactStrength;
        [NMS(Index = 29)]
        /* 0x120 */ public float MeltdownChance;
        [NMS(Index = 3)]
        /* 0x124 */ public float MinImpactScale;
        [NMS(Index = 0)]
        /* 0x128 */ public float MinImpactStrength;
        [NMS(Index = 2)]
        /* 0x12C */ public float MinRelativeVelocity;
        [NMS(Index = 23)]
        /* 0x130 */ public float OnTruckCooldownModifier;
        [NMS(Index = 22)]
        /* 0x134 */ public float OnTruckImpactStrengthModifier;
        [NMS(Index = 21)]
        /* 0x138 */ public float OnTruckMinRelativeVelocityModifier;
        [NMS(Index = 12)]
        /* 0x13C */ public float SecondsToDisableCollisionAfterGrabbing;
        [NMS(Index = 31)]
        /* 0x140 */ public float SpaceFloaterChanceOnDetatch;
        [NMS(Index = 32)]
        /* 0x144 */ public bool CanGoInBiggs;
        [NMS(Index = 27)]
        /* 0x145 */ public bool MakeMasterModel;
        [NMS(Index = 28)]
        /* 0x146 */ public bool NotifyParentEncounterWhenGrabbed;
        [NMS(Index = 9)]
        /* 0x147 */ public bool UseGravGunGrabRotationTarget;
        [NMS(Index = 33)]
        /* 0x148 */ public bool UseHighlightEffect;
    }
}
