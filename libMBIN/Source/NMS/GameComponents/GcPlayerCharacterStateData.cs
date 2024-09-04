namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x70BE21BCDE25EC1E, NameHash = 0xAED0F936)]
    public class GcPlayerCharacterStateData : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x000 */ public NMSString0x10 AimTree1HPitch;
        [NMS(Index = 5)]
        /* 0x010 */ public NMSString0x10 AimTree1HYaw;
        [NMS(Index = 6)]
        /* 0x020 */ public NMSString0x10 AimTree2HPitch;
        [NMS(Index = 7)]
        /* 0x030 */ public NMSString0x10 AimTree2HYaw;
        [NMS(Index = 10)]
        /* 0x040 */ public NMSString0x10 AimTreeFishingPitch;
        [NMS(Index = 11)]
        /* 0x050 */ public NMSString0x10 AimTreeFishingYaw;
        [NMS(Index = 8)]
        /* 0x060 */ public NMSString0x10 AimTreeStaffPitch;
        [NMS(Index = 9)]
        /* 0x070 */ public NMSString0x10 AimTreeStaffYaw;
        [NMS(Index = 12)]
        /* 0x080 */ public NMSString0x10 HitReact0H;
        [NMS(Index = 13)]
        /* 0x090 */ public NMSString0x10 HitReact1H;
        [NMS(Index = 14)]
        /* 0x0A0 */ public NMSString0x10 HitReact2H;
        [NMS(Index = 15)]
        /* 0x0B0 */ public NMSString0x10 HitReactStaff;
        [NMS(Index = 0)]
        /* 0x0C0 */ public NMSString0x10 Locomotion0H;
        [NMS(Index = 1)]
        /* 0x0D0 */ public NMSString0x10 Locomotion1H;
        [NMS(Index = 2)]
        /* 0x0E0 */ public NMSString0x10 Locomotion2H;
        [NMS(Index = 3)]
        /* 0x0F0 */ public NMSString0x10 LocomotionStaff;
        [NMS(Index = 16)]
        /* 0x100 */ public bool KeepHeadForward;
    }
}
