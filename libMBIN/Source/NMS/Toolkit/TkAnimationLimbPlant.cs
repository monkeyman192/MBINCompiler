namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xE6D4AF20D2E8D0D1, NameHash = 0x411CA0B8)]
    public class TkAnimationLimbPlant : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Limb;
        [NMS(Index = 2)]
        /* 0x10 */ public float EndFrame;
        [NMS(Index = 1)]
        /* 0x14 */ public float StartFrame;
    }
}
