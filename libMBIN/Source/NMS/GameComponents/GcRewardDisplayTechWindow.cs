namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x241D6EAC69AF02F5, NameHash = 0xC04EFF3E2A378ED7)]
    public class GcRewardDisplayTechWindow : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 TechID;
        [NMS(Index = 1)]
        /* 0x10 */ public bool Damaged;
        [NMS(Index = 3)]
        /* 0x11 */ public bool FullBox;
        [NMS(Index = 2)]
        /* 0x12 */ public bool NeedsInstall;
    }
}
