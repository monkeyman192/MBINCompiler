namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4B56DD8166CBA2AB, NameHash = 0x99208CD6)]
    public class GcShipHUDTargetIconData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public VariableSizeString Corner;
        [NMS(Index = 3)]
        /* 0x10 */ public VariableSizeString GlowCorner;
        [NMS(Index = 4)]
        /* 0x20 */ public VariableSizeString GlowLineHorizontal;
        [NMS(Index = 5)]
        /* 0x30 */ public VariableSizeString GlowLineVertical;
        [NMS(Index = 1)]
        /* 0x40 */ public VariableSizeString LineHorizontal;
        [NMS(Index = 2)]
        /* 0x50 */ public VariableSizeString LineVertical;
    }
}
