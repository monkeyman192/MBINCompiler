namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4B56DD8166CBA2AB, NameHash = 0xFAC452E6BECE8553)]
    public class GcShipHUDTargetIconData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x000 */ public NMSString0x80 Corner;
        [NMS(Index = 3)]
        /* 0x080 */ public NMSString0x80 GlowCorner;
        [NMS(Index = 4)]
        /* 0x100 */ public NMSString0x80 GlowLineHorizontal;
        [NMS(Index = 5)]
        /* 0x180 */ public NMSString0x80 GlowLineVertical;
        [NMS(Index = 1)]
        /* 0x200 */ public NMSString0x80 LineHorizontal;
        [NMS(Index = 2)]
        /* 0x280 */ public NMSString0x80 LineVertical;
    }
}
