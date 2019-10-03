using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0x55A2F338BBCB7BA, NameHash = 0x7CDF4EDAA0962EA0)]
    public class TkNGuiEditorLayout : NMSTemplate
    {
        [NMS(Size = 0x100)]
        public TkNGuiWindowLayoutData[] Windows;
    }
}
