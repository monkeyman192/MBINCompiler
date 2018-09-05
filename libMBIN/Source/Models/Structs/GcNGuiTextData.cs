namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x580, Alignment = 0x10)]
    public class GcNGuiTextData : NMSTemplate
    {
        /* 0x000 */ public GcNGuiElementData Data;
        /* 0x050 */ public TkNGuiTextStyle Style;
        /* 0x140 */ public TkNGuiGraphicStyle GraphicStyle;

        [NMS(Size = 0x80)]
        /* 0x2F0 */ public string Image;

        [NMS(Size = 0x200)]
        /* 0x370 */ public string Text;

        /* 0x570 */ public bool Special;
        [NMS(Size = 0xF, Ignore = true)]
        public byte[] EndPadding;
    }
}
