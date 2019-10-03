using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x181, Alignment = 0x1, GUID = 0x7621C399D9CFCEE, NameHash = 0xF50715D349F22A12)]
    public class TkNGuiLayoutListData : NMSTemplate
    {
        [NMS(Size = 0x80)]
        public string Name;
        [NMS(Size = 0x80)]
        public string Filename;
        [NMS(Size = 0x80)]
        public string Default;
        public bool Autosave;
    }
}
