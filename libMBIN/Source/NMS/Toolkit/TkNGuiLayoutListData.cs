using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x181, Alignment = 0x1, GUID = 0x7621C399D9CFCEE, NameHash = 0xF50715D349F22A12)]
    public class TkNGuiLayoutListData : NMSTemplate
    {
        public NMSString0x80 Name;
        public NMSString0x80 Filename;
        public NMSString0x80 Default;
        public bool Autosave;
    }
}
