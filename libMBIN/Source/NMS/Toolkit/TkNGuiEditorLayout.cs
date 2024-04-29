using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x853DB466145A2ACA, NameHash = 0x7CDF4EDAA0962EA0)]
    public class TkNGuiEditorLayout : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x100)]
        /* 0x0 */ public TkNGuiWindowLayoutData[] Windows;
    }
}
