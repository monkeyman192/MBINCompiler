namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAD7B7C55753138F2, NameHash = 0xCCEE5C02303ACEC6)]
    public class GcPlayerCharacterStateData : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x00 */ public NMSString0x10 AimTree1HPitch;
        [NMS(Index = 5)]
        /* 0x10 */ public NMSString0x10 AimTree1HYaw;
        [NMS(Index = 6)]
        /* 0x20 */ public NMSString0x10 AimTree2HPitch;
        [NMS(Index = 7)]
        /* 0x30 */ public NMSString0x10 AimTree2HYaw;
        [NMS(Index = 8)]
        /* 0x40 */ public NMSString0x10 AimTreeStaffPitch;
        [NMS(Index = 9)]
        /* 0x50 */ public NMSString0x10 AimTreeStaffYaw;
        [NMS(Index = 10)]
        /* 0x60 */ public NMSString0x10 HitReact0H;
        [NMS(Index = 11)]
        /* 0x70 */ public NMSString0x10 HitReact1H;
        [NMS(Index = 12)]
        /* 0x80 */ public NMSString0x10 HitReact2H;
        [NMS(Index = 13)]
        /* 0x90 */ public NMSString0x10 HitReactStaff;
        [NMS(Index = 0)]
        /* 0xA0 */ public NMSString0x10 Locomotion0H;
        [NMS(Index = 1)]
        /* 0xB0 */ public NMSString0x10 Locomotion1H;
        [NMS(Index = 2)]
        /* 0xC0 */ public NMSString0x10 Locomotion2H;
        [NMS(Index = 3)]
        /* 0xD0 */ public NMSString0x10 LocomotionStaff;
        [NMS(Index = 14)]
        /* 0xE0 */ public bool KeepHeadForward;
    }
}
