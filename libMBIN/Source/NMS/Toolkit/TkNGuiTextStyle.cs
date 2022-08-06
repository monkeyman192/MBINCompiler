using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0x8348A24965B2CF08, NameHash = 0x55D8E71C0A29B511)]
    public class TkNGuiTextStyle : NMSTemplate
    {
        public TkNGuiTextStyleData Default;
        public TkNGuiTextStyleData Highlight;
        public TkNGuiTextStyleData Active;
    }
}
