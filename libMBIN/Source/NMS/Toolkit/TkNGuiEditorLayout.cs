using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xDB8062CC3F7B6833, NameHash = 0x7CDF4EDAA0962EA0)]
    public class TkNGuiEditorLayout : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x100)]
        /* 0x0 */ public TkNGuiWindowLayoutData[] Windows;
    }
}
