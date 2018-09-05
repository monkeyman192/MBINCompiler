namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x280, Alignment = 0x10)]
    public class GcNGuiGraphicData : NMSTemplate
    {
        /* 0x000 */ public GcNGuiElementData ElementData;
        /* 0x050 */ public TkNGuiGraphicStyle Style;

        [NMS(Size = 0x80)]
        public string Image;
    }
}
