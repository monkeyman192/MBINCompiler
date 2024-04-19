namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAD7B7C55753138F2, NameHash = 0xCCEE5C02303ACEC6)]
    public class GcPlayerCharacterStateData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 AimTree1HPitch;
        /* 0x10 */ public NMSString0x10 AimTree1HYaw;
        /* 0x20 */ public NMSString0x10 AimTree2HPitch;
        /* 0x30 */ public NMSString0x10 AimTree2HYaw;
        /* 0x40 */ public NMSString0x10 AimTreeStaffPitch;
        /* 0x50 */ public NMSString0x10 AimTreeStaffYaw;
        /* 0x60 */ public NMSString0x10 HitReact0H;
        /* 0x70 */ public NMSString0x10 HitReact1H;
        /* 0x80 */ public NMSString0x10 HitReact2H;
        /* 0x90 */ public NMSString0x10 HitReactStaff;
        /* 0xA0 */ public NMSString0x10 Locomotion0H;
        /* 0xB0 */ public NMSString0x10 Locomotion1H;
        /* 0xC0 */ public NMSString0x10 Locomotion2H;
        /* 0xD0 */ public NMSString0x10 LocomotionStaff;
        /* 0xE0 */ public bool KeepHeadForward;
    }
}
